namespace HNotePad__
{
    partial class ReplaceForm
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
            this.txbInputString = new System.Windows.Forms.TextBox();
            this.txbReplaceString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextResult = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnReplaceOne = new System.Windows.Forms.Button();
            this.ckbMatchCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbInputString
            // 
            this.txbInputString.Location = new System.Drawing.Point(112, 13);
            this.txbInputString.Name = "txbInputString";
            this.txbInputString.Size = new System.Drawing.Size(249, 22);
            this.txbInputString.TabIndex = 0;
            this.txbInputString.TextChanged += new System.EventHandler(this.txbInputString_TextChanged);
            // 
            // txbReplaceString
            // 
            this.txbReplaceString.Location = new System.Drawing.Point(112, 41);
            this.txbReplaceString.Name = "txbReplaceString";
            this.txbReplaceString.Size = new System.Drawing.Size(249, 22);
            this.txbReplaceString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "چی رو پیدا کنم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "با چی عوضش کنم :";
            // 
            // btnNextResult
            // 
            this.btnNextResult.Location = new System.Drawing.Point(137, 69);
            this.btnNextResult.Name = "btnNextResult";
            this.btnNextResult.Size = new System.Drawing.Size(101, 23);
            this.btnNextResult.TabIndex = 2;
            this.btnNextResult.Text = "بعدی";
            this.btnNextResult.UseVisualStyleBackColor = true;
            this.btnNextResult.Click += new System.EventHandler(this.btnNextResult_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "بی خیال";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(260, 69);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(101, 23);
            this.btnReplaceAll.TabIndex = 4;
            this.btnReplaceAll.Text = "همه رو عوض کن";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnReplaceOne
            // 
            this.btnReplaceOne.Location = new System.Drawing.Point(137, 97);
            this.btnReplaceOne.Name = "btnReplaceOne";
            this.btnReplaceOne.Size = new System.Drawing.Size(101, 23);
            this.btnReplaceOne.TabIndex = 3;
            this.btnReplaceOne.Text = "اینو عوضش کن";
            this.btnReplaceOne.UseVisualStyleBackColor = true;
            this.btnReplaceOne.Click += new System.EventHandler(this.btnReplaceOne_Click);
            // 
            // ckbMatchCase
            // 
            this.ckbMatchCase.AutoSize = true;
            this.ckbMatchCase.Location = new System.Drawing.Point(4, 97);
            this.ckbMatchCase.Name = "ckbMatchCase";
            this.ckbMatchCase.Size = new System.Drawing.Size(118, 18);
            this.ckbMatchCase.TabIndex = 9;
            this.ckbMatchCase.Text = "تطبیق حالت حروف";
            this.ckbMatchCase.UseVisualStyleBackColor = true;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 134);
            this.Controls.Add(this.ckbMatchCase);
            this.Controls.Add(this.btnReplaceOne);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbReplaceString);
            this.Controls.Add(this.txbInputString);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ReplaceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "متن عوض کن";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReplaceForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInputString;
        private System.Windows.Forms.TextBox txbReplaceString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextResult;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnReplaceOne;
        private System.Windows.Forms.CheckBox ckbMatchCase;
    }
}