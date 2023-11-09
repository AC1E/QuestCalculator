using System;
using System.Diagnostics;
using System.Linq;

namespace Pilot_FrameWork
{
    public class ProcessesHelpers
    {
        public static Process GetProcessByName(string processName)
        {
            return Process.GetProcessesByName(processName).FirstOrDefault();
        }
        public static bool ProcessExists(string processName)
        {
            return GetProcessByName(processName) != null;
        }
        public void KillMultipleInstancesOfProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {    
                 process.Kill();
                 process.Dispose();
                  
            }
        }

    }
}
