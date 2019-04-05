

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Management;
using HappyBirthdate.Day.Annotations;

namespace HappyBirthday.Model
{
    [Serializable]
    internal class MyProcess
    {
        private  readonly Process _process;

        readonly dynamic _extraProcessInfo;


        public Process Process => _process;
        public string Name => _process.ProcessName;
        public int Id => _process.Id;
        public string UserName => _extraProcessInfo.Username;

        public string Path => _extraProcessInfo.Path;

        public DateTime LaunchDateTime
        {
           get
            {
        //        try
        //        {
        //            return _process.StartTime;
        //        }
        //        catch (Win32Exception)
        //        {
                    return DateTime.Now;
                   //}

            }
        }


        public string IsActive => (_process.Responding ? "Responding" : "Not responding");

        private static DateTime lastTime;
        private static TimeSpan lastTotalProcessorTime;
        private static DateTime curTime;
        private static TimeSpan curTotalProcessorTime;

        public double Cpu
        {
            get
            {
                PerformanceCounter CpuCounter = new PerformanceCounter("Process", "% Processor Time", _process.ProcessName);
                CpuCounter.NextValue();
                return CpuCounter.NextValue();
            }
           
        }


        public string  Memory => BytesToReadableValue(_process.PrivateMemorySize64);
        public int NumOfThreads => _process.Threads.Count;

        private ObservableCollection<MyThread> _threads;


        private ObservableCollection<Module> _modules;

        public ObservableCollection<Module> Modules
        {
            get
            {
                if (_modules == null)
                    RefreshModules();
                return _modules;
            }
        }

        public ObservableCollection<MyThread> Threads
        {
            get
            {
                if (_threads == null)
                    RefreshThreads();
                return _threads;
            }
        }

        internal MyProcess([NotNull] Process process)
        {
            _process = process;
            _extraProcessInfo = GetProcessExtraInformation(_process.Id);
        }

        internal void RefreshModules()
        {
            if (_modules == null)
                _modules = new ObservableCollection<Module>();
            foreach (ProcessModule pm in _process.Modules)
            {
                _modules.Add(new Module(pm));
            }
        }

        internal void RefreshThreads()
        {
            if (_threads == null)
                _threads = new ObservableCollection<MyThread>();
            foreach (ProcessThread pt in _process.Threads)
            {
                _threads.Add(new MyThread(pt));
            }
        }

        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        public static ExpandoObject GetProcessExtraInformation(int processId)
        {
            // Query the Win32_Process
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Create a dynamic object to store some properties on it
            dynamic response = new ExpandoObject();
            response.Path = "Unknown";
            response.Username = "Unknown";

            foreach (var o in processList)
            {
                var obj = (ManagementObject) o;

                object[] argList = { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                   

                    response.Username = argList[0];

                   
                }

                
                if (obj["ExecutablePath"] != null)
                {
                   
                        response.Path = obj["ExecutablePath"].ToString();
                    
                }
            }

            return response;
        }
    }
}
