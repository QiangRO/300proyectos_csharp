namespace Neon_Clock__CS_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.h1 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m1 = new System.Windows.Forms.PictureBox();
            this.m2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.Image = ((System.Drawing.Image)(resources.GetObject("h1.Image")));
            this.h1.Location = new System.Drawing.Point(12, 12);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(43, 57);
            this.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.h1.TabIndex = 0;
            this.h1.TabStop = false;
            // 
            // h2
            // 
            this.h2.Image = ((System.Drawing.Image)(resources.GetObject("h2.Image")));
            this.h2.Location = new System.Drawing.Point(55, 12);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(43, 57);
            this.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.h2.TabIndex = 1;
            this.h2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(98, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // m1
            // 
            this.m1.Image = ((System.Drawing.Image)(resources.GetObject("m1.Image")));
            this.m1.Location = new System.Drawing.Point(126, 12);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(43, 57);
            this.m1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m1.TabIndex = 3;
            this.m1.TabStop = false;
            // 
            // m2
            // 
            this.m2.Image = ((System.Drawing.Image)(resources.GetObject("m2.Image")));
            this.m2.Location = new System.Drawing.Point(169, 12);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(43, 57);
            this.m2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m2.TabIndex = 4;
            this.m2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(230, 91);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = " Neon Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox m1;
        private System.Windows.Forms.PictureBox m2;
        private System.Windows.Forms.Timer timer1;
    }
}

