namespace TestThreading
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
            this.grpShow = new System.Windows.Forms.GroupBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShow
            // 
            this.grpShow.BackColor = System.Drawing.Color.White;
            this.grpShow.Location = new System.Drawing.Point( 12, 12 );
            this.grpShow.Name = "grpShow";
            this.grpShow.Size = new System.Drawing.Size( 608, 333 );
            this.grpShow.TabIndex = 0;
            this.grpShow.TabStop = false;
            this.grpShow.Text = "نمایش تردها بصورت گرافیکی :";
            // 
            // grpActions
            // 
            this.grpActions.BackColor = System.Drawing.Color.White;
            this.grpActions.Controls.Add( this.btnContinue );
            this.grpActions.Controls.Add( this.btnStop );
            this.grpActions.Controls.Add( this.btnExit );
            this.grpActions.Controls.Add( this.btnAbout );
            this.grpActions.Controls.Add( this.btnStart );
            this.grpActions.Location = new System.Drawing.Point( 12, 351 );
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size( 608, 45 );
            this.grpActions.TabIndex = 1;
            this.grpActions.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point( 306, 14 );
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size( 70, 23 );
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "ادامه";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler( this.btnContinue_Click );
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point( 382, 14 );
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size( 70, 23 );
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler( this.btnStop_Click );
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point( 6, 14 );
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size( 70, 23 );
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler( this.btnExit_Click );
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point( 82, 14 );
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size( 70, 23 );
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "درباره...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler( this.btnAbout_Click );
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point( 458, 14 );
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size( 144, 23 );
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler( this.btnStart_Click );
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 632, 408 );
            this.Controls.Add( this.grpActions );
            this.Controls.Add( this.grpShow );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تست عملیات تردینگ";
            this.grpActions.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShow;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnContinue;

    }
}

