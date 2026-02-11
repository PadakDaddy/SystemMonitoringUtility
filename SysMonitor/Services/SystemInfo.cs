using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SystemMonitor.Services
{
    public class SystemInfo
    {
        //Get total memory (RAM)
        public static long GetTotalMemory()
        {
            try
            {
                ManagementClass computerSystemClass = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection systeminstances = computerSystemClass.GetInstances();
                ManagementObject systemObject = null;
                foreach (ManagementObject instance in systeminstances)
                {
                    systemObject = instance;
                    break;
                }
                //if there is no information, return 0
                if (systemObject == null)
                {
                    return 0;
                }
                //Get the total memory size
                string totalMemory = systemObject["TotalPhysicalMemory"].ToString();
                return long.Parse(totalMemory);
            }
            catch { return 0; }
        }

        //Get available memory
        public static long GetAvailableMemory()
        {
            try
            {
                ManagementClass operatingSystemClass = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection osInstances = operatingSystemClass.GetInstances();
                ManagementObject osObject = null;
                foreach (ManagementObject instance in osInstances)
                {
                    osObject = instance;
                    break;  // Stop after getting the first one
                }

                if (osObject == null)
                    return 0;

                string availableMemoryString = osObject["FreePhysicalMemory"].ToString();
                return long.Parse(availableMemoryString) * 1024;  // 1 KB = 1024 bytes
            }
            catch
            {
                return 0;
            }
        }

        //Get portion of memory usage
        public static int GetMemoryUsagePercent()
        {
            long totalMemorySize = GetTotalMemory();
            long availableMemorySize = GetAvailableMemory();

            if (totalMemorySize == 0)
                return 0;

            long usedMemory = totalMemorySize - availableMemorySize;
            return (int)((usedMemory * 100) / totalMemorySize);
        }

        //Get portion of CPU usage
        public static int GetCpuUsagePercent()
        {
            try
            {
                // Make a new Performance Counter for CPU
                PerformanceCounter cpuCounter = new PerformanceCounter(
                    "Processor",
                    "% Processor Time",
                    "_Total"
                );

                cpuCounter.NextValue();
                System.Threading.Thread.Sleep(100);
                return (int)cpuCounter.NextValue();
            }
            catch
            {
                // If there is an error, return 0
                return 0;
            }
        }

        // Get Windows version
        public static string GetWindowsVersion()
        {
            try
            {
                ManagementClass operatingSystemClass = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectCollection osInstances = operatingSystemClass.GetInstances();
                ManagementObject osObject = null;
                foreach (ManagementObject instance in osInstances)
                {
                    osObject = instance;
                    break; 
                }

                if (osObject == null)
                    return "Unknown";

                // Get the Windows version name and return
                return osObject["Caption"].ToString();
            }
            catch
            {
                // If there is an error, return "Unknown"
                return "Unknown";
            }
        }

        public static int GetDiskUsagePercent()
        {
            try
            {
                //get disk information 
                System.IO.DriveInfo drive = new System.IO.DriveInfo("C:\\");

                //calculate total size, usage amount
                long totalSize = drive.TotalSize;
                long availableSpace = drive.AvailableFreeSpace;

                //calculate percetage of usage portion
                long usedSpace = totalSize - availableSpace;
                int percent = (int)(usedSpace*100 / totalSize);

                return percent;
            }
            catch
            {
                return 0;
            }
        }

    }
}
