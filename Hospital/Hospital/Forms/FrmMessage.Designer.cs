namespace Membership.Forms
{
    partial class FrmMessage
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
            this.label16 = new System.Windows.Forms.Label();
            this.tbOtherinfo = new System.Windows.Forms.TextBox();
            this.lblMemberid = new System.Windows.Forms.Label();
            this.tbMemberid = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbtIndividual = new System.Windows.Forms.RadioButton();
            this.rbtAll = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 31);
            this.label1.TabIndex = 134;
            this.label1.Text = "  Print Message ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(12, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 151;
            this.label16.Text = "Message";
            // 
            // tbOtherinfo
            // 
            this.tbOtherinfo.Location = new System.Drawing.Point(11, 136);
            this.tbOtherinfo.Multiline = true;
            this.tbOtherinfo.Name = "tbOtherinfo";
            this.tbOtherinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOtherinfo.Size = new System.Drawing.Size(532, 179);
            this.tbOtherinfo.TabIndex = 150;
            // 
            // lblMemberid
            // 
            this.lblMemberid.AutoSize = true;
            this.lblMemberid.ForeColor = System.Drawing.Color.Navy;
            this.lblMemberid.Location = new System.Drawing.Point(12, 93);
            this.lblMemberid.Name = "lblMemberid";
            this.lblMemberid.Size = new System.Drawing.Size(59, 13);
            this.lblMemberid.TabIndex = 153;
            this.lblMemberid.Text = "Member ID";
            // 
            // tbMemberid
            // 
            this.tbMemberid.ForeColor = System.Drawing.Color.Navy;
            this.tbMemberid.Location = new System.Drawing.Point(88, 93);
            this.tbMemberid.Name = "tbMemberid";
            this.tbMemberid.Size = new System.Drawing.Size(131, 20);
            this.tbMemberid.TabIndex = 152;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.Location = new System.Drawing.Point(12, 47);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 13);
            this.lblMessage.TabIndex = 154;
            this.lblMessage.Text = "Message for";
            // 
            // rbtIndividual
            // 
            this.rbtIndividual.AutoSize = true;
            this.rbtIndividual.ForeColor = System.Drawing.Color.Navy;
            this.rbtIndividual.Location = new System.Drawing.Point(88, 63);
            this.rbtIndividual.Name = "rbtIndividual";
            this.rbtIndividual.Size = new System.Drawing.Size(70, 17);
            this.rbtIndividual.TabIndex = 155;
            this.rbtIndividual.TabStop = true;
            this.rbtIndividual.Text = "Individual";
            this.rbtIndividual.UseVisualStyleBackColor = true;
            // 
            // rbtAll
            // 
            this.rbtAll.AutoSize = true;
            this.rbtAll.ForeColor = System.Drawing.Color.Navy;
            this.rbtAll.Location = new System.Drawing.Point(183, 63);
            this.rbtAll.Name = "rbtAll";
            this.rbtAll.Size = new System.Drawing.Size(36, 17);
            this.rbtAll.TabIndex = 156;
            this.rbtAll.TabStop = true;
            this.rbtAll.Text = "All";
            this.rbtAll.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(158, 321);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 157;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(240, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 158;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 159;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbtAll);
            this.Controls.Add(this.rbtIndividual);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblMemberid);
            this.Controls.Add(this.tbMemberid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbOtherinfo);
            this.Controls.Add(this.label1);
            this.Name = "FrmMessage";
            this.Text = "Print Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox tbOtherinfo;
        private System.Windows.Forms.Label lblMemberid;
        public System.Windows.Forms.TextBox tbMemberid;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rbtIndividual;
        private System.Windows.Forms.RadioButton rbtAll;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}