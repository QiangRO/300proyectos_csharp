namespace Hello_World
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
            this.drawboard = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawboard)).BeginInit();
            this.SuspendLayout();
            // 
            // drawboard
            // 
            this.drawboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drawboard.BackColor = System.Drawing.Color.Black;
            this.drawboard.BackgroundImage = global::Hello_World.Properties.Resources.Ball;
            this.drawboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.drawboard.ImageLocation = "";
            this.drawboard.Location = new System.Drawing.Point(13, 13);
            this.drawboard.Name = "drawboard";
            this.drawboard.Size = new System.Drawing.Size(267, 223);
            this.drawboard.TabIndex = 0;
            this.drawboard.TabStop = false;
            this.drawboard.MouseLeave += new System.EventHandler(this.drawboard_MouseLeave);
            this.drawboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawboard_MouseMove);
            this.drawboard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawboard_Paint);
            this.drawboard.MouseEnter += new System.EventHandler(this.drawboard_MouseEnter);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ahmadreza_hadidi2020@yahoo.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawboard);
            this.Name = "MainForm";
            this.Text = "Hello World!";
            ((System.ComponentModel.ISupportInitialize)(this.drawboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawboard;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
    }
}

