namespace SteganoZip
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
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txtZipFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOpenZipFile = new System.Windows.Forms.Button();
			this.grpContent = new System.Windows.Forms.GroupBox();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnExtract = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lvAll = new System.Windows.Forms.ListView();
			this.colFileName = new System.Windows.Forms.ColumnHeader();
			this.colCompressedSize = new System.Windows.Forms.ColumnHeader();
			this.lvVisible = new System.Windows.Forms.ListView();
			this.colVisibleFileName = new System.Windows.Forms.ColumnHeader();
			this.colVisibleCompressedSize = new System.Windows.Forms.ColumnHeader();
			this.btnSelectNewFile = new System.Windows.Forms.Button();
			this.txtNewFileName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chkAddVisible = new System.Windows.Forms.CheckBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.grpAdd = new System.Windows.Forms.GroupBox();
			this.txtSavePassword = new System.Windows.Forms.TextBox();
			this.chkEncrypt = new System.Windows.Forms.CheckBox();
			this.txtOpenPassword = new System.Windows.Forms.TextBox();
			this.chkDecrypt = new System.Windows.Forms.CheckBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.grpContent.SuspendLayout();
			this.grpAdd.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(505, 10);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(62, 20);
			this.btnSelectFile.TabIndex = 10;
			this.btnSelectFile.Text = "Browse...";
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txtZipFileName
			// 
			this.txtZipFileName.Location = new System.Drawing.Point(79, 10);
			this.txtZipFileName.Name = "txtZipFileName";
			this.txtZipFileName.Size = new System.Drawing.Size(419, 20);
			this.txtZipFileName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(5, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Zip archive";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOpenZipFile
			// 
			this.btnOpenZipFile.Location = new System.Drawing.Point(79, 79);
			this.btnOpenZipFile.Name = "btnOpenZipFile";
			this.btnOpenZipFile.Size = new System.Drawing.Size(86, 23);
			this.btnOpenZipFile.TabIndex = 11;
			this.btnOpenZipFile.Text = "Open";
			this.btnOpenZipFile.UseVisualStyleBackColor = true;
			this.btnOpenZipFile.Click += new System.EventHandler(this.btnOpenZipFile_Click);
			// 
			// grpContent
			// 
			this.grpContent.Controls.Add(this.btnDown);
			this.grpContent.Controls.Add(this.btnUp);
			this.grpContent.Controls.Add(this.btnExtract);
			this.grpContent.Controls.Add(this.label3);
			this.grpContent.Controls.Add(this.label1);
			this.grpContent.Controls.Add(this.lvAll);
			this.grpContent.Controls.Add(this.lvVisible);
			this.grpContent.Location = new System.Drawing.Point(5, 118);
			this.grpContent.Name = "grpContent";
			this.grpContent.Size = new System.Drawing.Size(634, 241);
			this.grpContent.TabIndex = 12;
			this.grpContent.TabStop = false;
			this.grpContent.Text = "Content";
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(289, 120);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(46, 23);
			this.btnDown.TabIndex = 19;
			this.btnDown.Text = "Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(289, 91);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(46, 23);
			this.btnUp.TabIndex = 18;
			this.btnUp.Text = "Up";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnExtract
			// 
			this.btnExtract.Location = new System.Drawing.Point(22, 200);
			this.btnExtract.Name = "btnExtract";
			this.btnExtract.Size = new System.Drawing.Size(215, 23);
			this.btnExtract.TabIndex = 17;
			this.btnExtract.Text = "Extract selected files";
			this.btnExtract.UseVisualStyleBackColor = true;
			this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "All files";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(343, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Visible files (additional list only for information)";
			// 
			// lvAll
			// 
			this.lvAll.CheckBoxes = true;
			this.lvAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colCompressedSize});
			this.lvAll.FullRowSelect = true;
			this.lvAll.GridLines = true;
			this.lvAll.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvAll.HideSelection = false;
			this.lvAll.Location = new System.Drawing.Point(22, 45);
			this.lvAll.Name = "lvAll";
			this.lvAll.Size = new System.Drawing.Size(265, 149);
			this.lvAll.TabIndex = 1;
			this.lvAll.UseCompatibleStateImageBehavior = false;
			this.lvAll.View = System.Windows.Forms.View.Details;
			this.lvAll.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvAll_ItemChecked);
			this.lvAll.DoubleClick += new System.EventHandler(this.lvAll_DoubleClick);
			this.lvAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvAll_KeyDown);
			// 
			// colFileName
			// 
			this.colFileName.Text = "Name";
			this.colFileName.Width = 160;
			// 
			// colCompressedSize
			// 
			this.colCompressedSize.Text = "Compressed Size";
			this.colCompressedSize.Width = 100;
			// 
			// lvVisible
			// 
			this.lvVisible.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVisibleFileName,
            this.colVisibleCompressedSize});
			this.lvVisible.FullRowSelect = true;
			this.lvVisible.GridLines = true;
			this.lvVisible.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvVisible.HideSelection = false;
			this.lvVisible.Location = new System.Drawing.Point(346, 45);
			this.lvVisible.Name = "lvVisible";
			this.lvVisible.Size = new System.Drawing.Size(265, 149);
			this.lvVisible.TabIndex = 0;
			this.lvVisible.UseCompatibleStateImageBehavior = false;
			this.lvVisible.View = System.Windows.Forms.View.Details;
			this.lvVisible.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvAll_ItemChecked);
			// 
			// colVisibleFileName
			// 
			this.colVisibleFileName.Text = "Name";
			this.colVisibleFileName.Width = 160;
			// 
			// colVisibleCompressedSize
			// 
			this.colVisibleCompressedSize.Text = "Compressed Size";
			this.colVisibleCompressedSize.Width = 100;
			// 
			// btnSelectNewFile
			// 
			this.btnSelectNewFile.Location = new System.Drawing.Point(508, 26);
			this.btnSelectNewFile.Name = "btnSelectNewFile";
			this.btnSelectNewFile.Size = new System.Drawing.Size(62, 20);
			this.btnSelectNewFile.TabIndex = 13;
			this.btnSelectNewFile.Text = "Browse...";
			this.btnSelectNewFile.Click += new System.EventHandler(this.SelectNewFile_Click);
			// 
			// txtNewFileName
			// 
			this.txtNewFileName.Location = new System.Drawing.Point(78, 26);
			this.txtNewFileName.Name = "txtNewFileName";
			this.txtNewFileName.Size = new System.Drawing.Size(424, 20);
			this.txtNewFileName.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "File";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkAddVisible
			// 
			this.chkAddVisible.AutoSize = true;
			this.chkAddVisible.Location = new System.Drawing.Point(78, 60);
			this.chkAddVisible.Name = "chkAddVisible";
			this.chkAddVisible.Size = new System.Drawing.Size(56, 17);
			this.chkAddVisible.TabIndex = 14;
			this.chkAddVisible.Text = "Visible";
			this.chkAddVisible.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(78, 83);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(86, 23);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(500, 518);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(139, 23);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Save changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// grpAdd
			// 
			this.grpAdd.Controls.Add(this.label4);
			this.grpAdd.Controls.Add(this.btnAdd);
			this.grpAdd.Controls.Add(this.txtNewFileName);
			this.grpAdd.Controls.Add(this.chkAddVisible);
			this.grpAdd.Controls.Add(this.btnSelectNewFile);
			this.grpAdd.Location = new System.Drawing.Point(5, 376);
			this.grpAdd.Name = "grpAdd";
			this.grpAdd.Size = new System.Drawing.Size(634, 117);
			this.grpAdd.TabIndex = 17;
			this.grpAdd.TabStop = false;
			this.grpAdd.Text = "Add Content";
			// 
			// txtSavePassword
			// 
			this.txtSavePassword.Enabled = false;
			this.txtSavePassword.Location = new System.Drawing.Point(204, 518);
			this.txtSavePassword.Name = "txtSavePassword";
			this.txtSavePassword.Size = new System.Drawing.Size(195, 20);
			this.txtSavePassword.TabIndex = 18;
			// 
			// chkEncrypt
			// 
			this.chkEncrypt.AutoSize = true;
			this.chkEncrypt.Enabled = false;
			this.chkEncrypt.Location = new System.Drawing.Point(5, 518);
			this.chkEncrypt.Name = "chkEncrypt";
			this.chkEncrypt.Size = new System.Drawing.Size(193, 17);
			this.chkEncrypt.TabIndex = 20;
			this.chkEncrypt.Text = "Encrypt new archive with password";
			this.chkEncrypt.UseVisualStyleBackColor = true;
			this.chkEncrypt.CheckedChanged += new System.EventHandler(this.chkEncrypt_CheckedChanged);
			// 
			// txtOpenPassword
			// 
			this.txtOpenPassword.Enabled = false;
			this.txtOpenPassword.Location = new System.Drawing.Point(253, 42);
			this.txtOpenPassword.Name = "txtOpenPassword";
			this.txtOpenPassword.Size = new System.Drawing.Size(195, 20);
			this.txtOpenPassword.TabIndex = 21;
			// 
			// chkDecrypt
			// 
			this.chkDecrypt.AutoSize = true;
			this.chkDecrypt.Location = new System.Drawing.Point(79, 45);
			this.chkDecrypt.Name = "chkDecrypt";
			this.chkDecrypt.Size = new System.Drawing.Size(171, 17);
			this.chkDecrypt.TabIndex = 23;
			this.chkDecrypt.Text = "Decrypt archive with password";
			this.chkDecrypt.UseVisualStyleBackColor = true;
			this.chkDecrypt.CheckedChanged += new System.EventHandler(this.chkDecrypt_CheckedChanged);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(171, 79);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(86, 23);
			this.btnCreate.TabIndex = 24;
			this.btnCreate.Text = "Create new";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 552);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.chkDecrypt);
			this.Controls.Add(this.txtOpenPassword);
			this.Controls.Add(this.chkEncrypt);
			this.Controls.Add(this.txtSavePassword);
			this.Controls.Add(this.grpAdd);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.grpContent);
			this.Controls.Add(this.btnOpenZipFile);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.txtZipFileName);
			this.Controls.Add(this.label2);
			this.Name = "MainForm";
			this.Text = "Zipped Steganography";
			this.grpContent.ResumeLayout(false);
			this.grpContent.PerformLayout();
			this.grpAdd.ResumeLayout(false);
			this.grpAdd.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtZipFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOpenZipFile;
		private System.Windows.Forms.GroupBox grpContent;
		private System.Windows.Forms.ListView lvVisible;
		private System.Windows.Forms.ColumnHeader colVisibleFileName;
		private System.Windows.Forms.ColumnHeader colVisibleCompressedSize;
		private System.Windows.Forms.ListView lvAll;
		private System.Windows.Forms.ColumnHeader colFileName;
		private System.Windows.Forms.ColumnHeader colCompressedSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelectNewFile;
		private System.Windows.Forms.TextBox txtNewFileName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.CheckBox chkAddVisible;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.GroupBox grpAdd;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.TextBox txtSavePassword;
		private System.Windows.Forms.CheckBox chkEncrypt;
		private System.Windows.Forms.TextBox txtOpenPassword;
		private System.Windows.Forms.CheckBox chkDecrypt;
		private System.Windows.Forms.Button btnCreate;
	}
}

