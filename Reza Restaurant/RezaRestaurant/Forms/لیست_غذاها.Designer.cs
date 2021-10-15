namespace RezaRestaurant.Forms
{
    partial class Form_لیست_غذاها
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
            this.listView_لیست_غذاها = new System.Windows.Forms.ListView();
            this.columnHeader_نام_غذا = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_کد_غذا = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView_لیست_غذاها
            // 
            this.listView_لیست_غذاها.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_نام_غذا,
            this.columnHeader_کد_غذا});
            this.listView_لیست_غذاها.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_لیست_غذاها.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listView_لیست_غذاها.FullRowSelect = true;
            this.listView_لیست_غذاها.HideSelection = false;
            this.listView_لیست_غذاها.Location = new System.Drawing.Point(0, 0);
            this.listView_لیست_غذاها.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listView_لیست_غذاها.Name = "listView_لیست_غذاها";
            this.listView_لیست_غذاها.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_لیست_غذاها.RightToLeftLayout = true;
            this.listView_لیست_غذاها.Size = new System.Drawing.Size(366, 650);
            this.listView_لیست_غذاها.TabIndex = 1;
            this.listView_لیست_غذاها.UseCompatibleStateImageBehavior = false;
            this.listView_لیست_غذاها.View = System.Windows.Forms.View.Details;
            this.listView_لیست_غذاها.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_فاکتور_Click);
            // 
            // columnHeader_نام_غذا
            // 
            this.columnHeader_نام_غذا.Text = "نام";
            this.columnHeader_نام_غذا.Width = 230;
            // 
            // columnHeader_کد_غذا
            // 
            this.columnHeader_کد_غذا.Text = "کد";
            this.columnHeader_کد_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_کد_غذا.Width = 130;
            // 
            // Form_لیست_غذاها
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 650);
            this.Controls.Add(this.listView_لیست_غذاها);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_لیست_غذاها";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "لیست غذا ها";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_لیست_غذاها_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_لیست_غذاها_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_لیست_غذاها;
        private System.Windows.Forms.ColumnHeader columnHeader_نام_غذا;
        private System.Windows.Forms.ColumnHeader columnHeader_کد_غذا;
    }
}