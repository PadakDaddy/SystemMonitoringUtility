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
            this.systemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuProgressBar = new System.Windows.Forms.ProgressBar();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.processDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryProgressBar = new System.Windows.Forms.ProgressBar();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diskProgressBar = new System.Windows.Forms.ProgressBar();
            this.diskLabel = new System.Windows.Forms.Label();
            this.systemInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // systemInfoGroupBox
            // 
            this.systemInfoGroupBox.Controls.Add(this.diskLabel);
            this.systemInfoGroupBox.Controls.Add(this.diskProgressBar);
            this.systemInfoGroupBox.Controls.Add(this.label3);
            this.systemInfoGroupBox.Controls.Add(this.memoryLabel);
            this.systemInfoGroupBox.Controls.Add(this.memoryProgressBar);
            this.systemInfoGroupBox.Controls.Add(this.label2);
            this.systemInfoGroupBox.Controls.Add(this.label1);
            this.systemInfoGroupBox.Controls.Add(this.cpuLabel);
            this.systemInfoGroupBox.Controls.Add(this.cpuProgressBar);
            this.systemInfoGroupBox.Location = new System.Drawing.Point(2, 12);
            this.systemInfoGroupBox.Name = "systemInfoGroupBox";
            this.systemInfoGroupBox.Size = new System.Drawing.Size(1011, 312);
            this.systemInfoGroupBox.TabIndex = 0;
            this.systemInfoGroupBox.TabStop = false;
            this.systemInfoGroupBox.Text = "System Information";
            this.systemInfoGroupBox.Enter += new System.EventHandler(this.systemInfoGB_Enter);
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
            // cpuProgressBar
            // 
            this.cpuProgressBar.Location = new System.Drawing.Point(125, 47);
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.Size = new System.Drawing.Size(100, 23);
            this.cpuProgressBar.TabIndex = 1;
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(248, 47);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(90, 18);
            this.cpuLabel.TabIndex = 2;
            this.cpuLabel.Text = "\"CPU: 0%\"";
            // 
            // processDataGridView
            // 
            this.processDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDataGridView.Location = new System.Drawing.Point(12, 429);
            this.processDataGridView.Name = "processDataGridView";
            this.processDataGridView.RowHeadersWidth = 62;
            this.processDataGridView.RowTemplate.Height = 30;
            this.processDataGridView.Size = new System.Drawing.Size(731, 150);
            this.processDataGridView.TabIndex = 3;
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
            // memoryProgressBar
            // 
            this.memoryProgressBar.Location = new System.Drawing.Point(125, 82);
            this.memoryProgressBar.Name = "memoryProgressBar";
            this.memoryProgressBar.Size = new System.Drawing.Size(100, 23);
            this.memoryProgressBar.TabIndex = 4;
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(248, 82);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(123, 18);
            this.memoryLabel.TabIndex = 5;
            this.memoryLabel.Text = "\"Memory: 0%\"";
            this.memoryLabel.Click += new System.EventHandler(this.label3_Click);
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
            // diskProgressBar
            // 
            this.diskProgressBar.Location = new System.Drawing.Point(125, 116);
            this.diskProgressBar.Name = "diskProgressBar";
            this.diskProgressBar.Size = new System.Drawing.Size(100, 23);
            this.diskProgressBar.TabIndex = 7;
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.Location = new System.Drawing.Point(248, 116);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(89, 18);
            this.diskLabel.TabIndex = 8;
            this.diskLabel.Text = "\"Disk: 0%\"";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 618);
            this.Controls.Add(this.processDataGridView);
            this.Controls.Add(this.systemInfoGroupBox);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.systemInfoGroupBox.ResumeLayout(false);
            this.systemInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox systemInfoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar cpuProgressBar;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.DataGridView processDataGridView;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.ProgressBar memoryProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.ProgressBar diskProgressBar;
        private System.Windows.Forms.Label label3;
    }
}