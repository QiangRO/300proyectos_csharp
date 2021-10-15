namespace RezaRestaurant
{
    partial class Form_پیغام
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
            this.label_متن_پیغام = new System.Windows.Forms.Label();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_متن_پیغام
            // 
            this.label_متن_پیغام.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_متن_پیغام.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_متن_پیغام.Location = new System.Drawing.Point(96, 13);
            this.label_متن_پیغام.Name = "label_متن_پیغام";
            this.label_متن_پیغام.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_متن_پیغام.Size = new System.Drawing.Size(273, 80);
            this.label_متن_پیغام.TabIndex = 0;
            this.label_متن_پیغام.Text = "متن پیام";
            this.label_متن_پیغام.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(208, 124);
            this.button01.Margin = new System.Windows.Forms.Padding(4);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(145, 52);
            this.button01.TabIndex = 1;
            this.button01.Text = "button 01";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(27, 124);
            this.button02.Margin = new System.Windows.Forms.Padding(4);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(145, 52);
            this.button02.TabIndex = 2;
            this.button02.Text = "button 02";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RezaRestaurant.Properties.Resources.Warning;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_پیغام
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 189);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.label_متن_پیغام);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_پیغام";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیغام";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_پیغام_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_متن_پیغام;
        public System.Windows.Forms.Button button01;
        public System.Windows.Forms.Button button02;
    }
}