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
                //Open the computer system information
                ManagementClass computerSystemClass = new ManagementClass("Win32_ComputerSystem");
                //Get all system information
                ManagementObjectCollection systeminstances = computerSystemClass.GetInstances();

                //Take the first system information
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
                //Change text to number and return
                return long.Parse(totalMemory);
            }
            catch { return 0; }
        }

        //Get available memory
        public static long GetAvailableMemory()
        {
            try
            {
                // Open the operating system information
                ManagementClass operatingSystemClass = new ManagementClass("Win32_OperatingSystem");

                // Get all operating system information
                ManagementObjectCollection osInstances = operatingSystemClass.GetInstances();

                // Take the first operating system information
                ManagementObject osObject = null;
                foreach (ManagementObject instance in osInstances)
                {
                    osObject = instance;
                    break;  // Stop after getting the first one
                }

                // If there is no information, return 0
                if (osObject == null)
                    return 0;

                // Get free memory (it is in KB, so change to bytes)
                string availableMemoryString = osObject["FreePhysicalMemory"].ToString();
                return long.Parse(availableMemoryString) * 1024;  // 1 KB = 1024 bytes
            }
            catch
            {
                // If there is an error, return 0
                return 0;
            }
        }

        //Get portion of memory usage
        public static int GetMemoryUsagePercent()
        {
            // Get total memory and available memory
            long totalMemorySize = GetTotalMemory();
            long availableMemorySize = GetAvailableMemory();

            // If total is 0, return 0 (no data)
            if (totalMemorySize == 0)
                return 0;

            // Calculate how much memory is being used
            long usedMemory = totalMemorySize - availableMemorySize;

            // Return the percentage (0 to 100)
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

                // First read (this is not important, just to start)
                cpuCounter.NextValue();

                // Wait 100 milliseconds
                System.Threading.Thread.Sleep(100);

                // Second read (this is the real number)
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
                // Open the operating system information
                ManagementClass operatingSystemClass = new ManagementClass("Win32_OperatingSystem");

                // Get all operating system information
                ManagementObjectCollection osInstances = operatingSystemClass.GetInstances();

                // Take the first operating system information
                ManagementObject osObject = null;
                foreach (ManagementObject instance in osInstances)
                {
                    osObject = instance;
                    break;  // Stop after getting the first one
                }

                // If there is no information, return "Unknown"
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

    }
}
