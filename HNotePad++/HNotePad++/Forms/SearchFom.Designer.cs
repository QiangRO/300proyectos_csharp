namespace HNotePad__
{
    partial class SearchFom
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckbMatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDownDirection = new System.Windows.Forms.RadioButton();
            this.rdbUpDirection = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "چی رو پیدا کنم :";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(100, 13);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(224, 22);
            this.txbInput.TabIndex = 5;
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(327, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 25);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "بعدی رو پیدا کن";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "بی خیال";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckbMatchCase
            // 
            this.ckbMatchCase.AutoSize = true;
            this.ckbMatchCase.Location = new System.Drawing.Point(8, 56);
            this.ckbMatchCase.Name = "ckbMatchCase";
            this.ckbMatchCase.Size = new System.Drawing.Size(118, 18);
            this.ckbMatchCase.TabIndex = 8;
            this.ckbMatchCase.Text = "تطبیق حالت حروف";
            this.ckbMatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDownDirection);
            this.groupBox1.Controls.Add(this.rdbUpDirection);
            this.groupBox1.Location = new System.Drawing.Point(196, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 47);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جهت جستجو";
            // 
            // rdbDownDirection
            // 
            this.rdbDownDirection.AutoSize = true;
            this.rdbDownDirection.Checked = true;
            this.rdbDownDirection.Location = new System.Drawing.Point(59, 20);
            this.rdbDownDirection.Name = "rdbDownDirection";
            this.rdbDownDirection.Size = new System.Drawing.Size(48, 18);
            this.rdbDownDirection.TabIndex = 1;
            this.rdbDownDirection.TabStop = true;
            this.rdbDownDirection.Text = "پایین";
            this.rdbDownDirection.UseVisualStyleBackColor = true;
            this.rdbDownDirection.CheckedChanged += new System.EventHandler(this.rdbDownDirection_CheckedChanged);
            // 
            // rdbUpDirection
            // 
            this.rdbUpDirection.AutoSize = true;
            this.rdbUpDirection.Location = new System.Drawing.Point(7, 20);
            this.rdbUpDirection.Name = "rdbUpDirection";
            this.rdbUpDirection.Size = new System.Drawing.Size(39, 18);
            this.rdbUpDirection.TabIndex = 0;
            this.rdbUpDirection.Text = "بالا";
            this.rdbUpDirection.UseVisualStyleBackColor = true;
            this.rdbUpDirection.CheckedChanged += new System.EventHandler(this.rdbUpDirection_CheckedChanged);
            // 
            // SearchFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 88);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbMatchCase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "SearchFom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "متن یاب";
            this.Load += new System.EventHandler(this.SearchFom_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchFom_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbMatchCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDownDirection;
        private System.Windows.Forms.RadioButton rdbUpDirection;
    }
}