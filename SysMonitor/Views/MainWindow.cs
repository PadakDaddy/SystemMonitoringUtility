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
                

        private void systemInfoGB_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
