namespace RezaRestaurant
{
    partial class Form_جستجو
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_جستجو));
            this.listView_جستجو = new System.Windows.Forms.ListView();
            this.columnHeader_شماره_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_نوع_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_شماره_میز = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_نام_غذا = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_تعداد = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_مبلغ_فاکتور = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_قیمت_غذا = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_تاریخ = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_شماره_میز = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBox_تعداد = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_از_تاریخ = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_شماره_فاکتور = new System.Windows.Forms.CheckBox();
            this.checkBox_مبلغ_فاکتور = new System.Windows.Forms.CheckBox();
            this.textBox_جستجو = new System.Windows.Forms.TextBox();
            this.checkBox_نام_غذا = new System.Windows.Forms.CheckBox();
            this.button_امروز = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_تا_تاریخ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_جستجو
            // 
            this.listView_جستجو.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_شماره_فاکتور,
            this.columnHeader_نوع_فاکتور,
            this.columnHeader_شماره_میز,
            this.columnHeader_نام_غذا,
            this.columnHeader_تعداد,
            this.columnHeader_مبلغ_فاکتور,
            this.columnHeader_قیمت_غذا,
            this.columnHeader_تاریخ});
            this.listView_جستجو.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_جستجو.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_جستجو.FullRowSelect = true;
            this.listView_جستجو.HideSelection = false;
            this.listView_جستجو.Location = new System.Drawing.Point(0, 227);
            this.listView_جستجو.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listView_جستجو.Name = "listView_جستجو";
            this.listView_جستجو.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_جستجو.RightToLeftLayout = true;
            this.listView_جستجو.Size = new System.Drawing.Size(794, 463);
            this.listView_جستجو.TabIndex = 0;
            this.listView_جستجو.UseCompatibleStateImageBehavior = false;
            this.listView_جستجو.View = System.Windows.Forms.View.Details;
            this.listView_جستجو.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_جستجو_ColumnClick);
            // 
            // columnHeader_شماره_فاکتور
            // 
            this.columnHeader_شماره_فاکتور.Text = "شماره فاکتور";
            this.columnHeader_شماره_فاکتور.Width = 98;
            // 
            // columnHeader_نوع_فاکتور
            // 
            this.columnHeader_نوع_فاکتور.Text = "نوع فاکتور";
            this.columnHeader_نوع_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_نوع_فاکتور.Width = 150;
            // 
            // columnHeader_شماره_میز
            // 
            this.columnHeader_شماره_میز.Text = "شماره میز";
            this.columnHeader_شماره_میز.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_شماره_میز.Width = 100;
            // 
            // columnHeader_نام_غذا
            // 
            this.columnHeader_نام_غذا.Text = "نام غذا";
            this.columnHeader_نام_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_نام_غذا.Width = 250;
            // 
            // columnHeader_تعداد
            // 
            this.columnHeader_تعداد.Text = "تعداد";
            this.columnHeader_تعداد.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_تعداد.Width = 100;
            // 
            // columnHeader_مبلغ_فاکتور
            // 
            this.columnHeader_مبلغ_فاکتور.Text = "مبلغ فاکتور به ریال";
            this.columnHeader_مبلغ_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_مبلغ_فاکتور.Width = 200;
            // 
            // columnHeader_قیمت_غذا
            // 
            this.columnHeader_قیمت_غذا.Text = "قیمت یک واحد";
            this.columnHeader_قیمت_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_قیمت_غذا.Width = 200;
            // 
            // columnHeader_تاریخ
            // 
            this.columnHeader_تاریخ.Text = "تاریخ ثبت فاکتور";
            this.columnHeader_تاریخ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_تاریخ.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_شماره_میز);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.checkBox_تعداد);
            this.groupBox2.Controls.Add(this.maskedTextBox_از_تاریخ);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.checkBox_شماره_فاکتور);
            this.groupBox2.Controls.Add(this.checkBox_مبلغ_فاکتور);
            this.groupBox2.Controls.Add(this.textBox_جستجو);
            this.groupBox2.Controls.Add(this.checkBox_نام_غذا);
            this.groupBox2.Controls.Add(this.button_امروز);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskedTextBox_تا_تاریخ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(770, 208);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو بر اساس";
            // 
            // checkBox_شماره_میز
            // 
            this.checkBox_شماره_میز.AutoSize = true;
            this.checkBox_شماره_میز.Checked = true;
            this.checkBox_شماره_میز.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_شماره_میز.Location = new System.Drawing.Point(445, 26);
            this.checkBox_شماره_میز.Name = "checkBox_شماره_میز";
            this.checkBox_شماره_میز.Size = new System.Drawing.Size(99, 23);
            this.checkBox_شماره_میز.TabIndex = 6;
            this.checkBox_شماره_میز.Text = "شماره میز";
            this.checkBox_شماره_میز.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(329, 166);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 30);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "جستجو";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBox_تعداد
            // 
            this.checkBox_تعداد.AutoSize = true;
            this.checkBox_تعداد.Checked = true;
            this.checkBox_تعداد.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_تعداد.Location = new System.Drawing.Point(73, 26);
            this.checkBox_تعداد.Name = "checkBox_تعداد";
            this.checkBox_تعداد.Size = new System.Drawing.Size(87, 23);
            this.checkBox_تعداد.TabIndex = 0;
            this.checkBox_تعداد.Text = "تعداد غذا";
            this.checkBox_تعداد.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_از_تاریخ
            // 
            this.maskedTextBox_از_تاریخ.Location = new System.Drawing.Point(432, 79);
            this.maskedTextBox_از_تاریخ.Mask = "0000 / 00 / 00";
            this.maskedTextBox_از_تاریخ.Name = "maskedTextBox_از_تاریخ";
            this.maskedTextBox_از_تاریخ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_از_تاریخ.Size = new System.Drawing.Size(143, 27);
            this.maskedTextBox_از_تاریخ.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBox_شماره_فاکتور
            // 
            this.checkBox_شماره_فاکتور.AutoSize = true;
            this.checkBox_شماره_فاکتور.Checked = true;
            this.checkBox_شماره_فاکتور.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_شماره_فاکتور.Location = new System.Drawing.Point(581, 26);
            this.checkBox_شماره_فاکتور.Name = "checkBox_شماره_فاکتور";
            this.checkBox_شماره_فاکتور.Size = new System.Drawing.Size(117, 23);
            this.checkBox_شماره_فاکتور.TabIndex = 0;
            this.checkBox_شماره_فاکتور.Text = "شماره فاکتور";
            this.checkBox_شماره_فاکتور.UseVisualStyleBackColor = true;
            // 
            // checkBox_مبلغ_فاکتور
            // 
            this.checkBox_مبلغ_فاکتور.AutoSize = true;
            this.checkBox_مبلغ_فاکتور.Checked = true;
            this.checkBox_مبلغ_فاکتور.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_مبلغ_فاکتور.Location = new System.Drawing.Point(307, 26);
            this.checkBox_مبلغ_فاکتور.Name = "checkBox_مبلغ_فاکتور";
            this.checkBox_مبلغ_فاکتور.Size = new System.Drawing.Size(101, 23);
            this.checkBox_مبلغ_فاکتور.TabIndex = 0;
            this.checkBox_مبلغ_فاکتور.Text = "مبلغ فاکتور";
            this.checkBox_مبلغ_فاکتور.UseVisualStyleBackColor = true;
            // 
            // textBox_جستجو
            // 
            this.textBox_جستجو.Location = new System.Drawing.Point(184, 128);
            this.textBox_جستجو.Name = "textBox_جستجو";
            this.textBox_جستجو.Size = new System.Drawing.Size(324, 27);
            this.textBox_جستجو.TabIndex = 4;
            this.textBox_جستجو.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_جستجو_KeyDown);
            // 
            // checkBox_نام_غذا
            // 
            this.checkBox_نام_غذا.AutoSize = true;
            this.checkBox_نام_غذا.Checked = true;
            this.checkBox_نام_غذا.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_نام_غذا.Location = new System.Drawing.Point(197, 26);
            this.checkBox_نام_غذا.Name = "checkBox_نام_غذا";
            this.checkBox_نام_غذا.Size = new System.Drawing.Size(73, 23);
            this.checkBox_نام_غذا.TabIndex = 0;
            this.checkBox_نام_غذا.Text = "نام غذا";
            this.checkBox_نام_غذا.UseVisualStyleBackColor = true;
            // 
            // button_امروز
            // 
            this.button_امروز.Location = new System.Drawing.Point(125, 76);
            this.button_امروز.Name = "button_امروز";
            this.button_امروز.Size = new System.Drawing.Size(72, 30);
            this.button_امروز.TabIndex = 3;
            this.button_امروز.Text = "امروز";
            this.button_امروز.UseVisualStyleBackColor = true;
            this.button_امروز.Click += new System.EventHandler(this.button_امروز_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 131);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "جستجو :";
            // 
            // maskedTextBox_تا_تاریخ
            // 
            this.maskedTextBox_تا_تاریخ.Location = new System.Drawing.Point(203, 79);
            this.maskedTextBox_تا_تاریخ.Mask = "0000 / 00 / 00";
            this.maskedTextBox_تا_تاریخ.Name = "maskedTextBox_تا_تاریخ";
            this.maskedTextBox_تا_تاریخ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_تا_تاریخ.Size = new System.Drawing.Size(143, 27);
            this.maskedTextBox_تا_تاریخ.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 82);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "از تاریخ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 82);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "تا تاریخ :";
            // 
            // Form_جستجو
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView_جستجو);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_جستجو";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو";
            this.Shown += new System.EventHandler(this.Form_جستجو_Shown);
            this.Activated += new System.EventHandler(this.Form_جستجو_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_جستجو_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_جستجو_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_جستجو;
        private System.Windows.Forms.ColumnHeader columnHeader_شماره_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_نام_غذا;
        private System.Windows.Forms.ColumnHeader columnHeader_تعداد;
        private System.Windows.Forms.ColumnHeader columnHeader_مبلغ_فاکتور;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_امروز;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_تا_تاریخ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_جستجو;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_نام_غذا;
        private System.Windows.Forms.CheckBox checkBox_مبلغ_فاکتور;
        private System.Windows.Forms.CheckBox checkBox_شماره_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_تاریخ;
        private System.Windows.Forms.CheckBox checkBox_تعداد;
        private System.Windows.Forms.ColumnHeader columnHeader_قیمت_غذا;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_از_تاریخ;
        private System.Windows.Forms.ColumnHeader columnHeader_شماره_میز;
        private System.Windows.Forms.CheckBox checkBox_شماره_میز;
        private System.Windows.Forms.ColumnHeader columnHeader_نوع_فاکتور;
    }
}