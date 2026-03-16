using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using SystemMonitor.Services;

namespace SystemMonitor
{
    public partial class MainWindow : Window
    {
        private readonly Dictionary<int, double> _prevCpuByPid = new();

        private readonly DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += async (s, e) => await UpdateTimer_Tick();
            _timer.Start();
        }

        private async Task UpdateTimer_Tick()
        {
            await UpdateProcessList();

            try
            {
                int cpuUsage = await Task.Run(() => SystemInfo.GetCpuUsagePercent());
                int memoryUsage = await Task.Run(() => SystemInfo.GetMemoryUsagePercent());
                int diskUsage = await Task.Run(() => SystemInfo.GetDiskUsagePercent());

                CpuProgressBar.Value = cpuUsage;
                CpuLabel.Text = $"CPU: {cpuUsage}%";

                MemoryProgressBar.Value = memoryUsage;
                MemoryLabel.Text = $"Memory: {memoryUsage}%";

                DiskProgressBar.Value = diskUsage;
                DiskLabel.Text = $"Disk: {diskUsage}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task UpdateProcessList()
        {
            // execute every item in background
            List<ProcessViewItem> items = await Task.Run(() =>
            {
                List<Process> processes = ProcessManager.GetAllProcesses();
                List<ProcessViewItem> result = new List<ProcessViewItem>();

                foreach (var p in processes)
                {
                    int pid = p.Id;

                    double currCpu = SystemInfo.GetCpuUsagePercentForProcess(pid);

                    bool isSpike = false;
                    if (_prevCpuByPid.TryGetValue(pid, out double prevCpu))
                    {
                        bool bigJump = (currCpu - prevCpu) >= 40.0;
                        bool highEnough = currCpu >= 60.0;
                        bool wasRunning = prevCpu >= 5.0;

                        if (bigJump && highEnough && wasRunning)
                            isSpike = true;

                        _prevCpuByPid[pid] = currCpu;
                    }
                    else
                    {
                        _prevCpuByPid[pid] = currCpu;
                    }

                    double memMb = Math.Round(p.WorkingSet64 / 1024.0 / 1024.0, 1);

                    result.Add(new ProcessViewItem
                    {
                        Pid = pid,
                        ProcessName = p.ProcessName,
                        MemoryMb = memMb,
                        CpuPercent = Math.Round(currCpu, 1),
                        IsCpuSpike = isSpike
                    });
                }

                return result;
            });
            Title = $"System Monitor - {items.Count} processes";
            ProcessDataGrid.ItemsSource = items;
        }
    }
    public class ProcessViewItem
    {
        public string ProcessName { get; set; }
        public double MemoryMb { get; set; }
        public int Pid { get; set; }          
        public double CpuPercent { get; set; }   
        public bool IsCpuSpike { get; set; }     
    }


}
