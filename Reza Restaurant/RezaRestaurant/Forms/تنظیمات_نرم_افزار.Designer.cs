namespace RezaRestaurant
{
    partial class Form_تنظیمات_نرم_افزار
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_تنظیمات_نرم_افزار));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ثبت_رمز_ورود = new System.Windows.Forms.Button();
            this.textBox_رمز_جدید = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_رمز_قدیمی = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelReport = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_چاپگر_سالن = new System.Windows.Forms.ComboBox();
            this.comboBox_چاپگر_آشپزخانه = new System.Windows.Forms.ComboBox();
            this.button_ثبت_چاپگر = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_پشتیبان_گیری = new System.Windows.Forms.Button();
            this.comboBox_پشتیبان_گیری_اتوماتیک = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarBackUp = new System.Windows.Forms.ProgressBar();
            this.button_بازگردانی_دیتا_بیس = new System.Windows.Forms.Button();
            this.button_تهیه_نسخه_پشتیبان = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ثبت_رمز_ورود);
            this.groupBox1.Controls.Add(this.textBox_رمز_جدید);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_رمز_قدیمی);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(766, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "رمز ورود";
            // 
            // button_ثبت_رمز_ورود
            // 
            this.button_ثبت_رمز_ورود.Location = new System.Drawing.Point(329, 85);
            this.button_ثبت_رمز_ورود.Name = "button_ثبت_رمز_ورود";
            this.button_ثبت_رمز_ورود.Size = new System.Drawing.Size(113, 39);
            this.button_ثبت_رمز_ورود.TabIndex = 3;
            this.button_ثبت_رمز_ورود.Text = "ثبت";
            this.button_ثبت_رمز_ورود.UseVisualStyleBackColor = true;
            this.button_ثبت_رمز_ورود.Click += new System.EventHandler(this.button_ثبت_رمز_ورود_Click);
            // 
            // textBox_رمز_جدید
            // 
            this.textBox_رمز_جدید.Location = new System.Drawing.Point(52, 40);
            this.textBox_رمز_جدید.Name = "textBox_رمز_جدید";
            this.textBox_رمز_جدید.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_رمز_جدید.Size = new System.Drawing.Size(191, 27);
            this.textBox_رمز_جدید.TabIndex = 2;
            this.textBox_رمز_جدید.Enter += new System.EventHandler(this.control_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "رمز عبور جدید :";
            // 
            // textBox_رمز_قدیمی
            // 
            this.textBox_رمز_قدیمی.Location = new System.Drawing.Point(396, 40);
            this.textBox_رمز_قدیمی.Name = "textBox_رمز_قدیمی";
            this.textBox_رمز_قدیمی.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_رمز_قدیمی.Size = new System.Drawing.Size(191, 27);
            this.textBox_رمز_قدیمی.TabIndex = 1;
            this.textBox_رمز_قدیمی.Enter += new System.EventHandler(this.control_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور قدیمی :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // labelReport
            // 
            this.labelReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelReport.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelReport.Location = new System.Drawing.Point(12, 643);
            this.labelReport.Name = "labelReport";
            this.labelReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelReport.Size = new System.Drawing.Size(770, 38);
            this.labelReport.TabIndex = 0;
            this.labelReport.Text = "گزارش انجام کار";
            this.labelReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelReport.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_چاپگر_سالن);
            this.groupBox2.Controls.Add(this.comboBox_چاپگر_آشپزخانه);
            this.groupBox2.Controls.Add(this.button_ثبت_چاپگر);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(766, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "چاپگرها";
            // 
            // comboBox_چاپگر_سالن
            // 
            this.comboBox_چاپگر_سالن.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_چاپگر_سالن.FormattingEnabled = true;
            this.comboBox_چاپگر_سالن.Location = new System.Drawing.Point(274, 99);
            this.comboBox_چاپگر_سالن.Name = "comboBox_چاپگر_سالن";
            this.comboBox_چاپگر_سالن.Size = new System.Drawing.Size(313, 27);
            this.comboBox_چاپگر_سالن.TabIndex = 5;
            this.comboBox_چاپگر_سالن.Enter += new System.EventHandler(this.control_Enter);
            // 
            // comboBox_چاپگر_آشپزخانه
            // 
            this.comboBox_چاپگر_آشپزخانه.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_چاپگر_آشپزخانه.FormattingEnabled = true;
            this.comboBox_چاپگر_آشپزخانه.Location = new System.Drawing.Point(274, 46);
            this.comboBox_چاپگر_آشپزخانه.Name = "comboBox_چاپگر_آشپزخانه";
            this.comboBox_چاپگر_آشپزخانه.Size = new System.Drawing.Size(313, 27);
            this.comboBox_چاپگر_آشپزخانه.TabIndex = 4;
            this.comboBox_چاپگر_آشپزخانه.Enter += new System.EventHandler(this.control_Enter);
            // 
            // button_ثبت_چاپگر
            // 
            this.button_ثبت_چاپگر.Location = new System.Drawing.Point(77, 66);
            this.button_ثبت_چاپگر.Name = "button_ثبت_چاپگر";
            this.button_ثبت_چاپگر.Size = new System.Drawing.Size(113, 39);
            this.button_ثبت_چاپگر.TabIndex = 6;
            this.button_ثبت_چاپگر.Text = "ثبت";
            this.button_ثبت_چاپگر.UseVisualStyleBackColor = true;
            this.button_ثبت_چاپگر.Click += new System.EventHandler(this.button_ثبت_چاپگر_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "چاپگر سالن :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "چاپگر آشپزخانه :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_پشتیبان_گیری);
            this.groupBox3.Controls.Add(this.comboBox_پشتیبان_گیری_اتوماتیک);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.progressBarBackUp);
            this.groupBox3.Controls.Add(this.button_بازگردانی_دیتا_بیس);
            this.groupBox3.Controls.Add(this.button_تهیه_نسخه_پشتیبان);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(766, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دیتا بیس";
            // 
            // button_پشتیبان_گیری
            // 
            this.button_پشتیبان_گیری.Location = new System.Drawing.Point(92, 40);
            this.button_پشتیبان_گیری.Name = "button_پشتیبان_گیری";
            this.button_پشتیبان_گیری.Size = new System.Drawing.Size(72, 34);
            this.button_پشتیبان_گیری.TabIndex = 8;
            this.button_پشتیبان_گیری.Text = "ثبت";
            this.button_پشتیبان_گیری.UseVisualStyleBackColor = true;
            this.button_پشتیبان_گیری.Click += new System.EventHandler(this.button_پشتیبان_گیری_Click);
            this.button_پشتیبان_گیری.Enter += new System.EventHandler(this.control_Enter);
            // 
            // comboBox_پشتیبان_گیری_اتوماتیک
            // 
            this.comboBox_پشتیبان_گیری_اتوماتیک.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_پشتیبان_گیری_اتوماتیک.FormattingEnabled = true;
            this.comboBox_پشتیبان_گیری_اتوماتیک.Items.AddRange(new object[] {
            "غیر فعال",
            "هر 12 ساعت",
            "هر 24 ساعت",
            "هر 1 هفته",
            "هر 1 ماه"});
            this.comboBox_پشتیبان_گیری_اتوماتیک.Location = new System.Drawing.Point(219, 45);
            this.comboBox_پشتیبان_گیری_اتوماتیک.Name = "comboBox_پشتیبان_گیری_اتوماتیک";
            this.comboBox_پشتیبان_گیری_اتوماتیک.Size = new System.Drawing.Size(150, 27);
            this.comboBox_پشتیبان_گیری_اتوماتیک.TabIndex = 7;
            this.comboBox_پشتیبان_گیری_اتوماتیک.Enter += new System.EventHandler(this.control_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(298, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "پشتیبان گیری از دیتا بیس به طور اتوماتیک :";
            // 
            // progressBarBackUp
            // 
            this.progressBarBackUp.Location = new System.Drawing.Point(162, 190);
            this.progressBarBackUp.Name = "progressBarBackUp";
            this.progressBarBackUp.Size = new System.Drawing.Size(442, 23);
            this.progressBarBackUp.TabIndex = 0;
            // 
            // button_بازگردانی_دیتا_بیس
            // 
            this.button_بازگردانی_دیتا_بیس.Location = new System.Drawing.Point(162, 103);
            this.button_بازگردانی_دیتا_بیس.Name = "button_بازگردانی_دیتا_بیس";
            this.button_بازگردانی_دیتا_بیس.Size = new System.Drawing.Size(192, 52);
            this.button_بازگردانی_دیتا_بیس.TabIndex = 10;
            this.button_بازگردانی_دیتا_بیس.Text = "بازگردانی نسخه پشتیبان";
            this.button_بازگردانی_دیتا_بیس.UseVisualStyleBackColor = true;
            this.button_بازگردانی_دیتا_بیس.Click += new System.EventHandler(this.button_بازگردانی_دیتا_بیس_Click);
            // 
            // button_تهیه_نسخه_پشتیبان
            // 
            this.button_تهیه_نسخه_پشتیبان.Location = new System.Drawing.Point(412, 103);
            this.button_تهیه_نسخه_پشتیبان.Name = "button_تهیه_نسخه_پشتیبان";
            this.button_تهیه_نسخه_پشتیبان.Size = new System.Drawing.Size(192, 52);
            this.button_تهیه_نسخه_پشتیبان.TabIndex = 9;
            this.button_تهیه_نسخه_پشتیبان.Text = "تهیه نسخه پشتیبان";
            this.button_تهیه_نسخه_پشتیبان.UseVisualStyleBackColor = true;
            this.button_تهیه_نسخه_پشتیبان.Click += new System.EventHandler(this.button_تهیه_نسخه_پشتیبان_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SQL backup files|*.bak";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "SQL backup files|*.bak";
            // 
            // Form_تنظیمات_نرم_افزار
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_تنظیمات_نرم_افزار";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات نرم افزار";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_تنظیمات_نرم_افزار_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_تنظیمات_نرم_افزار_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_رمز_جدید;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_رمز_قدیمی;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ثبت_رمز_ورود;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ثبت_چاپگر;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_چاپگر_آشپزخانه;
        private System.Windows.Forms.ComboBox comboBox_چاپگر_سالن;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_بازگردانی_دیتا_بیس;
        private System.Windows.Forms.Button button_تهیه_نسخه_پشتیبان;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBarBackUp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_پشتیبان_گیری_اتوماتیک;
        private System.Windows.Forms.Button button_پشتیبان_گیری;
    }
}