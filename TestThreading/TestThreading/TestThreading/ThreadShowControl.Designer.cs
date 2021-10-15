namespace TestThreading
{
    partial class ThreadShowControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSleep = new System.Windows.Forms.Label();
            this.nmrSleep = new System.Windows.Forms.NumericUpDown();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.picPaint = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmrSpeed = new System.Windows.Forms.Timer( this.components );
            ( ( System.ComponentModel.ISupportInitialize )( this.nmrSleep ) ).BeginInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.picPaint ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuspend
            // 
            this.btnSuspend.Enabled = false;
            this.btnSuspend.Location = new System.Drawing.Point( 3, 279 );
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size( 140, 23 );
            this.btnSuspend.TabIndex = 7;
            this.btnSuspend.Text = "تعلیق";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler( this.btnSuspend_Click );
            // 
            // lblPriority
            // 
            this.lblPriority.Location = new System.Drawing.Point( 91, 229 );
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size( 52, 14 );
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "اهمیت :";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSleep
            // 
            this.lblSleep.Location = new System.Drawing.Point( 69, 254 );
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size( 74, 14 );
            this.lblSleep.TabIndex = 5;
            this.lblSleep.Text = "مقدار خواب :";
            this.lblSleep.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nmrSleep
            // 
            this.nmrSleep.Location = new System.Drawing.Point( 3, 252 );
            this.nmrSleep.Maximum = new decimal( new int[] {
            20000,
            0,
            0,
            0} );
            this.nmrSleep.Name = "nmrSleep";
            this.nmrSleep.Size = new System.Drawing.Size( 60, 21 );
            this.nmrSleep.TabIndex = 6;
            this.nmrSleep.ValueChanged += new System.EventHandler( this.nmrSleep_ValueChanged );
            this.nmrSleep.KeyDown += new System.Windows.Forms.KeyEventHandler( this.nmrSleep_KeyDown );
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Items.AddRange( new object[] {
            "کمترین",
            "کمتر",
            "معمولی",
            "بیشتر",
            "بیشترین"} );
            this.cboPriority.Location = new System.Drawing.Point( 3, 226 );
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size( 82, 21 );
            this.cboPriority.TabIndex = 4;
            this.cboPriority.SelectedIndexChanged += new System.EventHandler( this.cboPriority_SelectedIndexChanged );
            // 
            // picPaint
            // 
            this.picPaint.BackColor = System.Drawing.Color.Black;
            this.picPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaint.Location = new System.Drawing.Point( 3, 3 );
            this.picPaint.Name = "picPaint";
            this.picPaint.Size = new System.Drawing.Size( 140, 140 );
            this.picPaint.TabIndex = 24;
            this.picPaint.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point( 65, 175 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 78, 14 );
            this.label1.TabIndex = 1;
            this.label1.Text = "زاویه چرخش :";
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point( 3, 172 );
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.ReadOnly = true;
            this.txtDegree.Size = new System.Drawing.Size( 56, 21 );
            this.txtDegree.TabIndex = 2;
            this.txtDegree.Text = "0";
            // 
            // chkClear
            // 
            this.chkClear.BackColor = System.Drawing.Color.Black;
            this.chkClear.Checked = true;
            this.chkClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClear.ForeColor = System.Drawing.Color.White;
            this.chkClear.Location = new System.Drawing.Point( 3, 148 );
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size( 140, 18 );
            this.chkClear.TabIndex = 0;
            this.chkClear.Text = "پاک کردن قبل از رسم";
            this.chkClear.UseVisualStyleBackColor = false;
            this.chkClear.CheckedChanged += new System.EventHandler( this.chkClear_CheckedChanged );
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point( 3, 199 );
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size( 78, 21 );
            this.txtSpeed.TabIndex = 26;
            this.txtSpeed.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Location = new System.Drawing.Point( 87, 202 );
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size( 56, 14 );
            this.lblSpeed.TabIndex = 25;
            this.lblSpeed.Text = "سرعت :";
            // 
            // tmrSpeed
            // 
            this.tmrSpeed.Interval = 500;
            this.tmrSpeed.Tick += new System.EventHandler( this.tmrSpeed_Tick );
            // 
            // ThreadShowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.txtSpeed );
            this.Controls.Add( this.lblSpeed );
            this.Controls.Add( this.chkClear );
            this.Controls.Add( this.txtDegree );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btnSuspend );
            this.Controls.Add( this.lblPriority );
            this.Controls.Add( this.lblSleep );
            this.Controls.Add( this.nmrSleep );
            this.Controls.Add( this.cboPriority );
            this.Controls.Add( this.picPaint );
            this.Font = new System.Drawing.Font( "Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 178 ) ) );
            this.Name = "ThreadShowControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size( 146, 305 );
            ( ( System.ComponentModel.ISupportInitialize )( this.nmrSleep ) ).EndInit();
            ( ( System.ComponentModel.ISupportInitialize )( this.picPaint ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.NumericUpDown nmrSleep;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.PictureBox picPaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tmrSpeed;
    }
}
