﻿

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
        readonly dynamic _extraProcessInfo;


        public Process Process { get; }

        public string Name => Process.ProcessName;
        public int Id => Process.Id;
        public string UserName => _extraProcessInfo.Username;

        public string Path => _extraProcessInfo.Path;

        public DateTime LaunchDateTime
        {
           get
            {
                try
                {
                    return Process.StartTime;
                }
                catch (Win32Exception)
                {
                    return DateTime.Now;
                }

            }
        }


        public string IsActive => (Process.Responding ? "Responding" : "Not responding");


        public double Cpu
        {
            get
            {
                PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", Process.ProcessName);
                cpuCounter.NextValue();
                return cpuCounter.NextValue();
            }

        }


        public string  Memory => BytesToReadableValue(Process.PrivateMemorySize64);
        public int NumOfThreads => Process.Threads.Count;

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
            Process = process;
            _extraProcessInfo = GetProcessExtraInformation(Process.Id);
        }

        internal void RefreshModules()
        {
            if (_modules == null)
                _modules = new ObservableCollection<Module>();
            foreach (ProcessModule pm in Process.Modules)
            {
                _modules.Add(new Module(pm));
            }
        }

        internal void RefreshThreads()
        {
            if (_threads == null)
                _threads = new ObservableCollection<MyThread>();
            foreach (ProcessThread pt in Process.Threads)
            {
                _threads.Add(new MyThread(pt));
            }
        }

        public string BytesToReadableValue(long number)
        {
            var suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (var i = 0; i < suffixes.Count; i++)
            {
                var temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        public static ExpandoObject GetProcessExtraInformation(int processId)
        {
           
            var query = "Select * From Win32_Process Where ProcessID = " + processId;
            var searcher = new ManagementObjectSearcher(query);
            var processList = searcher.Get();

            
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
