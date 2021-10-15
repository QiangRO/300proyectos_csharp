namespace Server
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtbxSnd = new System.Windows.Forms.TextBox();
            this.TxtbxRcv = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statubar = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnSnd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtbxSnd
            // 
            this.TxtbxSnd.Location = new System.Drawing.Point(12, 125);
            this.TxtbxSnd.Multiline = true;
            this.TxtbxSnd.Name = "TxtbxSnd";
            this.TxtbxSnd.Size = new System.Drawing.Size(259, 79);
            this.TxtbxSnd.TabIndex = 0;
            this.TxtbxSnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtbxSnd_KeyUp);
            // 
            // TxtbxRcv
            // 
            this.TxtbxRcv.Location = new System.Drawing.Point(12, 12);
            this.TxtbxRcv.Multiline = true;
            this.TxtbxRcv.Name = "TxtbxRcv";
            this.TxtbxRcv.ReadOnly = true;
            this.TxtbxRcv.Size = new System.Drawing.Size(259, 79);
            this.TxtbxRcv.TabIndex = 0;
            this.TxtbxRcv.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statubar,
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(439, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statubar
            // 
            this.statubar.Name = "statubar";
            this.statubar.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BtnSnd
            // 
            this.BtnSnd.Enabled = false;
            this.BtnSnd.Location = new System.Drawing.Point(15, 130);
            this.BtnSnd.Name = "BtnSnd";
            this.BtnSnd.Size = new System.Drawing.Size(111, 32);
            this.BtnSnd.TabIndex = 1;
            this.BtnSnd.Text = "&Send";
            this.BtnSnd.UseVisualStyleBackColor = true;
            this.BtnSnd.Click += new System.EventHandler(this.BtnSnd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(15, 22);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(111, 32);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnSnd);
            this.panel1.Location = new System.Drawing.Point(285, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 184);
            this.panel1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnSnd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(439, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtbxRcv);
            this.Controls.Add(this.TxtbxSnd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxSnd;
        private System.Windows.Forms.TextBox TxtbxRcv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statubar;
        private System.Windows.Forms.Button BtnSnd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

