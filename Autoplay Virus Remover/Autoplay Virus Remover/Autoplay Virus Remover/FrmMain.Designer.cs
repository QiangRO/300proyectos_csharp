namespace Autoplay_Virus_Remover
{
    partial class frmmain
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

            // ------------------------------------
            // DeviceVolumeMonitor dispose instance
            // ------------------------------------
            if (fNative != null)
            {
                fNative.Dispose();
                fNative = null;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Computer");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.btnstart = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuopen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnupreviousresults = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuautoprotect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuvirusManager = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuabout = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.optquickscan = new System.Windows.Forms.RadioButton();
            this.optdeepscan = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(339, 325);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Scan";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(25, 37);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "My Computer";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(389, 277);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "my computer.png");
            this.imageList1.Images.SetKeyName(1, "floppy copy.png");
            this.imageList1.Images.SetKeyName(2, "disk copy.png");
            this.imageList1.Images.SetKeyName(3, "dvd copy.png");
            this.imageList1.Images.SetKeyName(4, "removable copy.png");
            this.imageList1.Images.SetKeyName(5, "My Simple Antivirus.ico");
            this.imageList1.Images.SetKeyName(6, "My Simple Antivirus2.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Your Drives And Click On Scan";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "My Simple AntiVirus";
            this.notifyIcon1.BalloonTipTitle = "My Simple AntiVirus";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "My Simple AntiVirus";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuopen,
            this.cmnupreviousresults,
            this.cmnuautoprotect,
            this.cmnuvirusManager,
            this.cmnuabout,
            this.cmnuexit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 158);
            this.contextMenuStrip1.Text = "My Simple Antivirus";
            // 
            // cmnuopen
            // 
            this.cmnuopen.Name = "cmnuopen";
            this.cmnuopen.Size = new System.Drawing.Size(216, 22);
            this.cmnuopen.Text = "Open My Simple Antivirus";
            this.cmnuopen.Click += new System.EventHandler(this.cmnuopen_Click);
            // 
            // cmnupreviousresults
            // 
            this.cmnupreviousresults.Name = "cmnupreviousresults";
            this.cmnupreviousresults.Size = new System.Drawing.Size(216, 22);
            this.cmnupreviousresults.Text = "Previous Scan Results";
            this.cmnupreviousresults.Click += new System.EventHandler(this.cmnupreviousresults_Click);
            // 
            // cmnuautoprotect
            // 
            this.cmnuautoprotect.Checked = true;
            this.cmnuautoprotect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmnuautoprotect.Name = "cmnuautoprotect";
            this.cmnuautoprotect.Size = new System.Drawing.Size(216, 22);
            this.cmnuautoprotect.Text = "Enable Auto-Protect";
            this.cmnuautoprotect.Click += new System.EventHandler(this.cmnuautoprotect_Click);
            // 
            // cmnuvirusManager
            // 
            this.cmnuvirusManager.Name = "cmnuvirusManager";
            this.cmnuvirusManager.Size = new System.Drawing.Size(216, 22);
            this.cmnuvirusManager.Text = "Virus Manager";
            this.cmnuvirusManager.Click += new System.EventHandler(this.cmnuvirusManager_Click);
            // 
            // cmnuabout
            // 
            this.cmnuabout.Name = "cmnuabout";
            this.cmnuabout.Size = new System.Drawing.Size(216, 22);
            this.cmnuabout.Text = "About My Simple Antivirus";
            this.cmnuabout.Click += new System.EventHandler(this.cmnuabout_Click);
            // 
            // cmnuexit
            // 
            this.cmnuexit.Name = "cmnuexit";
            this.cmnuexit.Size = new System.Drawing.Size(216, 22);
            this.cmnuexit.Text = "Exit";
            this.cmnuexit.Click += new System.EventHandler(this.cmnuexit_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(216, 325);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(117, 23);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "Refresh Drives";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // optquickscan
            // 
            this.optquickscan.AutoSize = true;
            this.optquickscan.Checked = true;
            this.optquickscan.Location = new System.Drawing.Point(25, 325);
            this.optquickscan.Name = "optquickscan";
            this.optquickscan.Size = new System.Drawing.Size(81, 17);
            this.optquickscan.TabIndex = 7;
            this.optquickscan.TabStop = true;
            this.optquickscan.Text = "Quick Scan";
            this.optquickscan.UseVisualStyleBackColor = true;
            // 
            // optdeepscan
            // 
            this.optdeepscan.AutoSize = true;
            this.optdeepscan.Location = new System.Drawing.Point(116, 325);
            this.optdeepscan.Name = "optdeepscan";
            this.optdeepscan.Size = new System.Drawing.Size(79, 17);
            this.optdeepscan.TabIndex = 8;
            this.optdeepscan.Text = "Deep Scan";
            this.optdeepscan.UseVisualStyleBackColor = true;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 360);
            this.Controls.Add(this.optdeepscan);
            this.Controls.Add(this.optquickscan);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 275);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Simple AntiVirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.frmmain_SizeChanged);
            this.Shown += new System.EventHandler(this.frmmain_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnuopen;
        private System.Windows.Forms.ToolStripMenuItem cmnuautoprotect;
        private System.Windows.Forms.ToolStripMenuItem cmnuexit;
        private System.Windows.Forms.ToolStripMenuItem cmnuabout;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.RadioButton optquickscan;
        private System.Windows.Forms.RadioButton optdeepscan;
        private System.Windows.Forms.ToolStripMenuItem cmnupreviousresults;
        private System.Windows.Forms.ToolStripMenuItem cmnuvirusManager;
    }
}

