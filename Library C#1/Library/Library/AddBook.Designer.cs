namespace Library
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTarikheNashrAddBook_masked = new System.Windows.Forms.MaskedTextBox();
            this.txtISBNAddBook = new System.Windows.Forms.TextBox();
            this.txtDescripeAddBook = new System.Windows.Forms.TextBox();
            this.txtAbstractAddBook = new System.Windows.Forms.TextBox();
            this.txtMahaleketab = new System.Windows.Forms.TextBox();
            this.txtNobateChapAddBook = new System.Windows.Forms.TextBox();
            this.txtTedadAddBook = new System.Windows.Forms.TextBox();
            this.txtSubjectAddBook = new System.Windows.Forms.TextBox();
            this.txtEntesharatAddBook = new System.Windows.Forms.TextBox();
            this.txtMotarjemAddBook = new System.Windows.Forms.TextBox();
            this.txtauthorAddBook = new System.Windows.Forms.TextBox();
            this.txtNameBookAddBook = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 866);
            this.panel1.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(597, 769);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 27);
            this.button8.TabIndex = 9;
            this.button8.Text = "از دور خارج کردن";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(725, 769);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "جستجو";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(853, 769);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "ویرایش اطلاعات";
            this.toolTip1.SetToolTip(this.button6, "اگر در وارد کردن اطلاعات اشتباهی رخ داده میتوانید تصحیح کنید");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(981, 769);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 27);
            this.button5.TabIndex = 6;
            this.button5.Text = "حذف اطلاعات";
            this.toolTip1.SetToolTip(this.button5, "اگر در اطلاعات وارد شده شک دارید میتوانید از این دکمه برای پاک کردن اطلاعات استفا" +
                    "ده کنید");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1109, 769);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "ثبت";
            this.toolTip1.SetToolTip(this.button4, "با زدن این دکمه تمامی اطلاعات در دیتابیس ذخیره و در صورت امکان بازیابی میشود");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1237, 769);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "انصراف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtImagePath);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(540, 486);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بخش ثبت عکس";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(62, 384);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(404, 20);
            this.txtImagePath.TabIndex = 3;
            this.txtImagePath.Text = "××آدرس عکس: ××";
            this.txtImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(288, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "برچیدن عکس";
            this.toolTip1.SetToolTip(this.button2, "اگر عکس وارد شده اشتباه است میتوانید حذف کنید و از دوباره انتخاب کنید");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(416, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "انتخاب عکس";
            this.toolTip1.SetToolTip(this.button1, "روی دکمه کلید کنید و عکس خود را انتخاب کنید");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txtTarikheNashrAddBook_masked);
            this.groupBox1.Controls.Add(this.txtISBNAddBook);
            this.groupBox1.Controls.Add(this.txtDescripeAddBook);
            this.groupBox1.Controls.Add(this.txtAbstractAddBook);
            this.groupBox1.Controls.Add(this.txtMahaleketab);
            this.groupBox1.Controls.Add(this.txtNobateChapAddBook);
            this.groupBox1.Controls.Add(this.txtTedadAddBook);
            this.groupBox1.Controls.Add(this.txtSubjectAddBook);
            this.groupBox1.Controls.Add(this.txtEntesharatAddBook);
            this.groupBox1.Controls.Add(this.txtMotarjemAddBook);
            this.groupBox1.Controls.Add(this.txtauthorAddBook);
            this.groupBox1.Controls.Add(this.txtNameBookAddBook);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(558, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(862, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بخش جزئیات کتاب";
            // 
            // txtTarikheNashrAddBook_masked
            // 
            this.txtTarikheNashrAddBook_masked.Location = new System.Drawing.Point(16, 345);
            this.txtTarikheNashrAddBook_masked.Mask = "00/00/00";
            this.txtTarikheNashrAddBook_masked.Name = "txtTarikheNashrAddBook_masked";
            this.txtTarikheNashrAddBook_masked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTarikheNashrAddBook_masked.Size = new System.Drawing.Size(193, 20);
            this.txtTarikheNashrAddBook_masked.TabIndex = 11;
            // 
            // txtISBNAddBook
            // 
            this.txtISBNAddBook.Location = new System.Drawing.Point(16, 255);
            this.txtISBNAddBook.Name = "txtISBNAddBook";
            this.txtISBNAddBook.Size = new System.Drawing.Size(193, 20);
            this.txtISBNAddBook.TabIndex = 10;
            // 
            // txtDescripeAddBook
            // 
            this.txtDescripeAddBook.Location = new System.Drawing.Point(20, 47);
            this.txtDescripeAddBook.Multiline = true;
            this.txtDescripeAddBook.Name = "txtDescripeAddBook";
            this.txtDescripeAddBook.Size = new System.Drawing.Size(189, 65);
            this.txtDescripeAddBook.TabIndex = 9;
            // 
            // txtAbstractAddBook
            // 
            this.txtAbstractAddBook.Location = new System.Drawing.Point(373, 275);
            this.txtAbstractAddBook.Multiline = true;
            this.txtAbstractAddBook.Name = "txtAbstractAddBook";
            this.txtAbstractAddBook.Size = new System.Drawing.Size(364, 135);
            this.txtAbstractAddBook.TabIndex = 8;
            // 
            // txtMahaleketab
            // 
            this.txtMahaleketab.Location = new System.Drawing.Point(219, 165);
            this.txtMahaleketab.Name = "txtMahaleketab";
            this.txtMahaleketab.Size = new System.Drawing.Size(179, 20);
            this.txtMahaleketab.TabIndex = 7;
            // 
            // txtNobateChapAddBook
            // 
            this.txtNobateChapAddBook.Location = new System.Drawing.Point(276, 114);
            this.txtNobateChapAddBook.Name = "txtNobateChapAddBook";
            this.txtNobateChapAddBook.Size = new System.Drawing.Size(122, 20);
            this.txtNobateChapAddBook.TabIndex = 6;
            // 
            // txtTedadAddBook
            // 
            this.txtTedadAddBook.Location = new System.Drawing.Point(306, 68);
            this.txtTedadAddBook.Name = "txtTedadAddBook";
            this.txtTedadAddBook.Size = new System.Drawing.Size(92, 20);
            this.txtTedadAddBook.TabIndex = 5;
            // 
            // txtSubjectAddBook
            // 
            this.txtSubjectAddBook.Location = new System.Drawing.Point(246, 20);
            this.txtSubjectAddBook.Name = "txtSubjectAddBook";
            this.txtSubjectAddBook.Size = new System.Drawing.Size(152, 20);
            this.txtSubjectAddBook.TabIndex = 4;
            // 
            // txtEntesharatAddBook
            // 
            this.txtEntesharatAddBook.Location = new System.Drawing.Point(566, 171);
            this.txtEntesharatAddBook.Name = "txtEntesharatAddBook";
            this.txtEntesharatAddBook.Size = new System.Drawing.Size(207, 20);
            this.txtEntesharatAddBook.TabIndex = 3;
            // 
            // txtMotarjemAddBook
            // 
            this.txtMotarjemAddBook.Location = new System.Drawing.Point(566, 121);
            this.txtMotarjemAddBook.Name = "txtMotarjemAddBook";
            this.txtMotarjemAddBook.Size = new System.Drawing.Size(207, 20);
            this.txtMotarjemAddBook.TabIndex = 2;
            // 
            // txtauthorAddBook
            // 
            this.txtauthorAddBook.Location = new System.Drawing.Point(566, 71);
            this.txtauthorAddBook.Name = "txtauthorAddBook";
            this.txtauthorAddBook.Size = new System.Drawing.Size(207, 20);
            this.txtauthorAddBook.TabIndex = 1;
            // 
            // txtNameBookAddBook
            // 
            this.txtNameBookAddBook.Location = new System.Drawing.Point(566, 24);
            this.txtNameBookAddBook.Name = "txtNameBookAddBook";
            this.txtNameBookAddBook.Size = new System.Drawing.Size(207, 20);
            this.txtNameBookAddBook.TabIndex = 0;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 866);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTarikheNashrAddBook_masked;
        private System.Windows.Forms.TextBox txtISBNAddBook;
        private System.Windows.Forms.TextBox txtDescripeAddBook;
        private System.Windows.Forms.TextBox txtAbstractAddBook;
        private System.Windows.Forms.TextBox txtMahaleketab;
        private System.Windows.Forms.TextBox txtNobateChapAddBook;
        private System.Windows.Forms.TextBox txtTedadAddBook;
        private System.Windows.Forms.TextBox txtSubjectAddBook;
        private System.Windows.Forms.TextBox txtEntesharatAddBook;
        private System.Windows.Forms.TextBox txtMotarjemAddBook;
        private System.Windows.Forms.TextBox txtauthorAddBook;
        private System.Windows.Forms.TextBox txtNameBookAddBook;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;

    }
}