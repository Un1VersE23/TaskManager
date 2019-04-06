

using System;
using System.ComponentModel;
using System.Diagnostics;
using HappyBirthdate.Day.Annotations;

namespace HappyBirthday.Model
{
   
    class MyThread
    {

        private readonly ProcessThread _thread;

        public int Id => _thread.Id;
        public ThreadState State => _thread.ThreadState;

        public DateTime LaunchDateTime
        {
            get
            {
                try
                {
                    return _thread.StartTime;
                }
                catch (Win32Exception e)
                {
                   return DateTime.Now;
                }
            }
        }

        internal MyThread([NotNull] ProcessThread thread)
        {
            this._thread = thread;
        }
    }

}
