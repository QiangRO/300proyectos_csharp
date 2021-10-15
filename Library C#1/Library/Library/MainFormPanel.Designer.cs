namespace Library
{
    partial class MainFormPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainFormPanelstatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.MainFormPanelstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.MainFormPanelstatusStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 834);
            this.panel1.TabIndex = 0;
            // 
            // MainFormPanelstatusStrip
            // 
            this.MainFormPanelstatusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainFormPanelstatusStrip.BackgroundImage")));
            this.MainFormPanelstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.MainFormPanelstatusStrip.Location = new System.Drawing.Point(0, 812);
            this.MainFormPanelstatusStrip.Name = "MainFormPanelstatusStrip";
            this.MainFormPanelstatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainFormPanelstatusStrip.Size = new System.Drawing.Size(1424, 22);
            this.MainFormPanelstatusStrip.TabIndex = 0;
            this.MainFormPanelstatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainFormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 834);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormPanel";
            this.Text = "MainFormPanel";
            this.Load += new System.EventHandler(this.MainFormPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainFormPanelstatusStrip.ResumeLayout(false);
            this.MainFormPanelstatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.StatusStrip MainFormPanelstatusStrip;

    }
}