namespace RezaRestaurant
{
    partial class Form_کدهای_غذا
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_کدهای_غذا));
            this.listView_غذاها = new System.Windows.Forms.ListView();
            this.columnHeader_ردیف = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_نام_غذا = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_قیمت = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_کد_غذا = new System.Windows.Forms.ColumnHeader();
            this.maskedTextBox_کد_غذا = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_نام_غذا = new System.Windows.Forms.TextBox();
            this.button_ثبت = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_قیمت = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_غذاها
            // 
            this.listView_غذاها.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ردیف,
            this.columnHeader_نام_غذا,
            this.columnHeader_قیمت,
            this.columnHeader_کد_غذا});
            this.listView_غذاها.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView_غذاها.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_غذاها.FullRowSelect = true;
            this.listView_غذاها.HideSelection = false;
            this.listView_غذاها.Location = new System.Drawing.Point(0, 165);
            this.listView_غذاها.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.listView_غذاها.Name = "listView_غذاها";
            this.listView_غذاها.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_غذاها.RightToLeftLayout = true;
            this.listView_غذاها.Size = new System.Drawing.Size(794, 525);
            this.listView_غذاها.TabIndex = 0;
            this.listView_غذاها.UseCompatibleStateImageBehavior = false;
            this.listView_غذاها.View = System.Windows.Forms.View.Details;
            this.listView_غذاها.SelectedIndexChanged += new System.EventHandler(this.listView_غذاها_SelectedIndexChanged);
            this.listView_غذاها.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_غذاها_ColumnClick);
            this.listView_غذاها.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_غذاها_KeyDown);
            // 
            // columnHeader_ردیف
            // 
            this.columnHeader_ردیف.Text = "ردیف";
            this.columnHeader_ردیف.Width = 90;
            // 
            // columnHeader_نام_غذا
            // 
            this.columnHeader_نام_غذا.Text = "نام غذا";
            this.columnHeader_نام_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_نام_غذا.Width = 300;
            // 
            // columnHeader_قیمت
            // 
            this.columnHeader_قیمت.Text = "قیمت ، ريال";
            this.columnHeader_قیمت.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_قیمت.Width = 200;
            // 
            // columnHeader_کد_غذا
            // 
            this.columnHeader_کد_غذا.Text = "کد غذا";
            this.columnHeader_کد_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_کد_غذا.Width = 150;
            // 
            // maskedTextBox_کد_غذا
            // 
            this.maskedTextBox_کد_غذا.Location = new System.Drawing.Point(60, 40);
            this.maskedTextBox_کد_غذا.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBox_کد_غذا.Mask = "0000";
            this.maskedTextBox_کد_غذا.Name = "maskedTextBox_کد_غذا";
            this.maskedTextBox_کد_غذا.Size = new System.Drawing.Size(55, 27);
            this.maskedTextBox_کد_غذا.TabIndex = 3;
            this.maskedTextBox_کد_غذا.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_کد_غذا_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(676, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "نام غذا :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد غذا :";
            // 
            // textBox_نام_غذا
            // 
            this.textBox_نام_غذا.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_نام_غذا.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_نام_غذا.Location = new System.Drawing.Point(458, 40);
            this.textBox_نام_غذا.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_نام_غذا.Name = "textBox_نام_غذا";
            this.textBox_نام_غذا.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_نام_غذا.Size = new System.Drawing.Size(215, 27);
            this.textBox_نام_غذا.TabIndex = 1;
            this.textBox_نام_غذا.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_نام_غذا_KeyDown);
            // 
            // button_ثبت
            // 
            this.button_ثبت.Location = new System.Drawing.Point(332, 98);
            this.button_ثبت.Margin = new System.Windows.Forms.Padding(4);
            this.button_ثبت.Name = "button_ثبت";
            this.button_ثبت.Size = new System.Drawing.Size(130, 46);
            this.button_ثبت.TabIndex = 4;
            this.button_ثبت.Text = "ثبت";
            this.button_ثبت.UseVisualStyleBackColor = true;
            this.button_ثبت.Click += new System.EventHandler(this.button_ثبت_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "قیمت :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // textBox_قیمت
            // 
            this.textBox_قیمت.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_قیمت.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_قیمت.Location = new System.Drawing.Point(214, 40);
            this.textBox_قیمت.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_قیمت.Name = "textBox_قیمت";
            this.textBox_قیمت.Size = new System.Drawing.Size(155, 27);
            this.textBox_قیمت.TabIndex = 2;
            this.textBox_قیمت.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_قیمت_KeyDown);
            // 
            // Form_کدهای_غذا
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.textBox_قیمت);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ثبت);
            this.Controls.Add(this.maskedTextBox_کد_غذا);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_نام_غذا);
            this.Controls.Add(this.listView_غذاها);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_کدهای_غذا";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کد غذاهای موجود";
            this.Shown += new System.EventHandler(this.Form_کدهای_غذا_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_کدهای_غذا_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_کدهای_غذا_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_غذاها;
        private System.Windows.Forms.ColumnHeader columnHeader_ردیف;
        private System.Windows.Forms.ColumnHeader columnHeader_نام_غذا;
        private System.Windows.Forms.ColumnHeader columnHeader_کد_غذا;
        private System.Windows.Forms.ColumnHeader columnHeader_قیمت;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_کد_غذا;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_نام_غذا;
        private System.Windows.Forms.Button button_ثبت;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox_قیمت;
    }
}