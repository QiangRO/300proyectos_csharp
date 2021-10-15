namespace DraggableForm
{
    partial class FrmPatientHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientHome));
            this.lvMembers = new System.Windows.Forms.ListView();
            this.chmemberid = new System.Windows.Forms.ColumnHeader();
            this.chmname = new System.Windows.Forms.ColumnHeader();
            this.chaddress = new System.Windows.Forms.ColumnHeader();
            this.chmobileno = new System.Windows.Forms.ColumnHeader();
            this.chemailid = new System.Windows.Forms.ColumnHeader();
            this.chmamount = new System.Windows.Forms.ColumnHeader();
            this.chdiscount = new System.Windows.Forms.ColumnHeader();
            this.chtamount = new System.Windows.Forms.ColumnHeader();
            this.chreceivedby = new System.Windows.Forms.ColumnHeader();
            this.chfduration = new System.Windows.Forms.ColumnHeader();
            this.chtduration = new System.Windows.Forms.ColumnHeader();
            this.chOtherinfo = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumberComputers = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefreshComputer = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnFindComputer = new System.Windows.Forms.Button();
            this.btnModifyMember = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMembers
            // 
            this.lvMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chmemberid,
            this.chmname,
            this.chaddress,
            this.chmobileno,
            this.chemailid,
            this.chmamount,
            this.chdiscount,
            this.chtamount,
            this.chreceivedby,
            this.chfduration,
            this.chtduration,
            this.chOtherinfo});
            this.lvMembers.FullRowSelect = true;
            this.lvMembers.GridLines = true;
            this.lvMembers.Location = new System.Drawing.Point(70, 0);
            this.lvMembers.MultiSelect = false;
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(867, 382);
            this.lvMembers.TabIndex = 6;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            // 
            // chmemberid
            // 
            this.chmemberid.Text = "Memberid";
            this.chmemberid.Width = 68;
            // 
            // chmname
            // 
            this.chmname.Text = "Name";
            // 
            // chaddress
            // 
            this.chaddress.Text = "Address";
            this.chaddress.Width = 126;
            // 
            // chmobileno
            // 
            this.chmobileno.Text = "Mobileno";
            // 
            // chemailid
            // 
            this.chemailid.Text = "Email Id";
            // 
            // chmamount
            // 
            this.chmamount.Text = "Amount";
            // 
            // chdiscount
            // 
            this.chdiscount.Text = "Discount";
            // 
            // chtamount
            // 
            this.chtamount.Text = "Total";
            // 
            // chreceivedby
            // 
            this.chreceivedby.Text = "Receivedby";
            // 
            // chfduration
            // 
            this.chfduration.Text = "From";
            // 
            // chtduration
            // 
            this.chtduration.Text = "To";
            // 
            // chOtherinfo
            // 
            this.chOtherinfo.Text = "Other Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNumberComputers);
            this.panel2.Controls.Add(this.lblTotalMembers);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnRefreshComputer);
            this.panel2.Controls.Add(this.btnDeleteMember);
            this.panel2.Controls.Add(this.btnFindComputer);
            this.panel2.Controls.Add(this.btnModifyMember);
            this.panel2.Controls.Add(this.btnAddPatient);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 403);
            this.panel2.TabIndex = 7;
            // 
            // lblNumberComputers
            // 
            this.lblNumberComputers.BackColor = System.Drawing.Color.AliceBlue;
            this.lblNumberComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberComputers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumberComputers.Location = new System.Drawing.Point(1, 349);
            this.lblNumberComputers.Name = "lblNumberComputers";
            this.lblNumberComputers.Size = new System.Drawing.Size(67, 32);
            this.lblNumberComputers.TabIndex = 14;
            this.lblNumberComputers.Text = "Number of entries:";
            this.lblNumberComputers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotalMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalMembers.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMembers.Location = new System.Drawing.Point(-1, 383);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(68, 16);
            this.lblTotalMembers.TabIndex = 13;
            this.lblTotalMembers.Text = "0";
            this.lblTotalMembers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Refresh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Delete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Find";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Modify";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Add new";
            // 
            // btnRefreshComputer
            // 
            this.btnRefreshComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshComputer.Image")));
            this.btnRefreshComputer.Location = new System.Drawing.Point(10, 253);
            this.btnRefreshComputer.Name = "btnRefreshComputer";
            this.btnRefreshComputer.Size = new System.Drawing.Size(47, 40);
            this.btnRefreshComputer.TabIndex = 4;
            this.btnRefreshComputer.UseVisualStyleBackColor = true;
            this.btnRefreshComputer.Click += new System.EventHandler(this.btnRefreshComputer_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMember.Image")));
            this.btnDeleteMember.Location = new System.Drawing.Point(10, 193);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(47, 40);
            this.btnDeleteMember.TabIndex = 3;
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnFindComputer
            // 
            this.btnFindComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindComputer.Image")));
            this.btnFindComputer.Location = new System.Drawing.Point(10, 133);
            this.btnFindComputer.Name = "btnFindComputer";
            this.btnFindComputer.Size = new System.Drawing.Size(47, 40);
            this.btnFindComputer.TabIndex = 2;
            this.btnFindComputer.UseVisualStyleBackColor = true;
            this.btnFindComputer.Click += new System.EventHandler(this.btnFindComputer_Click);
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMember.Image")));
            this.btnModifyMember.Location = new System.Drawing.Point(10, 72);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(47, 40);
            this.btnModifyMember.TabIndex = 1;
            this.btnModifyMember.UseVisualStyleBackColor = true;
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.Image")));
            this.btnAddPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPatient.Location = new System.Drawing.Point(10, 12);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(47, 40);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "0";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.StatusLabel1.Text = "Hospital Management";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(81, 17);
            this.StatusLabel2.Text = "StatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPatientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 424);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvMembers);
            this.Name = "FrmPatientHome";
            this.Text = "Members Information";
            this.Load += new System.EventHandler(this.FrmPatientHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumberComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnFindComputer;
        private System.Windows.Forms.Button btnModifyMember;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.ColumnHeader chmemberid;
        private System.Windows.Forms.ColumnHeader chmname;
        private System.Windows.Forms.ColumnHeader chmobileno;
        private System.Windows.Forms.ColumnHeader chemailid;
        private System.Windows.Forms.ColumnHeader chmamount;
        private System.Windows.Forms.ColumnHeader chdiscount;
        private System.Windows.Forms.ColumnHeader chtamount;
        private System.Windows.Forms.ColumnHeader chreceivedby;
        private System.Windows.Forms.ColumnHeader chfduration;
        private System.Windows.Forms.ColumnHeader chtduration;
        private System.Windows.Forms.ColumnHeader chaddress;
        private System.Windows.Forms.ColumnHeader chOtherinfo;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ListView lvMembers;
        public System.Windows.Forms.Label lblTotalMembers;
        public System.Windows.Forms.Button btnRefreshComputer;
    }
}