namespace MRZPersianCalendar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MonthYearLable = new System.Windows.Forms.Label();
            this.DayLable = new System.Windows.Forms.Label();
            this.DayNameLable = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonthYearLable
            // 
            this.MonthYearLable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MonthYearLable.ForeColor = System.Drawing.Color.White;
            this.MonthYearLable.Location = new System.Drawing.Point(11, 1);
            this.MonthYearLable.Name = "MonthYearLable";
            this.MonthYearLable.Size = new System.Drawing.Size(110, 20);
            this.MonthYearLable.TabIndex = 0;
            this.MonthYearLable.Text = "اسفند 1387";
            this.MonthYearLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonthYearLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_EventHandler);
            this.MonthYearLable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_EventHandler);
            this.MonthYearLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_EventHandler);
            this.MonthYearLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_EventHandler);
            // 
            // DayLable
            // 
            this.DayLable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DayLable.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DayLable.ForeColor = System.Drawing.Color.White;
            this.DayLable.Location = new System.Drawing.Point(10, 1);
            this.DayLable.Name = "DayLable";
            this.DayLable.Size = new System.Drawing.Size(110, 100);
            this.DayLable.TabIndex = 1;
            this.DayLable.Text = "17";
            this.DayLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DayLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_EventHandler);
            this.DayLable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_EventHandler);
            this.DayLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_EventHandler);
            this.DayLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_EventHandler);
            // 
            // DayNameLable
            // 
            this.DayNameLable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DayNameLable.ForeColor = System.Drawing.Color.White;
            this.DayNameLable.Location = new System.Drawing.Point(10, 81);
            this.DayNameLable.Name = "DayNameLable";
            this.DayNameLable.Size = new System.Drawing.Size(110, 20);
            this.DayNameLable.TabIndex = 2;
            this.DayNameLable.Text = "label3";
            this.DayNameLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DayNameLable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_EventHandler);
            this.DayNameLable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_EventHandlerDayNameLable_MouseDoubleClick);
            this.DayNameLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_EventHandler);
            this.DayNameLable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_EventHandler);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MRZ Persian Calendar";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showHideToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 76);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.showHideToolStripMenuItem.Text = "Hide";
            this.showHideToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_EventHandler);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(130, 100);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.ControlBox = false;
            this.Controls.Add(this.DayNameLable);
            this.Controls.Add(this.MonthYearLable);
            this.Controls.Add(this.DayLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.75;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MRZ Persian Calendar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_EventHandler);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MonthYearLable;
        private System.Windows.Forms.Label DayLable;
        private System.Windows.Forms.Label DayNameLable;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

