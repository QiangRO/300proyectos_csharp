namespace Gammit
{
    partial class DeviceGammaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceGammaForm));
            this.nudGammaLevel = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseOnTray = new System.Windows.Forms.CheckBox();
            this.ClickOnTray = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ResetOnStart = new System.Windows.Forms.CheckBox();
            this.SilentStart = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudGammaLevel
            // 
            this.nudGammaLevel.DecimalPlaces = 2;
            this.nudGammaLevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudGammaLevel.Location = new System.Drawing.Point(105, 27);
            this.nudGammaLevel.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudGammaLevel.Name = "nudGammaLevel";
            this.nudGammaLevel.Size = new System.Drawing.Size(51, 20);
            this.nudGammaLevel.TabIndex = 0;
            this.nudGammaLevel.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudGammaLevel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gamma Correction";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gamma Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseOnTray
            // 
            this.CloseOnTray.AutoSize = true;
            this.CloseOnTray.Location = new System.Drawing.Point(9, 19);
            this.CloseOnTray.Name = "CloseOnTray";
            this.CloseOnTray.Size = new System.Drawing.Size(91, 17);
            this.CloseOnTray.TabIndex = 2;
            this.CloseOnTray.Text = "Close on Tray";
            this.CloseOnTray.UseVisualStyleBackColor = true;
            // 
            // ClickOnTray
            // 
            this.ClickOnTray.AutoSize = true;
            this.ClickOnTray.Location = new System.Drawing.Point(9, 42);
            this.ClickOnTray.Name = "ClickOnTray";
            this.ClickOnTray.Size = new System.Drawing.Size(158, 17);
            this.ClickOnTray.TabIndex = 3;
            this.ClickOnTray.Text = "Double Click on Tray: Show";
            this.ClickOnTray.UseVisualStyleBackColor = true;
            this.ClickOnTray.CheckedChanged += new System.EventHandler(this.ClickOnTray_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ResetOnStart);
            this.groupBox2.Controls.Add(this.SilentStart);
            this.groupBox2.Controls.Add(this.ClickOnTray);
            this.groupBox2.Controls.Add(this.CloseOnTray);
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // ResetOnStart
            // 
            this.ResetOnStart.AutoSize = true;
            this.ResetOnStart.Location = new System.Drawing.Point(9, 89);
            this.ResetOnStart.Name = "ResetOnStart";
            this.ResetOnStart.Size = new System.Drawing.Size(133, 17);
            this.ResetOnStart.TabIndex = 5;
            this.ResetOnStart.Text = "Reset Gamma on Start";
            this.ResetOnStart.UseVisualStyleBackColor = true;
            // 
            // SilentStart
            // 
            this.SilentStart.AutoSize = true;
            this.SilentStart.Location = new System.Drawing.Point(9, 66);
            this.SilentStart.Name = "SilentStart";
            this.SilentStart.Size = new System.Drawing.Size(129, 17);
            this.SilentStart.TabIndex = 4;
            this.SilentStart.Text = "Silent Start (no dialog)";
            this.SilentStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayMenu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Gammit!";
            this.TrayIcon.Visible = true;
            this.TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuShow,
            this.MenuExit});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // MenuShow
            // 
            this.MenuShow.Name = "MenuShow";
            this.MenuShow.Size = new System.Drawing.Size(100, 22);
            this.MenuShow.Text = "Show";
            this.MenuShow.Click += new System.EventHandler(this.MenuShow_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(100, 22);
            this.MenuExit.Text = "&Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // DeviceGammaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeviceGammaForm";
            this.Text = "Gammit!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceGammaForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.DeviceGammaForm_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceGammaForm_FormClosing);
            this.Load += new System.EventHandler(this.DeviceGammaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGammaLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGammaLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ClickOnTray;
        private System.Windows.Forms.CheckBox CloseOnTray;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ResetOnStart;
        private System.Windows.Forms.CheckBox SilentStart;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuShow;
    }
}

