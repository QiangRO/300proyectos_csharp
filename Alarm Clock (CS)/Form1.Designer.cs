namespace Alarm_Clock__CS_
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Pic_Clock = new System.Windows.Forms.PictureBox();
            this.CMS1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.قطعصدایزنگToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Music_Path = new System.Windows.Forms.TextBox();
            this.btn_Set_Music = new System.Windows.Forms.Button();
            this.btn_Set_Time = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Second_txt = new System.Windows.Forms.TextBox();
            this.Minute_txt = new System.Windows.Forms.TextBox();
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Clock)).BeginInit();
            this.CMS1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Clock
            // 
            this.Pic_Clock.ContextMenuStrip = this.CMS1;
            this.Pic_Clock.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Clock.Image")));
            this.Pic_Clock.Location = new System.Drawing.Point(209, 3);
            this.Pic_Clock.Name = "Pic_Clock";
            this.Pic_Clock.Size = new System.Drawing.Size(113, 122);
            this.Pic_Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_Clock.TabIndex = 0;
            this.Pic_Clock.TabStop = false;
            // 
            // CMS1
            // 
            this.CMS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.قطعصدایزنگToolStripMenuItem});
            this.CMS1.Name = "CMS1";
            this.CMS1.Size = new System.Drawing.Size(146, 26);
            // 
            // قطعصدایزنگToolStripMenuItem
            // 
            this.قطعصدایزنگToolStripMenuItem.Name = "قطعصدایزنگToolStripMenuItem";
            this.قطعصدایزنگToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.قطعصدایزنگToolStripMenuItem.Text = "قطع صدای زنگ";
            this.قطعصدایزنگToolStripMenuItem.Click += new System.EventHandler(this.قطعصدایزنگToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Music_Path);
            this.groupBox1.Controls.Add(this.btn_Set_Music);
            this.groupBox1.Controls.Add(this.btn_Set_Time);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Second_txt);
            this.groupBox1.Controls.Add(this.Minute_txt);
            this.groupBox1.Controls.Add(this.Hour_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(201, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات : ";
            // 
            // Music_Path
            // 
            this.Music_Path.Location = new System.Drawing.Point(12, 95);
            this.Music_Path.Name = "Music_Path";
            this.Music_Path.ReadOnly = true;
            this.Music_Path.Size = new System.Drawing.Size(183, 21);
            this.Music_Path.TabIndex = 9;
            // 
            // btn_Set_Music
            // 
            this.btn_Set_Music.Location = new System.Drawing.Point(12, 66);
            this.btn_Set_Music.Name = "btn_Set_Music";
            this.btn_Set_Music.Size = new System.Drawing.Size(183, 26);
            this.btn_Set_Music.TabIndex = 8;
            this.btn_Set_Music.Text = "انتخاب زنگ";
            this.btn_Set_Music.UseVisualStyleBackColor = true;
            this.btn_Set_Music.Click += new System.EventHandler(this.btn_Set_Music_Click);
            // 
            // btn_Set_Time
            // 
            this.btn_Set_Time.Location = new System.Drawing.Point(12, 38);
            this.btn_Set_Time.Name = "btn_Set_Time";
            this.btn_Set_Time.Size = new System.Drawing.Size(183, 26);
            this.btn_Set_Time.TabIndex = 7;
            this.btn_Set_Time.Text = "تظیم کردن زمان";
            this.btn_Set_Time.UseVisualStyleBackColor = true;
            this.btn_Set_Time.Click += new System.EventHandler(this.btn_Set_Time_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // Second_txt
            // 
            this.Second_txt.Location = new System.Drawing.Point(88, 14);
            this.Second_txt.MaxLength = 2;
            this.Second_txt.Name = "Second_txt";
            this.Second_txt.Size = new System.Drawing.Size(25, 21);
            this.Second_txt.TabIndex = 4;
            this.Second_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Minute_txt
            // 
            this.Minute_txt.Location = new System.Drawing.Point(50, 14);
            this.Minute_txt.MaxLength = 2;
            this.Minute_txt.Name = "Minute_txt";
            this.Minute_txt.Size = new System.Drawing.Size(25, 21);
            this.Minute_txt.TabIndex = 3;
            this.Minute_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hour_txt
            // 
            this.Hour_txt.Location = new System.Drawing.Point(12, 14);
            this.Hour_txt.MaxLength = 2;
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(25, 21);
            this.Hour_txt.TabIndex = 2;
            this.Hour_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "زمان هشدار :";
            // 
            // Tip1
            // 
            this.Tip1.AutoPopDelay = 5000;
            this.Tip1.InitialDelay = 1;
            this.Tip1.ReshowDelay = 100;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(324, 128);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pic_Clock);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ساعت زنگی";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Clock)).EndInit();
            this.CMS1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Clock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Music_Path;
        private System.Windows.Forms.Button btn_Set_Music;
        private System.Windows.Forms.Button btn_Set_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Second_txt;
        private System.Windows.Forms.TextBox Minute_txt;
        private System.Windows.Forms.TextBox Hour_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Tip1;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip CMS1;
        private System.Windows.Forms.ToolStripMenuItem قطعصدایزنگToolStripMenuItem;

    }
}

