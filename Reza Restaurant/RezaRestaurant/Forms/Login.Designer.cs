namespace RezaRestaurant.Forms
{
    partial class FormLogin
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
            this.textBox_رمز = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ورود = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_رمز
            // 
            this.textBox_رمز.Location = new System.Drawing.Point(63, 28);
            this.textBox_رمز.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_رمز.Name = "textBox_رمز";
            this.textBox_رمز.PasswordChar = '*';
            this.textBox_رمز.Size = new System.Drawing.Size(180, 27);
            this.textBox_رمز.TabIndex = 1;
            this.textBox_رمز.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_رمز_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور :";
            // 
            // button_ورود
            // 
            this.button_ورود.Location = new System.Drawing.Point(139, 74);
            this.button_ورود.Name = "button_ورود";
            this.button_ورود.Size = new System.Drawing.Size(113, 39);
            this.button_ورود.TabIndex = 2;
            this.button_ورود.Text = "ورود";
            this.button_ورود.UseVisualStyleBackColor = true;
            this.button_ورود.Click += new System.EventHandler(this.button_ورود_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 134);
            this.Controls.Add(this.button_ورود);
            this.Controls.Add(this.textBox_رمز);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_رمز;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ورود;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}