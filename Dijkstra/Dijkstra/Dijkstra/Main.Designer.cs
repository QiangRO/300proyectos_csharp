namespace Dijkstra
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.processBtn = new System.Windows.Forms.Button();
            this.graphBoardPB = new System.Windows.Forms.PictureBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphBoardPB)).BeginInit();
            this.SuspendLayout();
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(415, 12);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(113, 46);
            this.processBtn.TabIndex = 0;
            this.processBtn.Text = "یافتن کوتاهترین مسیر بین دو گره";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // graphBoardPB
            // 
            this.graphBoardPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphBoardPB.Cursor = System.Windows.Forms.Cursors.Cross;
            this.graphBoardPB.Location = new System.Drawing.Point(12, 12);
            this.graphBoardPB.Name = "graphBoardPB";
            this.graphBoardPB.Size = new System.Drawing.Size(396, 332);
            this.graphBoardPB.TabIndex = 2;
            this.graphBoardPB.TabStop = false;
            this.graphBoardPB.Tag = "1";
            this.graphBoardPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseMove);
            this.graphBoardPB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseDoubleClick);
            this.graphBoardPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphBoardPB_MouseClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(415, 64);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(113, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "ریست";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 351);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(286, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "برای انتخاب گره های مبدا و مقصد روی گره راست کلیک کنید.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.graphBoardPB);
            this.Controls.Add(this.processBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الگوریتم دایجسترا";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.graphBoardPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.PictureBox graphBoardPB;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label1;
    }
}

