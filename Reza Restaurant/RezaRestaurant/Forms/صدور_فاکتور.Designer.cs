namespace RezaRestaurant
{
    partial class Form_صدور_فاکتور
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_صدور_فاکتور));
            this.listView_فاکتور = new System.Windows.Forms.ListView();
            this.columnHeader_شماره_ردیف = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_نام_غذا = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_تعداد = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_قیمت_یک_واحد = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_مبلغ_کل = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.button_ثبت_و_چاپ_فاکتور = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_کد_غذا = new System.Windows.Forms.TextBox();
            this.label_نوع_فاکتور = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_شماره_فاکتور = new System.Windows.Forms.MaskedTextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_جمع_فاکتور = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_تعداد_غذا = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_شماره_سریال = new System.Windows.Forms.Label();
            this.textBox_شماره_میز = new System.Windows.Forms.TextBox();
            this.label_شماره_میز = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_فاکتور
            // 
            this.listView_فاکتور.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_شماره_ردیف,
            this.columnHeader_نام_غذا,
            this.columnHeader_تعداد,
            this.columnHeader_قیمت_یک_واحد,
            this.columnHeader_مبلغ_کل});
            this.listView_فاکتور.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_فاکتور.FullRowSelect = true;
            this.listView_فاکتور.HideSelection = false;
            this.listView_فاکتور.Location = new System.Drawing.Point(-1, 287);
            this.listView_فاکتور.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listView_فاکتور.Name = "listView_فاکتور";
            this.listView_فاکتور.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_فاکتور.RightToLeftLayout = true;
            this.listView_فاکتور.Size = new System.Drawing.Size(795, 337);
            this.listView_فاکتور.TabIndex = 0;
            this.listView_فاکتور.UseCompatibleStateImageBehavior = false;
            this.listView_فاکتور.View = System.Windows.Forms.View.Details;
            this.listView_فاکتور.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_فاکتور_MouseClick);
            this.listView_فاکتور.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_فاکتور_Click);
            this.listView_فاکتور.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_فاکتور_KeyDown);
            // 
            // columnHeader_شماره_ردیف
            // 
            this.columnHeader_شماره_ردیف.Text = "شماره ردیف";
            this.columnHeader_شماره_ردیف.Width = 110;
            // 
            // columnHeader_نام_غذا
            // 
            this.columnHeader_نام_غذا.Text = "نام غذا";
            this.columnHeader_نام_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_نام_غذا.Width = 280;
            // 
            // columnHeader_تعداد
            // 
            this.columnHeader_تعداد.Text = "تعداد";
            this.columnHeader_تعداد.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_تعداد.Width = 150;
            // 
            // columnHeader_قیمت_یک_واحد
            // 
            this.columnHeader_قیمت_یک_واحد.Text = "قیمت یک واحد ریال";
            this.columnHeader_قیمت_یک_واحد.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_قیمت_یک_واحد.Width = 220;
            // 
            // columnHeader_مبلغ_کل
            // 
            this.columnHeader_مبلغ_کل.Text = "مبلغ کل";
            this.columnHeader_مبلغ_کل.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_مبلغ_کل.Width = 220;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "تعداد :";
            // 
            // button_ثبت_و_چاپ_فاکتور
            // 
            this.button_ثبت_و_چاپ_فاکتور.Location = new System.Drawing.Point(332, 220);
            this.button_ثبت_و_چاپ_فاکتور.Margin = new System.Windows.Forms.Padding(4);
            this.button_ثبت_و_چاپ_فاکتور.Name = "button_ثبت_و_چاپ_فاکتور";
            this.button_ثبت_و_چاپ_فاکتور.Size = new System.Drawing.Size(130, 46);
            this.button_ثبت_و_چاپ_فاکتور.TabIndex = 5;
            this.button_ثبت_و_چاپ_فاکتور.Text = "ثبت و چاپ";
            this.button_ثبت_و_چاپ_فاکتور.UseVisualStyleBackColor = true;
            this.button_ثبت_و_چاپ_فاکتور.Click += new System.EventHandler(this.button_ثبت_و_چاپ_فاکتور_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد غذا :";
            // 
            // textBox_کد_غذا
            // 
            this.textBox_کد_غذا.Location = new System.Drawing.Point(337, 175);
            this.textBox_کد_غذا.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_کد_غذا.Name = "textBox_کد_غذا";
            this.textBox_کد_غذا.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_کد_غذا.Size = new System.Drawing.Size(203, 27);
            this.textBox_کد_غذا.TabIndex = 3;
            this.textBox_کد_غذا.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_کد_غذا_KeyDown);
            // 
            // label_نوع_فاکتور
            // 
            this.label_نوع_فاکتور.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_نوع_فاکتور.Font = new System.Drawing.Font("B Titr", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_نوع_فاکتور.Location = new System.Drawing.Point(13, 9);
            this.label_نوع_فاکتور.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_نوع_فاکتور.Name = "label_نوع_فاکتور";
            this.label_نوع_فاکتور.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_نوع_فاکتور.Size = new System.Drawing.Size(768, 44);
            this.label_نوع_فاکتور.TabIndex = 0;
            this.label_نوع_فاکتور.Text = "میز داخلی";
            this.label_نوع_فاکتور.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_نوع_فاکتور, "نوع فاکتور F5");
            this.label_نوع_فاکتور.TextChanged += new System.EventHandler(this.label_نوع_فاکتور_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(365, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "شماره فاکتور :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_شماره_فاکتور
            // 
            this.maskedTextBox_شماره_فاکتور.Location = new System.Drawing.Point(317, 72);
            this.maskedTextBox_شماره_فاکتور.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_شماره_فاکتور.Mask = "0000";
            this.maskedTextBox_شماره_فاکتور.Name = "maskedTextBox_شماره_فاکتور";
            this.maskedTextBox_شماره_فاکتور.Size = new System.Drawing.Size(50, 27);
            this.maskedTextBox_شماره_فاکتور.TabIndex = 1;
            this.maskedTextBox_شماره_فاکتور.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_شماره_فاکتور_KeyDown);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = global::RezaRestaurant.Properties.Resources.next;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.Location = new System.Drawing.Point(638, 57);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(67, 55);
            this.buttonNext.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonNext, "فاکتور بعدی");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::RezaRestaurant.Properties.Resources.back;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBack.Location = new System.Drawing.Point(90, 57);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(67, 55);
            this.buttonBack.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonBack, "فاکتور قبلی");
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 649);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "جمع کل فاکتور :";
            // 
            // label_جمع_فاکتور
            // 
            this.label_جمع_فاکتور.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_جمع_فاکتور.AutoSize = true;
            this.label_جمع_فاکتور.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_جمع_فاکتور.Location = new System.Drawing.Point(267, 642);
            this.label_جمع_فاکتور.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_جمع_فاکتور.Name = "label_جمع_فاکتور";
            this.label_جمع_فاکتور.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_جمع_فاکتور.Size = new System.Drawing.Size(93, 33);
            this.label_جمع_فاکتور.TabIndex = 0;
            this.label_جمع_فاکتور.Text = "جمع فاکتور";
            this.label_جمع_فاکتور.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 649);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ریال";
            // 
            // textBox_تعداد_غذا
            // 
            this.textBox_تعداد_غذا.Location = new System.Drawing.Point(183, 175);
            this.textBox_تعداد_غذا.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_تعداد_غذا.Name = "textBox_تعداد_غذا";
            this.textBox_تعداد_غذا.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_تعداد_غذا.Size = new System.Drawing.Size(61, 27);
            this.textBox_تعداد_غذا.TabIndex = 4;
            this.textBox_تعداد_غذا.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_تعداد_غذا_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.deleteToolStripMenuItem.Text = "حذف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label_شماره_سریال
            // 
            this.label_شماره_سریال.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_شماره_سریال.AutoSize = true;
            this.label_شماره_سریال.Font = new System.Drawing.Font("B Zar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_شماره_سریال.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_شماره_سریال.Location = new System.Drawing.Point(13, 9);
            this.label_شماره_سریال.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_شماره_سریال.Name = "label_شماره_سریال";
            this.label_شماره_سریال.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_شماره_سریال.Size = new System.Drawing.Size(59, 22);
            this.label_شماره_سریال.TabIndex = 0;
            this.label_شماره_سریال.Text = "شماره سریال";
            this.label_شماره_سریال.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_شماره_سریال.Visible = false;
            // 
            // textBox_شماره_میز
            // 
            this.textBox_شماره_میز.Location = new System.Drawing.Point(317, 127);
            this.textBox_شماره_میز.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_شماره_میز.Name = "textBox_شماره_میز";
            this.textBox_شماره_میز.Size = new System.Drawing.Size(50, 27);
            this.textBox_شماره_میز.TabIndex = 2;
            this.textBox_شماره_میز.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_شماره_میز_KeyDown);
            // 
            // label_شماره_میز
            // 
            this.label_شماره_میز.AutoSize = true;
            this.label_شماره_میز.Location = new System.Drawing.Point(384, 130);
            this.label_شماره_میز.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_شماره_میز.Name = "label_شماره_میز";
            this.label_شماره_میز.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_شماره_میز.Size = new System.Drawing.Size(91, 19);
            this.label_شماره_میز.TabIndex = 0;
            this.label_شماره_میز.Text = "شماره میز :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // Form_صدور_فاکتور
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 690);
            this.Controls.Add(this.label_شماره_میز);
            this.Controls.Add(this.textBox_شماره_میز);
            this.Controls.Add(this.label_شماره_سریال);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_تعداد_غذا);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_جمع_فاکتور);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.maskedTextBox_شماره_فاکتور);
            this.Controls.Add(this.listView_فاکتور);
            this.Controls.Add(this.label_نوع_فاکتور);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_کد_غذا);
            this.Controls.Add(this.button_ثبت_و_چاپ_فاکتور);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_صدور_فاکتور";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صدور فاکتور";
            this.Shown += new System.EventHandler(this.Form_صدور_فاکتور_Shown);
            this.Activated += new System.EventHandler(this.Form_صدور_فاکتور_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_صدور_فاکتور_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_صدور_فاکتور_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_فاکتور;
        private System.Windows.Forms.ColumnHeader columnHeader_شماره_ردیف;
        private System.Windows.Forms.ColumnHeader columnHeader_نام_غذا;
        private System.Windows.Forms.ColumnHeader columnHeader_تعداد;
        private System.Windows.Forms.ColumnHeader columnHeader_قیمت_یک_واحد;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_ثبت_و_چاپ_فاکتور;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_کد_غذا;
        private System.Windows.Forms.Label label_نوع_فاکتور;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_شماره_فاکتور;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ColumnHeader columnHeader_مبلغ_کل;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_جمع_فاکتور;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_تعداد_غذا;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label_شماره_سریال;
        private System.Windows.Forms.TextBox textBox_شماره_میز;
        private System.Windows.Forms.Label label_شماره_میز;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}