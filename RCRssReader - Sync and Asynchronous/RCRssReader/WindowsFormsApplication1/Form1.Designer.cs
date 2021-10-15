namespace WindowsFormsApplication1
{
    partial class FrmTestRssReader
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
            this.btnGetRssAsync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxChannelInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChannelPubDate = new System.Windows.Forms.TextBox();
            this.txtChannelDescription = new System.Windows.Forms.TextBox();
            this.txtChannelLink = new System.Windows.Forms.TextBox();
            this.txtChannelTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgRssItems = new System.Windows.Forms.DataGridView();
            this.txtRssUrl = new System.Windows.Forms.TextBox();
            this.btnGetRssSync = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAsyncWorking = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRssItemCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.gboxChannelInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRssItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAsyncWorking)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetRssAsync
            // 
            this.btnGetRssAsync.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGetRssAsync.Location = new System.Drawing.Point(9, 25);
            this.btnGetRssAsync.Name = "btnGetRssAsync";
            this.btnGetRssAsync.Size = new System.Drawing.Size(109, 23);
            this.btnGetRssAsync.TabIndex = 1;
            this.btnGetRssAsync.Text = "Get RSS <Async>";
            this.btnGetRssAsync.UseVisualStyleBackColor = false;
            this.btnGetRssAsync.Click += new System.EventHandler(this.btnGetRssAsync_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "PubDate :";
            // 
            // gboxChannelInfo
            // 
            this.gboxChannelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxChannelInfo.Controls.Add(this.label2);
            this.gboxChannelInfo.Controls.Add(this.label4);
            this.gboxChannelInfo.Controls.Add(this.label3);
            this.gboxChannelInfo.Controls.Add(this.label1);
            this.gboxChannelInfo.Controls.Add(this.txtChannelPubDate);
            this.gboxChannelInfo.Controls.Add(this.txtChannelDescription);
            this.gboxChannelInfo.Controls.Add(this.txtChannelLink);
            this.gboxChannelInfo.Controls.Add(this.txtChannelTitle);
            this.gboxChannelInfo.Location = new System.Drawing.Point(6, 80);
            this.gboxChannelInfo.Name = "gboxChannelInfo";
            this.gboxChannelInfo.Size = new System.Drawing.Size(638, 91);
            this.gboxChannelInfo.TabIndex = 9;
            this.gboxChannelInfo.TabStop = false;
            this.gboxChannelInfo.Text = "Channel info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Link : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title : ";
            // 
            // txtChannelPubDate
            // 
            this.txtChannelPubDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannelPubDate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChannelPubDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelPubDate.ForeColor = System.Drawing.Color.Navy;
            this.txtChannelPubDate.Location = new System.Drawing.Point(454, 18);
            this.txtChannelPubDate.Name = "txtChannelPubDate";
            this.txtChannelPubDate.ReadOnly = true;
            this.txtChannelPubDate.Size = new System.Drawing.Size(178, 20);
            this.txtChannelPubDate.TabIndex = 1;
            // 
            // txtChannelDescription
            // 
            this.txtChannelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannelDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChannelDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelDescription.ForeColor = System.Drawing.Color.Navy;
            this.txtChannelDescription.Location = new System.Drawing.Point(78, 60);
            this.txtChannelDescription.Multiline = true;
            this.txtChannelDescription.Name = "txtChannelDescription";
            this.txtChannelDescription.ReadOnly = true;
            this.txtChannelDescription.Size = new System.Drawing.Size(554, 25);
            this.txtChannelDescription.TabIndex = 3;
            // 
            // txtChannelLink
            // 
            this.txtChannelLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChannelLink.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChannelLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelLink.ForeColor = System.Drawing.Color.Navy;
            this.txtChannelLink.Location = new System.Drawing.Point(78, 39);
            this.txtChannelLink.Name = "txtChannelLink";
            this.txtChannelLink.ReadOnly = true;
            this.txtChannelLink.Size = new System.Drawing.Size(554, 20);
            this.txtChannelLink.TabIndex = 2;
            // 
            // txtChannelTitle
            // 
            this.txtChannelTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtChannelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelTitle.ForeColor = System.Drawing.Color.Navy;
            this.txtChannelTitle.Location = new System.Drawing.Point(78, 18);
            this.txtChannelTitle.Name = "txtChannelTitle";
            this.txtChannelTitle.ReadOnly = true;
            this.txtChannelTitle.Size = new System.Drawing.Size(247, 20);
            this.txtChannelTitle.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgRssItems);
            this.groupBox1.Location = new System.Drawing.Point(3, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 360);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Headlines";
            // 
            // dgRssItems
            // 
            this.dgRssItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRssItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRssItems.Location = new System.Drawing.Point(3, 16);
            this.dgRssItems.Name = "dgRssItems";
            this.dgRssItems.Size = new System.Drawing.Size(638, 341);
            this.dgRssItems.TabIndex = 0;
            // 
            // txtRssUrl
            // 
            this.txtRssUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRssUrl.Location = new System.Drawing.Point(124, 17);
            this.txtRssUrl.Name = "txtRssUrl";
            this.txtRssUrl.Size = new System.Drawing.Size(356, 20);
            this.txtRssUrl.TabIndex = 0;
            this.txtRssUrl.Text = "http://www.microsoft.com/feeds/msdn/en-us/rss.xml";
            // 
            // btnGetRssSync
            // 
            this.btnGetRssSync.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetRssSync.Location = new System.Drawing.Point(9, 2);
            this.btnGetRssSync.Name = "btnGetRssSync";
            this.btnGetRssSync.Size = new System.Drawing.Size(109, 23);
            this.btnGetRssSync.TabIndex = 1;
            this.btnGetRssSync.Text = "Get RSS <Sync>";
            this.btnGetRssSync.UseVisualStyleBackColor = false;
            this.btnGetRssSync.Click += new System.EventHandler(this.btnGetRssSync_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.picAsyncWorking);
            this.panel1.Controls.Add(this.btnGetRssAsync);
            this.panel1.Controls.Add(this.btnGetRssSync);
            this.panel1.Controls.Add(this.txtRssUrl);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 51);
            this.panel1.TabIndex = 8;
            // 
            // picAsyncWorking
            // 
            this.picAsyncWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAsyncWorking.BackColor = System.Drawing.Color.Transparent;
            this.picAsyncWorking.Image = global::WindowsFormsApplication1.Properties.Resources.loading2;
            this.picAsyncWorking.Location = new System.Drawing.Point(486, 3);
            this.picAsyncWorking.Name = "picAsyncWorking";
            this.picAsyncWorking.Size = new System.Drawing.Size(146, 46);
            this.picAsyncWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAsyncWorking.TabIndex = 2;
            this.picAsyncWorking.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRssItemCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(650, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRssItemCount
            // 
            this.lblRssItemCount.Name = "lblRssItemCount";
            this.lblRssItemCount.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmTestRssReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gboxChannelInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTestRssReader";
            this.Text = "Rss Reader (Synchronous + Asynchronous) by  :::RED-C0DE:::";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboxChannelInfo.ResumeLayout(false);
            this.gboxChannelInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRssItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAsyncWorking)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetRssAsync;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxChannelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannelPubDate;
        private System.Windows.Forms.TextBox txtChannelDescription;
        private System.Windows.Forms.TextBox txtChannelLink;
        private System.Windows.Forms.TextBox txtChannelTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgRssItems;
        private System.Windows.Forms.TextBox txtRssUrl;
        private System.Windows.Forms.Button btnGetRssSync;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAsyncWorking;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRssItemCount;

    }
}

