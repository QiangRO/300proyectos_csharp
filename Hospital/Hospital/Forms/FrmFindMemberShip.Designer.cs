namespace DraggableForm
{
    partial class FrmFindMemberShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindMemberShip));
            this.lblMemberid = new System.Windows.Forms.Label();
            this.btnCancelFindMember = new System.Windows.Forms.Button();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.txtFindNameOfMember = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberid
            // 
            this.lblMemberid.Location = new System.Drawing.Point(5, 73);
            this.lblMemberid.Name = "lblMemberid";
            this.lblMemberid.Size = new System.Drawing.Size(128, 16);
            this.lblMemberid.TabIndex = 22;
            this.lblMemberid.Text = "Enter Member ID:";
            // 
            // btnCancelFindMember
            // 
            this.btnCancelFindMember.Location = new System.Drawing.Point(323, 37);
            this.btnCancelFindMember.Name = "btnCancelFindMember";
            this.btnCancelFindMember.Size = new System.Drawing.Size(80, 23);
            this.btnCancelFindMember.TabIndex = 21;
            this.btnCancelFindMember.Text = "&Cancel";
            this.btnCancelFindMember.Click += new System.EventHandler(this.btnCancelFindMember_Click);
            // 
            // btnFindMember
            // 
            this.btnFindMember.Location = new System.Drawing.Point(323, 9);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(80, 23);
            this.btnFindMember.TabIndex = 20;
            this.btnFindMember.Text = "F&ind";
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // txtFindNameOfMember
            // 
            this.txtFindNameOfMember.Location = new System.Drawing.Point(5, 89);
            this.txtFindNameOfMember.Name = "txtFindNameOfMember";
            this.txtFindNameOfMember.Size = new System.Drawing.Size(400, 20);
            this.txtFindNameOfMember.TabIndex = 19;
            this.txtFindNameOfMember.TextChanged += new System.EventHandler(this.txtFindNameOfMember_TextChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(9, 9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(40, 40);
            this.picLogo.TabIndex = 18;
            this.picLogo.TabStop = false;
            // 
            // FrmFindMemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 119);
            this.Controls.Add(this.lblMemberid);
            this.Controls.Add(this.btnCancelFindMember);
            this.Controls.Add(this.btnFindMember);
            this.Controls.Add(this.txtFindNameOfMember);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmFindMemberShip";
            this.Text = "Find Member";
            this.Load += new System.EventHandler(this.FrmFindMemberShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberid;
        private System.Windows.Forms.Button btnCancelFindMember;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.TextBox txtFindNameOfMember;
        private System.Windows.Forms.PictureBox picLogo;
    }
}