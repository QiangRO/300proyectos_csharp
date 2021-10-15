namespace Wave
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.DlgBrowse = new System.Windows.Forms.OpenFileDialog();
            this.PbxEqu = new System.Windows.Forms.PictureBox();
            this.lblPlayByte = new System.Windows.Forms.Label();
            this.lblTotalByte = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusicBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PbxEqu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persian Gulf";
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Location = new System.Drawing.Point(6, 19);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(51, 23);
            this.btnPlayStop.TabIndex = 3;
            this.btnPlayStop.Text = "Play";
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // DlgBrowse
            // 
            this.DlgBrowse.FileName = "PersianGulf";
            this.DlgBrowse.Title = "PersianGulf";
            // 
            // PbxEqu
            // 
            this.PbxEqu.BackColor = System.Drawing.Color.White;
            this.PbxEqu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxEqu.Location = new System.Drawing.Point(188, 19);
            this.PbxEqu.Name = "PbxEqu";
            this.PbxEqu.Size = new System.Drawing.Size(270, 112);
            this.PbxEqu.TabIndex = 4;
            this.PbxEqu.TabStop = false;
            // 
            // lblPlayByte
            // 
            this.lblPlayByte.Location = new System.Drawing.Point(10, 58);
            this.lblPlayByte.Name = "lblPlayByte";
            this.lblPlayByte.Size = new System.Drawing.Size(173, 23);
            this.lblPlayByte.TabIndex = 5;
            this.lblPlayByte.Text = "Play Byte :";
            // 
            // lblTotalByte
            // 
            this.lblTotalByte.Location = new System.Drawing.Point(9, 81);
            this.lblTotalByte.Name = "lblTotalByte";
            this.lblTotalByte.Size = new System.Drawing.Size(176, 23);
            this.lblTotalByte.TabIndex = 6;
            this.lblTotalByte.Text = "Size Data Byte : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrowse);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open File";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(63, 21);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(148, 20);
            this.txtBrowse.TabIndex = 4;
            this.txtBrowse.Text = "C:\\ConvertedFiles\\02.wav";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MusicBar);
            this.groupBox2.Controls.Add(this.btnPlayStop);
            this.groupBox2.Controls.Add(this.PbxEqu);
            this.groupBox2.Controls.Add(this.lblTotalByte);
            this.groupBox2.Controls.Add(this.lblPlayByte);
            this.groupBox2.Location = new System.Drawing.Point(8, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 229);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // MusicBar
            // 
            this.MusicBar.Location = new System.Drawing.Point(12, 169);
            this.MusicBar.Name = "MusicBar";
            this.MusicBar.Size = new System.Drawing.Size(446, 45);
            this.MusicBar.TabIndex = 7;
            this.MusicBar.TickFrequency = 20;
            this.MusicBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxEqu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.OpenFileDialog DlgBrowse;
        private System.Windows.Forms.PictureBox PbxEqu;
        private System.Windows.Forms.Label lblPlayByte;
        private System.Windows.Forms.Label lblTotalByte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar MusicBar;
    }
}

