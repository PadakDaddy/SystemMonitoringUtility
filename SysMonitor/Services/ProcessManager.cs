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
        /// <summary>
        /// Get all processes
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get memory of specific process
        /// </summary>
        /// <param name="process"></param>
        /// <returns></returns>
        public static double GetProcessMemory(Process process)
        {
            //1. Get Process.WorkingSet
            long memoryInBytes = process.WorkingSet64;
            //2. convert byte to MB
            double memoryInMB = memoryInBytes / 1024 / 1024;
            //3. Return
            return memoryInMB;
        }

        public static Process GetHighestMemoryProcess()
        {
            //get all process
            List<Process> allProcesses = GetAllProcesses();

            //search highest memory process
            double highestMemory = 0;
            Process highestProcess = null;

            foreach (Process p in allProcesses)
            {
                double currentMemory = GetProcessMemory(p);
                if (currentMemory > highestMemory)
                {
                    highestMemory = currentMemory;
                    highestProcess = p;
                }
            }
            //return
            return highestProcess;
        }
    }
}
