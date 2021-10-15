namespace ColorFinder
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AboutForm ) );
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkForum = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Black;
            this.txtInfo.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.txtInfo.ForeColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point( 12, 86 );
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size( 240, 139 );
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = resources.GetString( "txtInfo.Text" );
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point( 12, 9 );
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size( 204, 65 );
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "\r\n\r\nProgrammed by PC2st at\r\n\r\nPlease Observe the Rules of Copyright  :-]";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point( 229, 57 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 23, 23 );
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // lnkForum
            // 
            this.lnkForum.AutoSize = true;
            this.lnkForum.LinkColor = System.Drawing.Color.Blue;
            this.lnkForum.Location = new System.Drawing.Point( 134, 35 );
            this.lnkForum.Name = "lnkForum";
            this.lnkForum.Size = new System.Drawing.Size( 92, 13 );
            this.lnkForum.TabIndex = 3;
            this.lnkForum.TabStop = true;
            this.lnkForum.Text = "Barnamenevis.org";
            this.lnkForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.lnkForum_LinkClicked );
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 264, 237 );
            this.Controls.Add( this.lnkForum );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.lblAbout );
            this.Controls.Add( this.txtInfo );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Opacity = 0.9;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Color Finder";
            this.Shown += new System.EventHandler( this.AboutForm_Shown );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkForum;
    }
}