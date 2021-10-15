namespace GroupFileRenamer_2._
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstbFiles = new System.Windows.Forms.ListBox();
            this.cmbExtentions = new System.Windows.Forms.ComboBox();
            this.lblNumOfSelectedFiles = new System.Windows.Forms.Label();
            this.btnInvert = new System.Windows.Forms.Button();
            this.lblListOfExtentions = new System.Windows.Forms.Label();
            this.lblListOfFiles = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoToSourceFolder = new System.Windows.Forms.Button();
            this.btnGoToTargetFolder = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOpenReportFile = new System.Windows.Forms.Button();
            this.grbSource = new System.Windows.Forms.GroupBox();
            this.btnSource = new System.Windows.Forms.Button();
            this.grbTarget = new System.Windows.Forms.GroupBox();
            this.chbMakeNamesakeFolder = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbSameAsSource = new System.Windows.Forms.CheckBox();
            this.chbReadOnly = new System.Windows.Forms.CheckBox();
            this.chbHidden = new System.Windows.Forms.CheckBox();
            this.chbNormal = new System.Windows.Forms.CheckBox();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.txtNewExtention = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.rdbCopy = new System.Windows.Forms.RadioButton();
            this.rdbMove = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgbAllFilesInSource = new System.Windows.Forms.ProgressBar();
            this.pgbSelectedFilesInSource = new System.Windows.Forms.ProgressBar();
            this.lblAbout = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.grbSource.SuspendLayout();
            this.grbTarget.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(11, 32);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(179, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(9, 32);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(183, 20);
            this.txtTarget.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label10.Location = new System.Drawing.Point(6, 16);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(68, 13);
            this.Label10.TabIndex = 15;
            this.Label10.Text = "Target path :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(11, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Source path :";
            // 
            // lstbFiles
            // 
            this.lstbFiles.FormattingEnabled = true;
            this.lstbFiles.HorizontalScrollbar = true;
            this.lstbFiles.Location = new System.Drawing.Point(11, 77);
            this.lstbFiles.Name = "lstbFiles";
            this.lstbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbFiles.Size = new System.Drawing.Size(149, 186);
            this.lstbFiles.TabIndex = 10;
            this.lstbFiles.SelectedIndexChanged += new System.EventHandler(this.lstbFiles_SelectedIndexChanged);
            // 
            // cmbExtentions
            // 
            this.cmbExtentions.FormattingEnabled = true;
            this.cmbExtentions.Location = new System.Drawing.Point(169, 108);
            this.cmbExtentions.Name = "cmbExtentions";
            this.cmbExtentions.Size = new System.Drawing.Size(52, 21);
            this.cmbExtentions.TabIndex = 11;
            this.cmbExtentions.SelectedValueChanged += new System.EventHandler(this.cmbExtentions_SelectedValueChanged);
            // 
            // lblNumOfSelectedFiles
            // 
            this.lblNumOfSelectedFiles.AutoSize = true;
            this.lblNumOfSelectedFiles.Location = new System.Drawing.Point(37, 295);
            this.lblNumOfSelectedFiles.Name = "lblNumOfSelectedFiles";
            this.lblNumOfSelectedFiles.Size = new System.Drawing.Size(82, 13);
            this.lblNumOfSelectedFiles.TabIndex = 12;
            this.lblNumOfSelectedFiles.Text = "0  Selected files";
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(11, 270);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(149, 22);
            this.btnInvert.TabIndex = 14;
            this.btnInvert.Text = "Invert Selection items";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // lblListOfExtentions
            // 
            this.lblListOfExtentions.AutoSize = true;
            this.lblListOfExtentions.Location = new System.Drawing.Point(166, 78);
            this.lblListOfExtentions.Name = "lblListOfExtentions";
            this.lblListOfExtentions.Size = new System.Drawing.Size(55, 26);
            this.lblListOfExtentions.TabIndex = 15;
            this.lblListOfExtentions.Text = "List of\r\nextentions";
            this.toolTip1.SetToolTip(this.lblListOfExtentions, "Select an extention for select same files in listbox");
            // 
            // lblListOfFiles
            // 
            this.lblListOfFiles.AutoSize = true;
            this.lblListOfFiles.Location = new System.Drawing.Point(11, 61);
            this.lblListOfFiles.Name = "lblListOfFiles";
            this.lblListOfFiles.Size = new System.Drawing.Size(56, 13);
            this.lblListOfFiles.TabIndex = 15;
            this.lblListOfFiles.Text = "List of files";
            this.toolTip1.SetToolTip(this.lblListOfFiles, "You can select files from extention combobox\r\nor select manually with <Ctrl> or <" +
                    "Shift> buttons");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 150;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "New extention";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "New file name";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // btnGoToSourceFolder
            // 
            this.btnGoToSourceFolder.Location = new System.Drawing.Point(194, 287);
            this.btnGoToSourceFolder.Name = "btnGoToSourceFolder";
            this.btnGoToSourceFolder.Size = new System.Drawing.Size(27, 24);
            this.btnGoToSourceFolder.TabIndex = 16;
            this.btnGoToSourceFolder.Text = "...";
            this.toolTip1.SetToolTip(this.btnGoToSourceFolder, "Go directly to source folder");
            this.btnGoToSourceFolder.UseVisualStyleBackColor = true;
            this.btnGoToSourceFolder.Click += new System.EventHandler(this.btnGoToSourceFolder_Click);
            // 
            // btnGoToTargetFolder
            // 
            this.btnGoToTargetFolder.Location = new System.Drawing.Point(196, 287);
            this.btnGoToTargetFolder.Name = "btnGoToTargetFolder";
            this.btnGoToTargetFolder.Size = new System.Drawing.Size(27, 24);
            this.btnGoToTargetFolder.TabIndex = 16;
            this.btnGoToTargetFolder.Text = "...";
            this.toolTip1.SetToolTip(this.btnGoToTargetFolder, "Go directly to target folder");
            this.btnGoToTargetFolder.UseVisualStyleBackColor = true;
            this.btnGoToTargetFolder.Click += new System.EventHandler(this.btnGoToTargetFolder_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Location = new System.Drawing.Point(534, 326);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnAbout, "About");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnOpenReportFile
            // 
            this.btnOpenReportFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenReportFile.Image")));
            this.btnOpenReportFile.Location = new System.Drawing.Point(9, 294);
            this.btnOpenReportFile.Name = "btnOpenReportFile";
            this.btnOpenReportFile.Size = new System.Drawing.Size(20, 17);
            this.btnOpenReportFile.TabIndex = 18;
            this.btnOpenReportFile.Text = "...";
            this.toolTip1.SetToolTip(this.btnOpenReportFile, "Open Report file");
            this.btnOpenReportFile.UseVisualStyleBackColor = true;
            this.btnOpenReportFile.Click += new System.EventHandler(this.btnOpenReportFile_Click);
            // 
            // grbSource
            // 
            this.grbSource.Controls.Add(this.btnGoToSourceFolder);
            this.grbSource.Controls.Add(this.btnSource);
            this.grbSource.Controls.Add(this.lblListOfFiles);
            this.grbSource.Controls.Add(this.txtSource);
            this.grbSource.Controls.Add(this.lblListOfExtentions);
            this.grbSource.Controls.Add(this.Label1);
            this.grbSource.Controls.Add(this.btnInvert);
            this.grbSource.Controls.Add(this.lstbFiles);
            this.grbSource.Controls.Add(this.lblNumOfSelectedFiles);
            this.grbSource.Controls.Add(this.cmbExtentions);
            this.grbSource.Location = new System.Drawing.Point(5, 3);
            this.grbSource.Name = "grbSource";
            this.grbSource.Size = new System.Drawing.Size(229, 317);
            this.grbSource.TabIndex = 16;
            this.grbSource.TabStop = false;
            this.grbSource.Text = "SOURCE";
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSource.Image = ((System.Drawing.Image)(resources.GetObject("btnSource.Image")));
            this.btnSource.Location = new System.Drawing.Point(196, 29);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(25, 25);
            this.btnSource.TabIndex = 10;
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // grbTarget
            // 
            this.grbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTarget.Controls.Add(this.chbMakeNamesakeFolder);
            this.grbTarget.Controls.Add(this.btnOpenReportFile);
            this.grbTarget.Controls.Add(this.groupBox1);
            this.grbTarget.Controls.Add(this.btnGoToTargetFolder);
            this.grbTarget.Controls.Add(this.txtNewFileName);
            this.grbTarget.Controls.Add(this.txtNewExtention);
            this.grbTarget.Controls.Add(this.btnTarget);
            this.grbTarget.Controls.Add(this.Label10);
            this.grbTarget.Controls.Add(this.label3);
            this.grbTarget.Controls.Add(this.label2);
            this.grbTarget.Controls.Add(this.txtTarget);
            this.grbTarget.Location = new System.Drawing.Point(325, 3);
            this.grbTarget.Name = "grbTarget";
            this.grbTarget.Size = new System.Drawing.Size(232, 317);
            this.grbTarget.TabIndex = 17;
            this.grbTarget.TabStop = false;
            this.grbTarget.Text = "TARGET";
            // 
            // chbMakeNamesakeFolder
            // 
            this.chbMakeNamesakeFolder.AutoSize = true;
            this.chbMakeNamesakeFolder.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMakeNamesakeFolder.Location = new System.Drawing.Point(9, 143);
            this.chbMakeNamesakeFolder.Name = "chbMakeNamesakeFolder";
            this.chbMakeNamesakeFolder.Size = new System.Drawing.Size(210, 20);
            this.chbMakeNamesakeFolder.TabIndex = 19;
            this.chbMakeNamesakeFolder.Text = "Make namesake folder in target, for each file";
            this.chbMakeNamesakeFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbSameAsSource);
            this.groupBox1.Controls.Add(this.chbReadOnly);
            this.groupBox1.Controls.Add(this.chbHidden);
            this.groupBox1.Controls.Add(this.chbNormal);
            this.groupBox1.Location = new System.Drawing.Point(9, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attributes";
            // 
            // chbSameAsSource
            // 
            this.chbSameAsSource.AutoSize = true;
            this.chbSameAsSource.Checked = true;
            this.chbSameAsSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSameAsSource.Location = new System.Drawing.Point(10, 20);
            this.chbSameAsSource.Name = "chbSameAsSource";
            this.chbSameAsSource.Size = new System.Drawing.Size(118, 17);
            this.chbSameAsSource.TabIndex = 3;
            this.chbSameAsSource.Text = "Same as source file";
            this.chbSameAsSource.UseVisualStyleBackColor = true;
            this.chbSameAsSource.CheckedChanged += new System.EventHandler(this.chbSameAsSource_CheckedChanged);
            // 
            // chbReadOnly
            // 
            this.chbReadOnly.AutoSize = true;
            this.chbReadOnly.Enabled = false;
            this.chbReadOnly.Location = new System.Drawing.Point(10, 89);
            this.chbReadOnly.Name = "chbReadOnly";
            this.chbReadOnly.Size = new System.Drawing.Size(74, 17);
            this.chbReadOnly.TabIndex = 2;
            this.chbReadOnly.Text = "Read-only";
            this.chbReadOnly.UseVisualStyleBackColor = true;
            this.chbReadOnly.CheckedChanged += new System.EventHandler(this.chbReadOnly_CheckedChanged);
            // 
            // chbHidden
            // 
            this.chbHidden.AutoSize = true;
            this.chbHidden.Enabled = false;
            this.chbHidden.Location = new System.Drawing.Point(10, 66);
            this.chbHidden.Name = "chbHidden";
            this.chbHidden.Size = new System.Drawing.Size(60, 17);
            this.chbHidden.TabIndex = 1;
            this.chbHidden.Text = "Hidden";
            this.chbHidden.UseVisualStyleBackColor = true;
            this.chbHidden.CheckedChanged += new System.EventHandler(this.chbHidden_CheckedChanged);
            // 
            // chbNormal
            // 
            this.chbNormal.AutoSize = true;
            this.chbNormal.Enabled = false;
            this.chbNormal.Location = new System.Drawing.Point(10, 43);
            this.chbNormal.Name = "chbNormal";
            this.chbNormal.Size = new System.Drawing.Size(59, 17);
            this.chbNormal.TabIndex = 0;
            this.chbNormal.Text = "Normal";
            this.chbNormal.UseVisualStyleBackColor = true;
            this.chbNormal.CheckedChanged += new System.EventHandler(this.chbNormal_CheckedChanged);
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(86, 73);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.Size = new System.Drawing.Size(137, 20);
            this.txtNewFileName.TabIndex = 16;
            // 
            // txtNewExtention
            // 
            this.txtNewExtention.Location = new System.Drawing.Point(86, 102);
            this.txtNewExtention.Name = "txtNewExtention";
            this.txtNewExtention.Size = new System.Drawing.Size(69, 20);
            this.txtNewExtention.TabIndex = 16;
            // 
            // btnTarget
            // 
            this.btnTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTarget.Image = ((System.Drawing.Image)(resources.GetObject("btnTarget.Image")));
            this.btnTarget.Location = new System.Drawing.Point(198, 29);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(25, 25);
            this.btnTarget.TabIndex = 10;
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // rdbCopy
            // 
            this.rdbCopy.AutoSize = true;
            this.rdbCopy.Checked = true;
            this.rdbCopy.Location = new System.Drawing.Point(15, 12);
            this.rdbCopy.Name = "rdbCopy";
            this.rdbCopy.Size = new System.Drawing.Size(49, 17);
            this.rdbCopy.TabIndex = 0;
            this.rdbCopy.TabStop = true;
            this.rdbCopy.Text = "Copy";
            this.rdbCopy.UseVisualStyleBackColor = true;
            // 
            // rdbMove
            // 
            this.rdbMove.AutoSize = true;
            this.rdbMove.Location = new System.Drawing.Point(15, 35);
            this.rdbMove.Name = "rdbMove";
            this.rdbMove.Size = new System.Drawing.Size(52, 17);
            this.rdbMove.TabIndex = 0;
            this.rdbMove.Text = "Move";
            this.rdbMove.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMove);
            this.groupBox2.Controls.Add(this.rdbCopy);
            this.groupBox2.Location = new System.Drawing.Point(240, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 57);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // pgbAllFilesInSource
            // 
            this.pgbAllFilesInSource.Location = new System.Drawing.Point(5, 326);
            this.pgbAllFilesInSource.Name = "pgbAllFilesInSource";
            this.pgbAllFilesInSource.Size = new System.Drawing.Size(150, 10);
            this.pgbAllFilesInSource.TabIndex = 0;
            this.pgbAllFilesInSource.Visible = false;
            // 
            // pgbSelectedFilesInSource
            // 
            this.pgbSelectedFilesInSource.Location = new System.Drawing.Point(5, 338);
            this.pgbSelectedFilesInSource.Name = "pgbSelectedFilesInSource";
            this.pgbSelectedFilesInSource.Size = new System.Drawing.Size(150, 10);
            this.pgbSelectedFilesInSource.TabIndex = 0;
            this.pgbSelectedFilesInSource.Visible = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(15, 5);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(39, 13);
            this.lblAbout.TabIndex = 21;
            this.lblAbout.Text = "Label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Location = new System.Drawing.Point(325, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 21);
            this.panel1.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(240, 174);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 39);
            this.btnStart.TabIndex = 20;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.pgbSelectedFilesInSource);
            this.Controls.Add(this.pgbAllFilesInSource);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbTarget);
            this.Controls.Add(this.grbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group File Renamer 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSource.ResumeLayout(false);
            this.grbSource.PerformLayout();
            this.grbTarget.ResumeLayout(false);
            this.grbTarget.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.ListBox lstbFiles;
        private System.Windows.Forms.ComboBox cmbExtentions;
        private System.Windows.Forms.Label lblNumOfSelectedFiles;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Label lblListOfExtentions;
        private System.Windows.Forms.Label lblListOfFiles;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grbSource;
        private System.Windows.Forms.GroupBox grbTarget;
        private System.Windows.Forms.TextBox txtNewExtention;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMove;
        private System.Windows.Forms.RadioButton rdbCopy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGoToSourceFolder;
        private System.Windows.Forms.Button btnGoToTargetFolder;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbHidden;
        private System.Windows.Forms.CheckBox chbNormal;
        private System.Windows.Forms.CheckBox chbReadOnly;
        private System.Windows.Forms.CheckBox chbSameAsSource;
        private System.Windows.Forms.ProgressBar pgbSelectedFilesInSource;
        private System.Windows.Forms.ProgressBar pgbAllFilesInSource;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOpenReportFile;
        private System.Windows.Forms.CheckBox chbMakeNamesakeFolder;
    }
}

