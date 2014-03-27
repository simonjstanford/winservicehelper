namespace WinServiceHelper
{
    partial class WinServiceHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinServiceHelper));
            this.checkBoxStartService = new System.Windows.Forms.CheckBox();
            this.checkBoxStopService = new System.Windows.Forms.CheckBox();
            this.groupBoxArgusTv = new System.Windows.Forms.GroupBox();
            this.listViewServices = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSelectService = new System.Windows.Forms.Label();
            this.labelTimeLimit = new System.Windows.Forms.Label();
            this.numericUpDownServiceTimeout = new System.Windows.Forms.NumericUpDown();
            this.groupBoxWinApplicatin = new System.Windows.Forms.GroupBox();
            this.buttonSelectApplication = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWinAppPath = new System.Windows.Forms.TextBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownAppLaunchDelay = new System.Windows.Forms.NumericUpDown();
            this.checkBoxExecuteApplication = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxArgusTv.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServiceTimeout)).BeginInit();
            this.groupBoxWinApplicatin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAppLaunchDelay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxStartService
            // 
            this.checkBoxStartService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxStartService.AutoSize = true;
            this.checkBoxStartService.Location = new System.Drawing.Point(6, 417);
            this.checkBoxStartService.Name = "checkBoxStartService";
            this.checkBoxStartService.Size = new System.Drawing.Size(237, 17);
            this.checkBoxStartService.TabIndex = 0;
            this.checkBoxStartService.Text = "Start selected services on application launch";
            this.checkBoxStartService.UseVisualStyleBackColor = true;
            // 
            // checkBoxStopService
            // 
            this.checkBoxStopService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxStopService.AutoSize = true;
            this.checkBoxStopService.Location = new System.Drawing.Point(6, 440);
            this.checkBoxStopService.Name = "checkBoxStopService";
            this.checkBoxStopService.Size = new System.Drawing.Size(230, 17);
            this.checkBoxStopService.TabIndex = 1;
            this.checkBoxStopService.Text = "Stop selected services on application close";
            this.checkBoxStopService.UseVisualStyleBackColor = true;
            // 
            // groupBoxArgusTv
            // 
            this.groupBoxArgusTv.Controls.Add(this.listViewServices);
            this.groupBoxArgusTv.Controls.Add(this.labelSelectService);
            this.groupBoxArgusTv.Controls.Add(this.labelTimeLimit);
            this.groupBoxArgusTv.Controls.Add(this.numericUpDownServiceTimeout);
            this.groupBoxArgusTv.Controls.Add(this.checkBoxStopService);
            this.groupBoxArgusTv.Controls.Add(this.checkBoxStartService);
            this.groupBoxArgusTv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArgusTv.Location = new System.Drawing.Point(3, 3);
            this.groupBoxArgusTv.Name = "groupBoxArgusTv";
            this.groupBoxArgusTv.Size = new System.Drawing.Size(512, 496);
            this.groupBoxArgusTv.TabIndex = 2;
            this.groupBoxArgusTv.TabStop = false;
            this.groupBoxArgusTv.Text = "Windows Service";
            // 
            // listViewServices
            // 
            this.listViewServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewServices.CheckBoxes = true;
            this.listViewServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.status,
            this.description});
            this.listViewServices.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewServices.GridLines = true;
            this.listViewServices.Location = new System.Drawing.Point(8, 40);
            this.listViewServices.Name = "listViewServices";
            this.listViewServices.Size = new System.Drawing.Size(498, 371);
            this.listViewServices.TabIndex = 13;
            this.listViewServices.UseCompatibleStateImageBehavior = false;
            this.listViewServices.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 200;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 55;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 400;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // labelSelectService
            // 
            this.labelSelectService.AutoSize = true;
            this.labelSelectService.Location = new System.Drawing.Point(5, 24);
            this.labelSelectService.Name = "labelSelectService";
            this.labelSelectService.Size = new System.Drawing.Size(191, 13);
            this.labelSelectService.TabIndex = 12;
            this.labelSelectService.Text = "Select Windows Services to start/stop:";
            // 
            // labelTimeLimit
            // 
            this.labelTimeLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimeLimit.AutoSize = true;
            this.labelTimeLimit.Location = new System.Drawing.Point(58, 465);
            this.labelTimeLimit.Name = "labelTimeLimit";
            this.labelTimeLimit.Size = new System.Drawing.Size(119, 13);
            this.labelTimeLimit.TabIndex = 3;
            this.labelTimeLimit.Text = "Seconds before timeout";
            // 
            // numericUpDownServiceTimeout
            // 
            this.numericUpDownServiceTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownServiceTimeout.Location = new System.Drawing.Point(6, 463);
            this.numericUpDownServiceTimeout.Name = "numericUpDownServiceTimeout";
            this.numericUpDownServiceTimeout.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownServiceTimeout.TabIndex = 2;
            // 
            // groupBoxWinApplicatin
            // 
            this.groupBoxWinApplicatin.Controls.Add(this.buttonSelectApplication);
            this.groupBoxWinApplicatin.Controls.Add(this.label3);
            this.groupBoxWinApplicatin.Controls.Add(this.textBoxWinAppPath);
            this.groupBoxWinApplicatin.Controls.Add(this.labelDelay);
            this.groupBoxWinApplicatin.Controls.Add(this.numericUpDownAppLaunchDelay);
            this.groupBoxWinApplicatin.Controls.Add(this.checkBoxExecuteApplication);
            this.groupBoxWinApplicatin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWinApplicatin.Location = new System.Drawing.Point(3, 505);
            this.groupBoxWinApplicatin.Name = "groupBoxWinApplicatin";
            this.groupBoxWinApplicatin.Size = new System.Drawing.Size(512, 129);
            this.groupBoxWinApplicatin.TabIndex = 0;
            this.groupBoxWinApplicatin.TabStop = false;
            this.groupBoxWinApplicatin.Text = "Windows Application";
            // 
            // buttonSelectApplication
            // 
            this.buttonSelectApplication.Location = new System.Drawing.Point(323, 85);
            this.buttonSelectApplication.Name = "buttonSelectApplication";
            this.buttonSelectApplication.Size = new System.Drawing.Size(23, 23);
            this.buttonSelectApplication.TabIndex = 11;
            this.buttonSelectApplication.Text = "...";
            this.buttonSelectApplication.UseVisualStyleBackColor = true;
            this.buttonSelectApplication.Click += new System.EventHandler(this.buttonSelectApplication_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path:";
            // 
            // textBoxWinAppPath
            // 
            this.textBoxWinAppPath.Location = new System.Drawing.Point(6, 87);
            this.textBoxWinAppPath.Name = "textBoxWinAppPath";
            this.textBoxWinAppPath.Size = new System.Drawing.Size(311, 20);
            this.textBoxWinAppPath.TabIndex = 9;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(58, 44);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(124, 13);
            this.labelDelay.TabIndex = 5;
            this.labelDelay.Text = "Seconds to delay launch";
            // 
            // numericUpDownAppLaunchDelay
            // 
            this.numericUpDownAppLaunchDelay.Location = new System.Drawing.Point(6, 42);
            this.numericUpDownAppLaunchDelay.Name = "numericUpDownAppLaunchDelay";
            this.numericUpDownAppLaunchDelay.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownAppLaunchDelay.TabIndex = 4;
            // 
            // checkBoxExecuteApplication
            // 
            this.checkBoxExecuteApplication.AutoSize = true;
            this.checkBoxExecuteApplication.Location = new System.Drawing.Point(6, 19);
            this.checkBoxExecuteApplication.Name = "checkBoxExecuteApplication";
            this.checkBoxExecuteApplication.Size = new System.Drawing.Size(193, 17);
            this.checkBoxExecuteApplication.TabIndex = 0;
            this.checkBoxExecuteApplication.Text = "Start program on application launch";
            this.checkBoxExecuteApplication.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(374, 655);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(455, 655);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Application loaded and minimised to tray";
            this.notifyIcon1.BalloonTipTitle = "Windows Service Helper";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows Service Helper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxArgusTv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxWinApplicatin, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 637);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // WinServiceHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.MinimumSize = new System.Drawing.Size(383, 480);
            this.Name = "WinServiceHelper";
            this.ShowInTaskbar = false;
            this.Text = "Windows Service Helper";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBoxArgusTv.ResumeLayout(false);
            this.groupBoxArgusTv.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServiceTimeout)).EndInit();
            this.groupBoxWinApplicatin.ResumeLayout(false);
            this.groupBoxWinApplicatin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAppLaunchDelay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStartService;
        private System.Windows.Forms.CheckBox checkBoxStopService;
        private System.Windows.Forms.GroupBox groupBoxArgusTv;
        private System.Windows.Forms.Label labelTimeLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownServiceTimeout;
        private System.Windows.Forms.GroupBox groupBoxWinApplicatin;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownAppLaunchDelay;
        private System.Windows.Forms.CheckBox checkBoxExecuteApplication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWinAppPath;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonSelectApplication;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelSelectService;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewServices;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;

    }
}

