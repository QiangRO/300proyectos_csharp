namespace SampleDataGridViewSpesific
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSpesific1 = new dataGridViewSpesific.dataGridViewSpesific();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpesific1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSpesific1
            // 
            this.dataGridViewSpesific1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSpesific1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpesific1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.delete});
            this.dataGridViewSpesific1.Location = new System.Drawing.Point(82, 62);
            this.dataGridViewSpesific1.Name = "dataGridViewSpesific1";
            this.dataGridViewSpesific1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSpesific1.Size = new System.Drawing.Size(422, 150);
            this.dataGridViewSpesific1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نام";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شهرت";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "تلفن";
            this.Column3.Name = "Column3";
            // 
            // delete
            // 
            this.delete.FillWeight = 40F;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 270);
            this.Controls.Add(this.dataGridViewSpesific1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpesific1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dataGridViewSpesific.dataGridViewSpesific dataGridViewSpesific1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}

