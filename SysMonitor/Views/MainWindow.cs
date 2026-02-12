using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using SystemMonitor.Services;


namespace SystemMonitor.Views
{
    public partial class MainWindow : Form
    {
        //Timer for updating data every 1 second.
        private System.Windows.Forms.Timer updateTimer;
        public MainWindow()
        {
            InitializeComponent();
            SetupTimer();
        }

        private void SetupTimer()
        {
            // create Timer
            updateTimer = new System.Windows.Forms.Timer();

            //Interval 1 second
            updateTimer.Interval = 1000;

            updateTimer.Tick += UpdateTimer_Tick;

            //Timer start
            updateTimer.Start();
        }
                
        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //Get CPU,Memory(background)
                int cpuUsage = await Task.Run(()=> SystemInfo.GetCpuUsagePercent());
                int memoryUsage = await Task.Run(()=> SystemInfo.GetMemoryUsagePercent());
                int diskUsage = await Task.Run(()=> SystemInfo.GetDiskUsagePercent());
                //UI update
                cpuProgressBar.Value = cpuUsage;
                cpuLabel.Text = $"CPU: {cpuUsage}%";

                memoryProgressBar.Value = memoryUsage;
                memoryLabel.Text = $"Memory: {memoryUsage}%";

                diskProgressBar.Value = diskUsage;
                diskLabel.Text = $"Disk: {diskUsage}%";
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void systemInfoGB_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
