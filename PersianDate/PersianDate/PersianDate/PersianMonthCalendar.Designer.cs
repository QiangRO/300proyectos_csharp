namespace FreeControls
{
    partial class PersianMonthCalendar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.month1Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month2Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month3Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month4Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month5Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month6Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month7Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month8Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month9Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month10Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month11Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.month12Mitem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevMonthButton = new System.Windows.Forms.PictureBox();
            this.nextMonthButton = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.PictureBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.lblSeprator = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.gotoTodayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gotoTodayMitem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.monthMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prevMonthButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMonthButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.gotoTodayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearNumericUpDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.yearNumericUpDown.ForeColor = System.Drawing.Color.Black;
            this.yearNumericUpDown.Location = new System.Drawing.Point(129, 4);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1290,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(64, 23);
            this.yearNumericUpDown.TabIndex = 2;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1386,
            0,
            0,
            0});
            this.yearNumericUpDown.Visible = false;
            this.yearNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.yearNumericUpDown_Validating);
            // 
            // monthMenuStrip
            // 
            this.monthMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.month1Mitem,
            this.month2Mitem,
            this.month3Mitem,
            this.month4Mitem,
            this.month5Mitem,
            this.month6Mitem,
            this.month7Mitem,
            this.month8Mitem,
            this.month9Mitem,
            this.month10Mitem,
            this.month11Mitem,
            this.month12Mitem});
            this.monthMenuStrip.Name = "monthMenuStrip";
            this.monthMenuStrip.Size = new System.Drawing.Size(122, 268);
            // 
            // month1Mitem
            // 
            this.month1Mitem.Name = "month1Mitem";
            this.month1Mitem.Size = new System.Drawing.Size(121, 22);
            this.month1Mitem.Tag = "1";
            this.month1Mitem.Text = "فروردین";
            this.month1Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month2Mitem
            // 
            this.month2Mitem.Name = "month2Mitem";
            this.month2Mitem.Size = new System.Drawing.Size(121, 22);
            this.month2Mitem.Tag = "2";
            this.month2Mitem.Text = "اردیبهشت";
            this.month2Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month3Mitem
            // 
            this.month3Mitem.Name = "month3Mitem";
            this.month3Mitem.Size = new System.Drawing.Size(121, 22);
            this.month3Mitem.Tag = "3";
            this.month3Mitem.Text = "خرداد";
            this.month3Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month4Mitem
            // 
            this.month4Mitem.Name = "month4Mitem";
            this.month4Mitem.Size = new System.Drawing.Size(121, 22);
            this.month4Mitem.Tag = "4";
            this.month4Mitem.Text = "تیر";
            this.month4Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month5Mitem
            // 
            this.month5Mitem.Name = "month5Mitem";
            this.month5Mitem.Size = new System.Drawing.Size(121, 22);
            this.month5Mitem.Tag = "5";
            this.month5Mitem.Text = "مرداد";
            this.month5Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month6Mitem
            // 
            this.month6Mitem.Name = "month6Mitem";
            this.month6Mitem.Size = new System.Drawing.Size(121, 22);
            this.month6Mitem.Tag = "6";
            this.month6Mitem.Text = "شهریور";
            this.month6Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month7Mitem
            // 
            this.month7Mitem.Name = "month7Mitem";
            this.month7Mitem.Size = new System.Drawing.Size(121, 22);
            this.month7Mitem.Tag = "7";
            this.month7Mitem.Text = "مهر";
            this.month7Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month8Mitem
            // 
            this.month8Mitem.Name = "month8Mitem";
            this.month8Mitem.Size = new System.Drawing.Size(121, 22);
            this.month8Mitem.Tag = "8";
            this.month8Mitem.Text = "آبان";
            this.month8Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month9Mitem
            // 
            this.month9Mitem.Name = "month9Mitem";
            this.month9Mitem.Size = new System.Drawing.Size(121, 22);
            this.month9Mitem.Tag = "9";
            this.month9Mitem.Text = "آذر";
            this.month9Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month10Mitem
            // 
            this.month10Mitem.Name = "month10Mitem";
            this.month10Mitem.Size = new System.Drawing.Size(121, 22);
            this.month10Mitem.Tag = "10";
            this.month10Mitem.Text = "دی";
            this.month10Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month11Mitem
            // 
            this.month11Mitem.Name = "month11Mitem";
            this.month11Mitem.Size = new System.Drawing.Size(121, 22);
            this.month11Mitem.Tag = "11";
            this.month11Mitem.Text = "بهمن";
            this.month11Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // month12Mitem
            // 
            this.month12Mitem.Name = "month12Mitem";
            this.month12Mitem.Size = new System.Drawing.Size(121, 22);
            this.month12Mitem.Tag = "12";
            this.month12Mitem.Text = "اسفند";
            this.month12Mitem.Click += new System.EventHandler(this.monthMitem_Click);
            // 
            // prevMonthButton
            // 
            this.prevMonthButton.Image =  global::FreeControls.Resources.left;
            this.prevMonthButton.Location = new System.Drawing.Point(15, 9);
            this.prevMonthButton.Name = "prevMonthButton";
            this.prevMonthButton.Size = new System.Drawing.Size(23, 15);
            this.prevMonthButton.TabIndex = 7;
            this.prevMonthButton.TabStop = false;
            this.prevMonthButton.Click += new System.EventHandler(this.prevMonthButton_Click);
            this.prevMonthButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.prevMonthButton_MouseDown);
            this.prevMonthButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.prevMonthButton_MouseUp);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Image = global::FreeControls.Resources.right;
            this.nextMonthButton.Location = new System.Drawing.Point(284, 9);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(21, 15);
            this.nextMonthButton.TabIndex = 6;
            this.nextMonthButton.TabStop = false;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            this.nextMonthButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nextMonthButton_MouseDown);
            this.nextMonthButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nextMonthButton_MouseUp);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 30);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(325, 142);
            this.bodyPanel.TabIndex = 5;
            this.bodyPanel.TabStop = false;
            this.bodyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bodyPanel_MouseDown);
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.monthLabel);
            this.headerPanel.Controls.Add(this.lblSeprator);
            this.headerPanel.Controls.Add(this.yearLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(325, 30);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.TabStop = false;
            this.headerPanel.Click += new System.EventHandler(this.headerPanel_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.monthLabel.ForeColor = System.Drawing.Color.White;
            this.monthLabel.Location = new System.Drawing.Point(170, 7);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(23, 14);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "08";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // lblSeprator
            // 
            this.lblSeprator.AutoSize = true;
            this.lblSeprator.BackColor = System.Drawing.Color.Transparent;
            this.lblSeprator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSeprator.ForeColor = System.Drawing.Color.White;
            this.lblSeprator.Location = new System.Drawing.Point(161, 6);
            this.lblSeprator.Name = "lblSeprator";
            this.lblSeprator.Size = new System.Drawing.Size(13, 16);
            this.lblSeprator.TabIndex = 5;
            this.lblSeprator.Text = "/";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(127, 7);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(39, 14);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "1386";
            this.yearLabel.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // gotoTodayMenuStrip
            // 
            this.gotoTodayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gotoTodayMitem});
            this.gotoTodayMenuStrip.Name = "monthMenuStrip";
            this.gotoTodayMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.gotoTodayMenuStrip.Size = new System.Drawing.Size(126, 26);
            // 
            // gotoTodayMitem
            // 
            this.gotoTodayMitem.Name = "gotoTodayMitem";
            this.gotoTodayMitem.Size = new System.Drawing.Size(125, 22);
            this.gotoTodayMitem.Tag = "12";
            this.gotoTodayMitem.Text = "برو به امروز";
            this.gotoTodayMitem.Click += new System.EventHandler(this.gotoTodayMitem_Click);
            // 
            // todayLink
            // 
            this.todayLink.AutoSize = true;
            this.todayLink.CausesValidation = false;
            this.todayLink.Location = new System.Drawing.Point(12, 150);
            this.todayLink.Name = "todayLink";
            this.todayLink.Size = new System.Drawing.Size(0, 13);
            this.todayLink.TabIndex = 8;
            this.todayLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.todayLink_LinkClicked);
            // 
            // PersianMonthCalendar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.todayLink);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.nextMonthButton);
            this.Controls.Add(this.prevMonthButton);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximumSize = new System.Drawing.Size(325, 172);
            this.MinimumSize = new System.Drawing.Size(325, 172);
            this.Size = new System.Drawing.Size(325, 172);
            this.LostFocus += new System.EventHandler(this.PersianMonthCalendar_LostFocus);
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.monthMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prevMonthButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextMonthButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.gotoTodayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headerPanel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label lblSeprator;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.PictureBox bodyPanel;
        private System.Windows.Forms.ContextMenuStrip monthMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem month1Mitem;
        private System.Windows.Forms.ToolStripMenuItem month2Mitem;
        private System.Windows.Forms.ToolStripMenuItem month3Mitem;
        private System.Windows.Forms.ToolStripMenuItem month4Mitem;
        private System.Windows.Forms.ToolStripMenuItem month5Mitem;
        private System.Windows.Forms.ToolStripMenuItem month6Mitem;
        private System.Windows.Forms.ToolStripMenuItem month7Mitem;
        private System.Windows.Forms.ToolStripMenuItem month8Mitem;
        private System.Windows.Forms.ToolStripMenuItem month9Mitem;
        private System.Windows.Forms.ToolStripMenuItem month10Mitem;
        private System.Windows.Forms.ToolStripMenuItem month11Mitem;
        private System.Windows.Forms.ToolStripMenuItem month12Mitem;
        private System.Windows.Forms.PictureBox nextMonthButton;
        private System.Windows.Forms.PictureBox prevMonthButton;
        private System.Windows.Forms.ContextMenuStrip gotoTodayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gotoTodayMitem;
        private System.Windows.Forms.LinkLabel todayLink;
    }
}
