namespace ColorFinder
{
    partial class MainForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.clrdlgSelect = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.lblMessage.Location = new System.Drawing.Point( 10, 8 );
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size( 272, 19 );
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "هم اکنون هیچ رنگی انتخاب نشده است.";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightYellow;
            this.btnSelect.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.btnSelect.Location = new System.Drawing.Point( 10, 30 );
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSelect.Size = new System.Drawing.Size( 180, 54 );
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "از اینجا یک رنگ انتخاب کنید ...";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler( this.btnSelect_Click );
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point( 195, 59 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 87, 24 );
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point( 195, 30 );
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size( 87, 24 );
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler( this.btnAbout_Click );
            // 
            // clrdlgSelect
            // 
            this.clrdlgSelect.Color = System.Drawing.Color.Blue;
            this.clrdlgSelect.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 292, 95 );
            this.Controls.Add( this.btnAbout );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.btnSelect );
            this.Controls.Add( this.lblMessage );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.9;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Finder";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ColorDialog clrdlgSelect;
    }
}

