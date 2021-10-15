namespace FixProgram
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblIn2Post = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIn2Pre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPost2In = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPre2In = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "(A+B)*D+E/(F+A*D)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parenthesis";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblP.Location = new System.Drawing.Point(80, 58);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(11, 13);
            this.lblP.TabIndex = 3;
            this.lblP.Text = "-";
            // 
            // lblIn2Post
            // 
            this.lblIn2Post.AutoSize = true;
            this.lblIn2Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIn2Post.Location = new System.Drawing.Point(80, 85);
            this.lblIn2Post.Name = "lblIn2Post";
            this.lblIn2Post.Size = new System.Drawing.Size(11, 13);
            this.lblIn2Post.TabIndex = 5;
            this.lblIn2Post.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Infix2Postfix";
            // 
            // lblIn2Pre
            // 
            this.lblIn2Pre.AutoSize = true;
            this.lblIn2Pre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIn2Pre.Location = new System.Drawing.Point(80, 113);
            this.lblIn2Pre.Name = "lblIn2Pre";
            this.lblIn2Pre.Size = new System.Drawing.Size(11, 13);
            this.lblIn2Pre.TabIndex = 7;
            this.lblIn2Pre.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Infix2Prefix";
            // 
            // lblPost2In
            // 
            this.lblPost2In.AutoSize = true;
            this.lblPost2In.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPost2In.Location = new System.Drawing.Point(80, 140);
            this.lblPost2In.Name = "lblPost2In";
            this.lblPost2In.Size = new System.Drawing.Size(11, 13);
            this.lblPost2In.TabIndex = 9;
            this.lblPost2In.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Postfix2Infix";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPre2In
            // 
            this.lblPre2In.AutoSize = true;
            this.lblPre2In.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPre2In.Location = new System.Drawing.Point(80, 168);
            this.lblPre2In.Name = "lblPre2In";
            this.lblPre2In.Size = new System.Drawing.Size(11, 13);
            this.lblPre2In.TabIndex = 11;
            this.lblPre2In.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prefix2Infix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 342);
            this.Controls.Add(this.lblPre2In);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPost2In);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIn2Pre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIn2Post);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblIn2Post;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIn2Pre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPost2In;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPre2In;
        private System.Windows.Forms.Label label4;

    }
}

