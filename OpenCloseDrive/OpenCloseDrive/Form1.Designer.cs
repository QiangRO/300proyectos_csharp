namespace OpenCloseDrive
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
            this.openb = new System.Windows.Forms.Button();
            this.closeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openb
            // 
            this.openb.Location = new System.Drawing.Point(12, 12);
            this.openb.Name = "openb";
            this.openb.Size = new System.Drawing.Size(75, 23);
            this.openb.TabIndex = 0;
            this.openb.Text = "Open";
            this.openb.UseVisualStyleBackColor = true;
            this.openb.Click += new System.EventHandler(this.openb_Click);
            // 
            // closeb
            // 
            this.closeb.Location = new System.Drawing.Point(107, 12);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(75, 23);
            this.closeb.TabIndex = 1;
            this.closeb.Text = "Close";
            this.closeb.UseVisualStyleBackColor = true;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 44);
            this.Controls.Add(this.closeb);
            this.Controls.Add(this.openb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CD Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openb;
        private System.Windows.Forms.Button closeb;
    }
}

