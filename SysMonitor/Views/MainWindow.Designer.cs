namespace SystemMonitor.Views
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.systemInfoGB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuPB = new System.Windows.Forms.ProgressBar();
            this.cpuLb = new System.Windows.Forms.Label();
            this.processDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MemoryPB = new System.Windows.Forms.ProgressBar();
            this.memoryLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.diskLb = new System.Windows.Forms.Label();
            this.systemInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // systemInfoGB
            // 
            this.systemInfoGB.Controls.Add(this.diskLb);
            this.systemInfoGB.Controls.Add(this.progressBar1);
            this.systemInfoGB.Controls.Add(this.label3);
            this.systemInfoGB.Controls.Add(this.memoryLb);
            this.systemInfoGB.Controls.Add(this.MemoryPB);
            this.systemInfoGB.Controls.Add(this.label2);
            this.systemInfoGB.Controls.Add(this.label1);
            this.systemInfoGB.Controls.Add(this.cpuLb);
            this.systemInfoGB.Controls.Add(this.cpuPB);
            this.systemInfoGB.Location = new System.Drawing.Point(2, 12);
            this.systemInfoGB.Name = "systemInfoGB";
            this.systemInfoGB.Size = new System.Drawing.Size(1011, 312);
            this.systemInfoGB.TabIndex = 0;
            this.systemInfoGB.TabStop = false;
            this.systemInfoGB.Text = "System Information";
            this.systemInfoGB.Enter += new System.EventHandler(this.systemInfoGB_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"CPU\"";
            // 
            // cpuPB
            // 
            this.cpuPB.Location = new System.Drawing.Point(125, 47);
            this.cpuPB.Name = "cpuPB";
            this.cpuPB.Size = new System.Drawing.Size(100, 23);
            this.cpuPB.TabIndex = 1;
            // 
            // cpuLb
            // 
            this.cpuLb.AutoSize = true;
            this.cpuLb.Location = new System.Drawing.Point(248, 47);
            this.cpuLb.Name = "cpuLb";
            this.cpuLb.Size = new System.Drawing.Size(90, 18);
            this.cpuLb.TabIndex = 2;
            this.cpuLb.Text = "\"CPU: 0%\"";
            // 
            // processDGV
            // 
            this.processDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDGV.Location = new System.Drawing.Point(12, 429);
            this.processDGV.Name = "processDGV";
            this.processDGV.RowHeadersWidth = 62;
            this.processDGV.RowTemplate.Height = 30;
            this.processDGV.Size = new System.Drawing.Size(731, 150);
            this.processDGV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "\"Memory\"";
            // 
            // MemoryPB
            // 
            this.MemoryPB.Location = new System.Drawing.Point(125, 82);
            this.MemoryPB.Name = "MemoryPB";
            this.MemoryPB.Size = new System.Drawing.Size(100, 23);
            this.MemoryPB.TabIndex = 4;
            // 
            // memoryLb
            // 
            this.memoryLb.AutoSize = true;
            this.memoryLb.Location = new System.Drawing.Point(248, 82);
            this.memoryLb.Name = "memoryLb";
            this.memoryLb.Size = new System.Drawing.Size(123, 18);
            this.memoryLb.TabIndex = 5;
            this.memoryLb.Text = "\"Memory: 0%\"";
            this.memoryLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "\"Disk\"";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // diskLb
            // 
            this.diskLb.AutoSize = true;
            this.diskLb.Location = new System.Drawing.Point(248, 116);
            this.diskLb.Name = "diskLb";
            this.diskLb.Size = new System.Drawing.Size(89, 18);
            this.diskLb.TabIndex = 8;
            this.diskLb.Text = "\"Disk: 0%\"";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 618);
            this.Controls.Add(this.processDGV);
            this.Controls.Add(this.systemInfoGB);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.systemInfoGB.ResumeLayout(false);
            this.systemInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox systemInfoGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar cpuPB;
        private System.Windows.Forms.Label cpuLb;
        private System.Windows.Forms.DataGridView processDGV;
        private System.Windows.Forms.Label memoryLb;
        private System.Windows.Forms.ProgressBar MemoryPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diskLb;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
    }
}