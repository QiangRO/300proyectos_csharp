namespace Excel_Example
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
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonNewSheet = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonOpenTemplate = new System.Windows.Forms.Button();
            this.textBoxSheetName = new System.Windows.Forms.TextBox();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(12, 70);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 0;
            this.buttonSaveAs.Text = "Save As ...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonNewSheet
            // 
            this.buttonNewSheet.Location = new System.Drawing.Point(12, 41);
            this.buttonNewSheet.Name = "buttonNewSheet";
            this.buttonNewSheet.Size = new System.Drawing.Size(75, 23);
            this.buttonNewSheet.TabIndex = 1;
            this.buttonNewSheet.Text = "New Sheet";
            this.buttonNewSheet.UseVisualStyleBackColor = true;
            this.buttonNewSheet.Click += new System.EventHandler(this.buttonNewSheet_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonOpenTemplate
            // 
            this.buttonOpenTemplate.Location = new System.Drawing.Point(171, 15);
            this.buttonOpenTemplate.Name = "buttonOpenTemplate";
            this.buttonOpenTemplate.Size = new System.Drawing.Size(109, 23);
            this.buttonOpenTemplate.TabIndex = 3;
            this.buttonOpenTemplate.Text = "Open Template";
            this.buttonOpenTemplate.UseVisualStyleBackColor = true;
            this.buttonOpenTemplate.Click += new System.EventHandler(this.buttonOpenTemplate_Click);
            // 
            // textBoxSheetName
            // 
            this.textBoxSheetName.Location = new System.Drawing.Point(93, 44);
            this.textBoxSheetName.Name = "textBoxSheetName";
            this.textBoxSheetName.Size = new System.Drawing.Size(187, 20);
            this.textBoxSheetName.TabIndex = 4;
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(12, 117);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(95, 23);
            this.buttonAverage.TabIndex = 5;
            this.buttonAverage.Text = "Open Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 146);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(95, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Average:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(69, 184);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(137, 209);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 10;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(137, 181);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.textBoxSheetName);
            this.Controls.Add(this.buttonOpenTemplate);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNewSheet);
            this.Controls.Add(this.buttonSaveAs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonNewSheet;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonOpenTemplate;
        private System.Windows.Forms.TextBox textBoxSheetName;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

