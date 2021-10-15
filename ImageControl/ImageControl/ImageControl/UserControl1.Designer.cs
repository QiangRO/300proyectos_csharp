namespace ImageControl
{
    partial class PersonImage
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
            this.arrow = new System.Windows.Forms.PictureBox();
            this.person = new System.Windows.Forms.PictureBox();
            this.browseMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).BeginInit();
            this.SuspendLayout();
            // 
            // arrow
            // 
            this.arrow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.arrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrow.Image = global::ImageControl.Properties.Resources.arrow1;
            this.arrow.Location = new System.Drawing.Point(0, 129);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(111, 12);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 1;
            this.arrow.TabStop = false;
            this.arrow.MouseLeave += new System.EventHandler(this.arrow_MouseLeave);
            this.arrow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arrow_MouseMove);
            this.arrow.Click += new System.EventHandler(this.arrow_Click);
            // 
            // person
            // 
            this.person.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.person.BackColor = System.Drawing.SystemColors.Window;
            this.person.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.person.Image = global::ImageControl.Properties.Resources.person;
            this.person.Location = new System.Drawing.Point(0, 0);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(111, 130);
            this.person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.person.TabIndex = 0;
            this.person.TabStop = false;
            // 
            // browseMenu
            // 
            this.browseMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "عکس پیش فرض";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "جستجو بدنبال عکس";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All image formats (*.bmp; *.gif; *.jpg; *.jpeg)|*.bmp;*.gif;*.jpg;*.jpeg";
            this.openFileDialog.Title = "جستجو بدنبال عکس";
            // 
            // PersonImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.person);
            this.MaximumSize = new System.Drawing.Size(112, 142);
            this.MinimumSize = new System.Drawing.Size(94, 115);
            this.Name = "PersonImage";
            this.Size = new System.Drawing.Size(112, 142);
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox person;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.ContextMenu browseMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
