namespace RezaRestaurant
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
            this.button_صدور_فاکتور = new System.Windows.Forms.Button();
            this.button_گزارش_روزانه = new System.Windows.Forms.Button();
            this.button_جستجو = new System.Windows.Forms.Button();
            this.button_تنظیمات = new System.Windows.Forms.Button();
            this.button_خاموش = new System.Windows.Forms.Button();
            this.label1_ساعت = new System.Windows.Forms.Label();
            this.label1_تاریخ_امروز = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_کدهای_غذا = new System.Windows.Forms.Button();
            this.timerForDate = new System.Windows.Forms.Timer(this.components);
            this.label_وضعیت_ورود = new System.Windows.Forms.Label();
            this.button_لیست_غذاها = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarBackUp = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_صدور_فاکتور
            // 
            this.button_صدور_فاکتور.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_صدور_فاکتور.Location = new System.Drawing.Point(1044, 26);
            this.button_صدور_فاکتور.Name = "button_صدور_فاکتور";
            this.button_صدور_فاکتور.Size = new System.Drawing.Size(170, 71);
            this.button_صدور_فاکتور.TabIndex = 1;
            this.button_صدور_فاکتور.Text = "صدور فاکتور";
            this.button_صدور_فاکتور.UseVisualStyleBackColor = true;
            this.button_صدور_فاکتور.Click += new System.EventHandler(this.button_صدور_فاکتور_Click);
            // 
            // button_گزارش_روزانه
            // 
            this.button_گزارش_روزانه.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_گزارش_روزانه.Location = new System.Drawing.Point(1044, 202);
            this.button_گزارش_روزانه.Name = "button_گزارش_روزانه";
            this.button_گزارش_روزانه.Size = new System.Drawing.Size(170, 71);
            this.button_گزارش_روزانه.TabIndex = 3;
            this.button_گزارش_روزانه.Text = "گزارش روزانه";
            this.button_گزارش_روزانه.UseVisualStyleBackColor = true;
            this.button_گزارش_روزانه.Click += new System.EventHandler(this.button_گزارش_روزانه_Click);
            // 
            // button_جستجو
            // 
            this.button_جستجو.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_جستجو.Location = new System.Drawing.Point(1044, 290);
            this.button_جستجو.Name = "button_جستجو";
            this.button_جستجو.Size = new System.Drawing.Size(170, 71);
            this.button_جستجو.TabIndex = 4;
            this.button_جستجو.Text = "جستجو";
            this.button_جستجو.UseVisualStyleBackColor = true;
            this.button_جستجو.Click += new System.EventHandler(this.button_جستجو_Click);
            // 
            // button_تنظیمات
            // 
            this.button_تنظیمات.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_تنظیمات.Location = new System.Drawing.Point(1044, 466);
            this.button_تنظیمات.Name = "button_تنظیمات";
            this.button_تنظیمات.Size = new System.Drawing.Size(170, 71);
            this.button_تنظیمات.TabIndex = 6;
            this.button_تنظیمات.Text = "تنظیمات نرم افزار";
            this.button_تنظیمات.UseVisualStyleBackColor = true;
            this.button_تنظیمات.Click += new System.EventHandler(this.button_تنظیمات_Click);
            // 
            // button_خاموش
            // 
            this.button_خاموش.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_خاموش.Location = new System.Drawing.Point(1044, 554);
            this.button_خاموش.Name = "button_خاموش";
            this.button_خاموش.Size = new System.Drawing.Size(170, 71);
            this.button_خاموش.TabIndex = 7;
            this.button_خاموش.Text = "خاموش کردن سیستم";
            this.button_خاموش.UseVisualStyleBackColor = true;
            this.button_خاموش.Click += new System.EventHandler(this.button_خاموش_Click);
            // 
            // label1_ساعت
            // 
            this.label1_ساعت.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1_ساعت.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold);
            this.label1_ساعت.Location = new System.Drawing.Point(4, 26);
            this.label1_ساعت.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_ساعت.Name = "label1_ساعت";
            this.label1_ساعت.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1_ساعت.Size = new System.Drawing.Size(207, 42);
            this.label1_ساعت.TabIndex = 0;
            this.label1_ساعت.Text = "--------";
            this.label1_ساعت.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_تاریخ_امروز
            // 
            this.label1_تاریخ_امروز.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1_تاریخ_امروز.AutoSize = true;
            this.label1_تاریخ_امروز.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1_تاریخ_امروز.Location = new System.Drawing.Point(435, 26);
            this.label1_تاریخ_امروز.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_تاریخ_امروز.Name = "label1_تاریخ_امروز";
            this.label1_تاریخ_امروز.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1_تاریخ_امروز.Size = new System.Drawing.Size(154, 42);
            this.label1_تاریخ_امروز.TabIndex = 0;
            this.label1_تاریخ_امروز.Text = "--------";
            this.label1_تاریخ_امروز.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ساعت :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.82609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1_ساعت, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1_تاریخ_امروز, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(251, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 95);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاریخ امروز :";
            // 
            // button_کدهای_غذا
            // 
            this.button_کدهای_غذا.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_کدهای_غذا.Location = new System.Drawing.Point(1044, 378);
            this.button_کدهای_غذا.Name = "button_کدهای_غذا";
            this.button_کدهای_غذا.Size = new System.Drawing.Size(170, 71);
            this.button_کدهای_غذا.TabIndex = 5;
            this.button_کدهای_غذا.Text = "وارد کردن لیست غذا";
            this.button_کدهای_غذا.UseVisualStyleBackColor = true;
            this.button_کدهای_غذا.Click += new System.EventHandler(this.button_کدهای_غذا_Click);
            // 
            // timerForDate
            // 
            this.timerForDate.Interval = 1000;
            this.timerForDate.Tick += new System.EventHandler(this.timerForDate_Tick);
            // 
            // label_وضعیت_ورود
            // 
            this.label_وضعیت_ورود.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_وضعیت_ورود.AutoSize = true;
            this.label_وضعیت_ورود.BackColor = System.Drawing.Color.Transparent;
            this.label_وضعیت_ورود.Location = new System.Drawing.Point(575, 796);
            this.label_وضعیت_ورود.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_وضعیت_ورود.Name = "label_وضعیت_ورود";
            this.label_وضعیت_ورود.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_وضعیت_ورود.Size = new System.Drawing.Size(76, 19);
            this.label_وضعیت_ورود.TabIndex = 0;
            this.label_وضعیت_ورود.Text = "وارد نشده";
            // 
            // button_لیست_غذاها
            // 
            this.button_لیست_غذاها.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_لیست_غذاها.Location = new System.Drawing.Point(1044, 114);
            this.button_لیست_غذاها.Name = "button_لیست_غذاها";
            this.button_لیست_غذاها.Size = new System.Drawing.Size(170, 71);
            this.button_لیست_غذاها.TabIndex = 2;
            this.button_لیست_غذاها.Text = "لیست غذاها";
            this.button_لیست_غذاها.UseVisualStyleBackColor = true;
            this.button_لیست_غذاها.Click += new System.EventHandler(this.button_لیست_غذاها_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(-1, 809);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(120, 16);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version 88.8.8 Beta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::RezaRestaurant.Properties.Resources.flower4;
            this.pictureBox1.Location = new System.Drawing.Point(2, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarBackUp
            // 
            this.progressBarBackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarBackUp.Location = new System.Drawing.Point(411, 401);
            this.progressBarBackUp.Name = "progressBarBackUp";
            this.progressBarBackUp.Size = new System.Drawing.Size(405, 23);
            this.progressBarBackUp.TabIndex = 0;
            this.progressBarBackUp.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1226, 824);
            this.Controls.Add(this.progressBarBackUp);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.button_لیست_غذاها);
            this.Controls.Add(this.label_وضعیت_ورود);
            this.Controls.Add(this.button_کدهای_غذا);
            this.Controls.Add(this.button_خاموش);
            this.Controls.Add(this.button_تنظیمات);
            this.Controls.Add(this.button_جستجو);
            this.Controls.Add(this.button_گزارش_روزانه);
            this.Controls.Add(this.button_صدور_فاکتور);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reza Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_صدور_فاکتور;
        private System.Windows.Forms.Button button_گزارش_روزانه;
        private System.Windows.Forms.Button button_جستجو;
        private System.Windows.Forms.Button button_تنظیمات;
        private System.Windows.Forms.Button button_خاموش;
        private System.Windows.Forms.Label label1_ساعت;
        private System.Windows.Forms.Label label1_تاریخ_امروز;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_کدهای_غذا;
        private System.Windows.Forms.Timer timerForDate;
        private System.Windows.Forms.Label label_وضعیت_ورود;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_لیست_غذاها;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarBackUp;

    }
}

