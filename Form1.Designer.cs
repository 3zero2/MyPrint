namespace myPrint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmr_watching = new System.Windows.Forms.Timer(this.components);
            this.strip_status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_watchOnStartup = new System.Windows.Forms.CheckBox();
            this.lbl_watchedFolder = new System.Windows.Forms.Label();
            this.btn_watchedFolder = new System.Windows.Forms.Button();
            this.txt_watchedFolder = new System.Windows.Forms.TextBox();
            this.diag_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.strip_status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_watching
            // 
            this.tmr_watching.Interval = 9000;
            this.tmr_watching.Tick += new System.EventHandler(this.checkFolder);
            // 
            // strip_status
            // 
            this.strip_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.strip_status.Location = new System.Drawing.Point(0, 124);
            this.strip_status.Name = "strip_status";
            this.strip_status.Size = new System.Drawing.Size(426, 22);
            this.strip_status.TabIndex = 0;
            this.strip_status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_watchOnStartup);
            this.groupBox1.Controls.Add(this.lbl_watchedFolder);
            this.groupBox1.Controls.Add(this.btn_watchedFolder);
            this.groupBox1.Controls.Add(this.txt_watchedFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // chk_watchOnStartup
            // 
            this.chk_watchOnStartup.AutoSize = true;
            this.chk_watchOnStartup.Location = new System.Drawing.Point(9, 47);
            this.chk_watchOnStartup.Name = "chk_watchOnStartup";
            this.chk_watchOnStartup.Size = new System.Drawing.Size(196, 17);
            this.chk_watchOnStartup.TabIndex = 4;
            this.chk_watchOnStartup.Text = "Start watching automatically on load";
            this.chk_watchOnStartup.UseVisualStyleBackColor = true;
            this.chk_watchOnStartup.CheckedChanged += new System.EventHandler(this.chk_watchOnStartup_CheckedChanged);
            // 
            // lbl_watchedFolder
            // 
            this.lbl_watchedFolder.AutoSize = true;
            this.lbl_watchedFolder.Location = new System.Drawing.Point(6, 24);
            this.lbl_watchedFolder.Name = "lbl_watchedFolder";
            this.lbl_watchedFolder.Size = new System.Drawing.Size(83, 13);
            this.lbl_watchedFolder.TabIndex = 2;
            this.lbl_watchedFolder.Text = "Watched Folder";
            // 
            // btn_watchedFolder
            // 
            this.btn_watchedFolder.Location = new System.Drawing.Point(319, 19);
            this.btn_watchedFolder.Name = "btn_watchedFolder";
            this.btn_watchedFolder.Size = new System.Drawing.Size(74, 23);
            this.btn_watchedFolder.TabIndex = 1;
            this.btn_watchedFolder.Text = "Change";
            this.btn_watchedFolder.UseVisualStyleBackColor = true;
            this.btn_watchedFolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_watchedFolder
            // 
            this.txt_watchedFolder.Location = new System.Drawing.Point(95, 21);
            this.txt_watchedFolder.Name = "txt_watchedFolder";
            this.txt_watchedFolder.ReadOnly = true;
            this.txt_watchedFolder.Size = new System.Drawing.Size(218, 20);
            this.txt_watchedFolder.TabIndex = 0;
            // 
            // diag_folder
            // 
            this.diag_folder.Description = "Select a folder to watch";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(258, 91);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(339, 91);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "myPrint";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 146);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.strip_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "myPrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.strip_status.ResumeLayout(false);
            this.strip_status.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_watching;
        private System.Windows.Forms.StatusStrip strip_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_watchedFolder;
        private System.Windows.Forms.TextBox txt_watchedFolder;
        private System.Windows.Forms.FolderBrowserDialog diag_folder;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label lbl_watchedFolder;
        private System.Windows.Forms.CheckBox chk_watchOnStartup;
        private System.Windows.Forms.NotifyIcon notifyIcon;

        
    }
}

