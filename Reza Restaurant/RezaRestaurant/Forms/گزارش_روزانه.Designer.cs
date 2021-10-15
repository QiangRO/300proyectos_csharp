namespace RezaRestaurant
{
    partial class Form_گزارش_روزانه
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_گزارش_روزانه));
            this.button_فاکتورهای_صادر_شده = new System.Windows.Forms.Button();
            this.button_اقلام_مصرف_شده = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_تاریخ = new System.Windows.Forms.MaskedTextBox();
            this.button_امروز = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_ردیف = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_نوع_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_شماره_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_شماره_میز = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_مبلغ_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_تاریخ = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_جمع_فاکتور = new System.Windows.Forms.Label();
            this.button_چاپ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_فاکتورهای_صادر_شده
            // 
            this.button_فاکتورهای_صادر_شده.Location = new System.Drawing.Point(437, 89);
            this.button_فاکتورهای_صادر_شده.Margin = new System.Windows.Forms.Padding(4);
            this.button_فاکتورهای_صادر_شده.Name = "button_فاکتورهای_صادر_شده";
            this.button_فاکتورهای_صادر_شده.Size = new System.Drawing.Size(284, 70);
            this.button_فاکتورهای_صادر_شده.TabIndex = 2;
            this.button_فاکتورهای_صادر_شده.Text = "گزارش بر اساس فاکتورهای صادر شده";
            this.button_فاکتورهای_صادر_شده.UseVisualStyleBackColor = true;
            this.button_فاکتورهای_صادر_شده.Click += new System.EventHandler(this.button_فاکتورهای_صادر_شده_Click);
            // 
            // button_اقلام_مصرف_شده
            // 
            this.button_اقلام_مصرف_شده.Location = new System.Drawing.Point(74, 89);
            this.button_اقلام_مصرف_شده.Margin = new System.Windows.Forms.Padding(4);
            this.button_اقلام_مصرف_شده.Name = "button_اقلام_مصرف_شده";
            this.button_اقلام_مصرف_شده.Size = new System.Drawing.Size(284, 70);
            this.button_اقلام_مصرف_شده.TabIndex = 3;
            this.button_اقلام_مصرف_شده.Text = "گزارش بر اساس اقلام مصرف شده";
            this.button_اقلام_مصرف_شده.UseVisualStyleBackColor = true;
            this.button_اقلام_مصرف_شده.Click += new System.EventHandler(this.button_اقلام_مصرف_شده_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "تهیه گزارش برای روز   »";
            // 
            // maskedTextBox_تاریخ
            // 
            this.maskedTextBox_تاریخ.Location = new System.Drawing.Point(297, 35);
            this.maskedTextBox_تاریخ.Mask = "0000 / 00 / 00";
            this.maskedTextBox_تاریخ.Name = "maskedTextBox_تاریخ";
            this.maskedTextBox_تاریخ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_تاریخ.Size = new System.Drawing.Size(117, 27);
            this.maskedTextBox_تاریخ.TabIndex = 1;
            // 
            // button_امروز
            // 
            this.button_امروز.Location = new System.Drawing.Point(198, 32);
            this.button_امروز.Name = "button_امروز";
            this.button_امروز.Size = new System.Drawing.Size(72, 30);
            this.button_امروز.TabIndex = 1;
            this.button_امروز.Text = "امروز";
            this.button_امروز.UseVisualStyleBackColor = true;
            this.button_امروز.Click += new System.EventHandler(this.button_امروز_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ردیف,
            this.columnHeader_نوع_فاکتور,
            this.columnHeader_شماره_فاکتور,
            this.columnHeader_شماره_میز,
            this.columnHeader_مبلغ_فاکتور,
            this.columnHeader_تاریخ});
            this.listView1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 237);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(794, 379);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader_ردیف
            // 
            this.columnHeader_ردیف.Text = "ردیف";
            this.columnHeader_ردیف.Width = 50;
            // 
            // columnHeader_نوع_فاکتور
            // 
            this.columnHeader_نوع_فاکتور.Text = "نوع فاکتور";
            this.columnHeader_نوع_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_نوع_فاکتور.Width = 200;
            // 
            // columnHeader_شماره_فاکتور
            // 
            this.columnHeader_شماره_فاکتور.Text = "شماره فاکتور";
            this.columnHeader_شماره_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_شماره_فاکتور.Width = 100;
            // 
            // columnHeader_شماره_میز
            // 
            this.columnHeader_شماره_میز.Text = "شماره میز";
            this.columnHeader_شماره_میز.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_شماره_میز.Width = 80;
            // 
            // columnHeader_مبلغ_فاکتور
            // 
            this.columnHeader_مبلغ_فاکتور.Text = "مبلغ فاکتور به ریال";
            this.columnHeader_مبلغ_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_مبلغ_فاکتور.Width = 170;
            // 
            // columnHeader_تاریخ
            // 
            this.columnHeader_تاریخ.Text = "تاریخ ثبت فاکتور";
            this.columnHeader_تاریخ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_تاریخ.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 641);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ریال";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 641);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "جمع کل :";
            // 
            // label_جمع_فاکتور
            // 
            this.label_جمع_فاکتور.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_جمع_فاکتور.AutoSize = true;
            this.label_جمع_فاکتور.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_جمع_فاکتور.Location = new System.Drawing.Point(296, 634);
            this.label_جمع_فاکتور.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_جمع_فاکتور.Name = "label_جمع_فاکتور";
            this.label_جمع_فاکتور.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_جمع_فاکتور.Size = new System.Drawing.Size(122, 33);
            this.label_جمع_فاکتور.TabIndex = 0;
            this.label_جمع_فاکتور.Text = "مجموع قیمت ها";
            this.label_جمع_فاکتور.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_چاپ
            // 
            this.button_چاپ.Location = new System.Drawing.Point(332, 174);
            this.button_چاپ.Margin = new System.Windows.Forms.Padding(4);
            this.button_چاپ.Name = "button_چاپ";
            this.button_چاپ.Size = new System.Drawing.Size(130, 46);
            this.button_چاپ.TabIndex = 4;
            this.button_چاپ.Text = "چاپ";
            this.button_چاپ.UseVisualStyleBackColor = true;
            this.button_چاپ.Click += new System.EventHandler(this.button_چاپ_Click);
            // 
            // Form_گزارش_روزانه
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.button_چاپ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_جمع_فاکتور);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_امروز);
            this.Controls.Add(this.maskedTextBox_تاریخ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_اقلام_مصرف_شده);
            this.Controls.Add(this.button_فاکتورهای_صادر_شده);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_گزارش_روزانه";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش  روزانه";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_گزارش_روزانه_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_گزارش_روزانه_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_فاکتورهای_صادر_شده;
        private System.Windows.Forms.Button button_اقلام_مصرف_شده;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_تاریخ;
        private System.Windows.Forms.Button button_امروز;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_ردیف;
        private System.Windows.Forms.ColumnHeader columnHeader_شماره_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_نوع_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_مبلغ_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_تاریخ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_جمع_فاکتور;
        private System.Windows.Forms.Button button_چاپ;
        private System.Windows.Forms.ColumnHeader columnHeader_شماره_میز;
    }
}