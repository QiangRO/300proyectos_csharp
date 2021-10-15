using System.Windows.Forms;
namespace Calculator_User
{
    partial class Calculator
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
            this.button_darsad = new System.Windows.Forms.Button();
            this.button_dat = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_000 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_sing = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_00 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.Backspace_button = new System.Windows.Forms.Button();
            this.ce_button = new System.Windows.Forms.Button();
            this.c_button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_darsad
            // 
            this.button_darsad.ForeColor = System.Drawing.Color.Blue;
            this.button_darsad.Location = new System.Drawing.Point(155, 93);
            this.button_darsad.Name = "button_darsad";
            this.button_darsad.Size = new System.Drawing.Size(35, 27);
            this.button_darsad.TabIndex = 22;
            this.button_darsad.TabStop = false;
            this.button_darsad.Text = "%";
            this.button_darsad.UseVisualStyleBackColor = true;
            this.button_darsad.Click += new System.EventHandler(this.button_darsad_Click);
            // 
            // button_dat
            // 
            this.button_dat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_dat.ForeColor = System.Drawing.Color.Blue;
            this.button_dat.Location = new System.Drawing.Point(155, 124);
            this.button_dat.Name = "button_dat";
            this.button_dat.Size = new System.Drawing.Size(35, 27);
            this.button_dat.TabIndex = 11;
            this.button_dat.TabStop = false;
            this.button_dat.Text = ".";
            this.button_dat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_dat.UseVisualStyleBackColor = true;
            this.button_dat.Click += new System.EventHandler(this.button_dat_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_add.ForeColor = System.Drawing.Color.Red;
            this.button_add.Location = new System.Drawing.Point(117, 158);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(35, 27);
            this.button_add.TabIndex = 16;
            this.button_add.TabStop = false;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_subtract.ForeColor = System.Drawing.Color.Red;
            this.button_subtract.Location = new System.Drawing.Point(117, 125);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(35, 27);
            this.button_subtract.TabIndex = 17;
            this.button_subtract.TabStop = false;
            this.button_subtract.Text = "-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_000
            // 
            this.button_000.ForeColor = System.Drawing.Color.Blue;
            this.button_000.Location = new System.Drawing.Point(79, 158);
            this.button_000.Name = "button_000";
            this.button_000.Size = new System.Drawing.Size(35, 27);
            this.button_000.TabIndex = 14;
            this.button_000.TabStop = false;
            this.button_000.Text = "000";
            this.button_000.UseVisualStyleBackColor = true;
            this.button_000.Click += new System.EventHandler(this.button_000_Click);
            // 
            // button_1
            // 
            this.button_1.ForeColor = System.Drawing.Color.Blue;
            this.button_1.Location = new System.Drawing.Point(3, 125);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(35, 27);
            this.button_1.TabIndex = 2;
            this.button_1.TabStop = false;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_2
            // 
            this.button_2.ForeColor = System.Drawing.Color.Blue;
            this.button_2.Location = new System.Drawing.Point(41, 125);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(35, 27);
            this.button_2.TabIndex = 3;
            this.button_2.TabStop = false;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.ForeColor = System.Drawing.Color.Blue;
            this.button_3.Location = new System.Drawing.Point(79, 125);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(35, 27);
            this.button_3.TabIndex = 4;
            this.button_3.TabStop = false;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_sing
            // 
            this.button_sing.ForeColor = System.Drawing.Color.Blue;
            this.button_sing.Location = new System.Drawing.Point(155, 60);
            this.button_sing.Name = "button_sing";
            this.button_sing.Size = new System.Drawing.Size(35, 27);
            this.button_sing.TabIndex = 21;
            this.button_sing.TabStop = false;
            this.button_sing.Text = "+/-";
            this.button_sing.UseVisualStyleBackColor = true;
            this.button_sing.Click += new System.EventHandler(this.button_sing_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.ForeColor = System.Drawing.Color.Red;
            this.button_Divide.Location = new System.Drawing.Point(117, 60);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(35, 27);
            this.button_Divide.TabIndex = 19;
            this.button_Divide.TabStop = false;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_4
            // 
            this.button_4.ForeColor = System.Drawing.Color.Blue;
            this.button_4.Location = new System.Drawing.Point(3, 92);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(35, 27);
            this.button_4.TabIndex = 5;
            this.button_4.TabStop = false;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_5
            // 
            this.button_5.ForeColor = System.Drawing.Color.Blue;
            this.button_5.Location = new System.Drawing.Point(41, 92);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(35, 27);
            this.button_5.TabIndex = 6;
            this.button_5.TabStop = false;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_multiply.ForeColor = System.Drawing.Color.Red;
            this.button_multiply.Location = new System.Drawing.Point(117, 92);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(35, 27);
            this.button_multiply.TabIndex = 18;
            this.button_multiply.TabStop = false;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_equals
            // 
            this.button_equals.ForeColor = System.Drawing.Color.Red;
            this.button_equals.Location = new System.Drawing.Point(155, 158);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(35, 27);
            this.button_equals.TabIndex = 20;
            this.button_equals.TabStop = false;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = true;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_8
            // 
            this.button_8.ForeColor = System.Drawing.Color.Blue;
            this.button_8.Location = new System.Drawing.Point(41, 60);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(35, 27);
            this.button_8.TabIndex = 9;
            this.button_8.TabStop = false;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_9
            // 
            this.button_9.ForeColor = System.Drawing.Color.Blue;
            this.button_9.Location = new System.Drawing.Point(79, 60);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(35, 27);
            this.button_9.TabIndex = 10;
            this.button_9.TabStop = false;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_00
            // 
            this.button_00.ForeColor = System.Drawing.Color.Blue;
            this.button_00.Location = new System.Drawing.Point(41, 158);
            this.button_00.Name = "button_00";
            this.button_00.Size = new System.Drawing.Size(35, 27);
            this.button_00.TabIndex = 13;
            this.button_00.TabStop = false;
            this.button_00.Text = "00";
            this.button_00.UseVisualStyleBackColor = true;
            this.button_00.Click += new System.EventHandler(this.button_00_Click);
            // 
            // button_7
            // 
            this.button_7.ForeColor = System.Drawing.Color.Blue;
            this.button_7.Location = new System.Drawing.Point(3, 60);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(35, 27);
            this.button_7.TabIndex = 8;
            this.button_7.TabStop = false;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_6
            // 
            this.button_6.ForeColor = System.Drawing.Color.Blue;
            this.button_6.Location = new System.Drawing.Point(79, 92);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(35, 27);
            this.button_6.TabIndex = 7;
            this.button_6.TabStop = false;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_0
            // 
            this.button_0.ForeColor = System.Drawing.Color.Blue;
            this.button_0.Location = new System.Drawing.Point(3, 158);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(35, 27);
            this.button_0.TabIndex = 12;
            this.button_0.TabStop = false;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // Backspace_button
            // 
            this.Backspace_button.ForeColor = System.Drawing.Color.Blue;
            this.Backspace_button.Location = new System.Drawing.Point(2, 27);
            this.Backspace_button.Name = "Backspace_button";
            this.Backspace_button.Size = new System.Drawing.Size(73, 27);
            this.Backspace_button.TabIndex = 15;
            this.Backspace_button.TabStop = false;
            this.Backspace_button.Text = "Backspace";
            this.Backspace_button.UseVisualStyleBackColor = true;
            this.Backspace_button.Click += new System.EventHandler(this.Backspace_button_Click);
            // 
            // ce_button
            // 
            this.ce_button.ForeColor = System.Drawing.Color.Red;
            this.ce_button.Location = new System.Drawing.Point(79, 27);
            this.ce_button.Name = "ce_button";
            this.ce_button.Size = new System.Drawing.Size(52, 27);
            this.ce_button.TabIndex = 1;
            this.ce_button.TabStop = false;
            this.ce_button.Text = "CE";
            this.ce_button.UseVisualStyleBackColor = true;
            this.ce_button.Click += new System.EventHandler(this.ce_button_Click);
            // 
            // c_button
            // 
            this.c_button.ForeColor = System.Drawing.Color.Red;
            this.c_button.Location = new System.Drawing.Point(138, 27);
            this.c_button.Name = "c_button";
            this.c_button.Size = new System.Drawing.Size(52, 27);
            this.c_button.TabIndex = 0;
            this.c_button.TabStop = false;
            this.c_button.Text = "C";
            this.c_button.UseVisualStyleBackColor = true;
            this.c_button.Click += new System.EventHandler(this.c_button_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.MaxLength = 13;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(186, 20);
            this.textBox.TabIndex = 23;
            this.textBox.TabStop = false;
            this.textBox.Text = "0.";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_darsad);
            this.Controls.Add(this.button_dat);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_subtract);
            this.Controls.Add(this.button_000);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_sing);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_00);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.Backspace_button);
            this.Controls.Add(this.ce_button);
            this.Controls.Add(this.c_button);
            this.MaximumSize = new System.Drawing.Size(198, 193);
            this.MinimumSize = new System.Drawing.Size(192, 188);
            this.Name = "Calculator";
            this.Size = new System.Drawing.Size(198, 193);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_darsad;
        private System.Windows.Forms.Button button_dat;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_000;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_sing;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_00;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button Backspace_button;
        private System.Windows.Forms.Button ce_button;
        private System.Windows.Forms.Button c_button;
        private System.Windows.Forms.TextBox textBox;

        private string cal = "";
        private string cal2 = "";
        private string num = "";
        private bool flag_dat;
        private string sign_str = "";
        private KeyEventArgs Key;
    }
}
