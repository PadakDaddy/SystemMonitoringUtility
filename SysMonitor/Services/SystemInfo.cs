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

        //Get portion of memory usage

        //Get portion of CPU usage

        //Get windows version
    }
}
