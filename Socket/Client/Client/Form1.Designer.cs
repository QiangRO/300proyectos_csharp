namespace Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtbxRcv = new System.Windows.Forms.TextBox();
            this.TxtbxSend = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtbxIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDC = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtbxRcv
            // 
            this.TxtbxRcv.Location = new System.Drawing.Point(22, 90);
            this.TxtbxRcv.Multiline = true;
            this.TxtbxRcv.Name = "TxtbxRcv";
            this.TxtbxRcv.ReadOnly = true;
            this.TxtbxRcv.Size = new System.Drawing.Size(266, 80);
            this.TxtbxRcv.TabIndex = 0;
            this.TxtbxRcv.TabStop = false;
            // 
            // TxtbxSend
            // 
            this.TxtbxSend.Location = new System.Drawing.Point(22, 180);
            this.TxtbxSend.Multiline = true;
            this.TxtbxSend.Name = "TxtbxSend";
            this.TxtbxSend.Size = new System.Drawing.Size(266, 80);
            this.TxtbxSend.TabIndex = 0;
            this.TxtbxSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbxSend_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(309, 127);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(115, 32);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSnd
            // 
            this.BtnSnd.Enabled = false;
            this.BtnSnd.Location = new System.Drawing.Point(309, 206);
            this.BtnSnd.Name = "BtnSnd";
            this.BtnSnd.Size = new System.Drawing.Size(115, 32);
            this.BtnSnd.TabIndex = 1;
            this.BtnSnd.Text = "&Send";
            this.BtnSnd.UseVisualStyleBackColor = true;
            this.BtnSnd.Click += new System.EventHandler(this.BtnSnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtbxIP);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.BtnDC);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To";
            // 
            // TxtbxIP
            // 
            this.TxtbxIP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbxIP.Location = new System.Drawing.Point(17, 24);
            this.TxtbxIP.Name = "TxtbxIP";
            this.TxtbxIP.Size = new System.Drawing.Size(98, 22);
            this.TxtbxIP.TabIndex = 2;
            this.TxtbxIP.Text = "127.0.0.1";
            this.TxtbxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(138, 21);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(90, 27);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "&Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDC
            // 
            this.BtnDC.Enabled = false;
            this.BtnDC.Location = new System.Drawing.Point(251, 21);
            this.BtnDC.Name = "BtnDC";
            this.BtnDC.Size = new System.Drawing.Size(90, 27);
            this.BtnDC.TabIndex = 1;
            this.BtnDC.Text = "&Disconect";
            this.BtnDC.UseVisualStyleBackColor = true;
            this.BtnDC.Click += new System.EventHandler(this.BtnDC_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnSnd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(451, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSnd);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtbxSend);
            this.Controls.Add(this.TxtbxRcv);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxRcv;
        private System.Windows.Forms.TextBox TxtbxSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtbxIP;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDC;
    }
}

