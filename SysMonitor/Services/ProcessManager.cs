using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor.Services
{
    public class ProcessManager
    {
        public static List<Process> GetAllProcesses()
        {
            //1. create List
            List<Process> processList = new List<Process>();

            //2. Get Processes
            Process[] processes = Process.GetProcesses();

            //3. put all processes in list
            foreach (Process p in processes)
            {
                processList.Add(p);
            }

            //4. return list
            return processList;
        }
    }
}
