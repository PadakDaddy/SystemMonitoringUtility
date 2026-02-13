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
            List<Process> allProcesses = await Task.Run(() =>
                ProcessManager.GetAllProcesses()
            );

            var items = allProcesses.Select(p => new ProcessViewItem
            {
                ProcessName = p.ProcessName,
                MemoryMb = Math.Round(p.WorkingSet64 / 1024.0 / 1024.0, 1)
            }).ToList();

            ProcessDataGrid.ItemsSource = items;
        }
    }

    public class ProcessViewItem
    {
        public string ProcessName { get; set; }
        public double MemoryMb { get; set; }
    }
}
