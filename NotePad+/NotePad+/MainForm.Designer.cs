namespace NotePad_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.itmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSaveAz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.itmWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.itmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.itmTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontandSizeToolStripMenu = new System.Windows.Forms.ToolStrip();
            this.cmbFontName = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.notifyForCapsLock = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu.SuspendLayout();
            this.fontandSizeToolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.mnuFormat,
            this.windowToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(575, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmNew,
            this.itmOpen,
            this.itmSave,
            this.itmSaveAz,
            this.toolStripMenuItem1,
            this.itmExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // itmNew
            // 
            this.itmNew.Name = "itmNew";
            this.itmNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itmNew.Size = new System.Drawing.Size(140, 22);
            this.itmNew.Text = "New";
            this.itmNew.Click += new System.EventHandler(this.itmNew_Click);
            // 
            // itmOpen
            // 
            this.itmOpen.Name = "itmOpen";
            this.itmOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itmOpen.Size = new System.Drawing.Size(140, 22);
            this.itmOpen.Text = "Open";
            this.itmOpen.Click += new System.EventHandler(this.itmOpen_Click);
            // 
            // itmSave
            // 
            this.itmSave.Name = "itmSave";
            this.itmSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itmSave.Size = new System.Drawing.Size(140, 22);
            this.itmSave.Text = "Save";
            this.itmSave.Click += new System.EventHandler(this.itmSave_Click);
            // 
            // itmSaveAz
            // 
            this.itmSaveAz.Name = "itmSaveAz";
            this.itmSaveAz.Size = new System.Drawing.Size(140, 22);
            this.itmSaveAz.Text = "Save As";
            this.itmSaveAz.Click += new System.EventHandler(this.itmSaveAz_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
            // 
            // itmExit
            // 
            this.itmExit.Name = "itmExit";
            this.itmExit.Size = new System.Drawing.Size(140, 22);
            this.itmExit.Text = "Exit";
            this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCut,
            this.itmCopy,
            this.itmPaste,
            this.itmDelete});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // itmCut
            // 
            this.itmCut.Name = "itmCut";
            this.itmCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.itmCut.Size = new System.Drawing.Size(139, 22);
            this.itmCut.Text = "Cut";
            this.itmCut.Click += new System.EventHandler(this.itmCut_Click);
            // 
            // itmCopy
            // 
            this.itmCopy.Name = "itmCopy";
            this.itmCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.itmCopy.Size = new System.Drawing.Size(139, 22);
            this.itmCopy.Text = "Copy";
            this.itmCopy.Click += new System.EventHandler(this.itmCopy_Click);
            // 
            // itmPaste
            // 
            this.itmPaste.Name = "itmPaste";
            this.itmPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.itmPaste.Size = new System.Drawing.Size(139, 22);
            this.itmPaste.Text = "Paste";
            this.itmPaste.Click += new System.EventHandler(this.itmPaste_Click);
            // 
            // itmDelete
            // 
            this.itmDelete.Name = "itmDelete";
            this.itmDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.itmDelete.Size = new System.Drawing.Size(139, 22);
            this.itmDelete.Text = "Delete";
            this.itmDelete.Click += new System.EventHandler(this.itmDelete_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmWordWrap,
            this.itmFont});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(53, 20);
            this.mnuFormat.Text = "Format";
            // 
            // itmWordWrap
            // 
            this.itmWordWrap.Name = "itmWordWrap";
            this.itmWordWrap.Size = new System.Drawing.Size(129, 22);
            this.itmWordWrap.Text = "Word Wrap";
            this.itmWordWrap.Click += new System.EventHandler(this.itmWordWrap_Click);
            // 
            // itmFont
            // 
            this.itmFont.Name = "itmFont";
            this.itmFont.Size = new System.Drawing.Size(129, 22);
            this.itmFont.Text = "Font...";
            this.itmFont.Click += new System.EventHandler(this.itmFont_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmTileHorizontal,
            this.itmTileVertical,
            this.itmCascade});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // itmTileHorizontal
            // 
            this.itmTileHorizontal.Name = "itmTileHorizontal";
            this.itmTileHorizontal.Size = new System.Drawing.Size(141, 22);
            this.itmTileHorizontal.Text = "Tile Horizontal";
            this.itmTileHorizontal.Click += new System.EventHandler(this.itmTileHorizontal_Click);
            // 
            // itmTileVertical
            // 
            this.itmTileVertical.Name = "itmTileVertical";
            this.itmTileVertical.Size = new System.Drawing.Size(141, 22);
            this.itmTileVertical.Text = "Tile Vertical";
            this.itmTileVertical.Click += new System.EventHandler(this.itmTileVertical_Click);
            // 
            // itmCascade
            // 
            this.itmCascade.Name = "itmCascade";
            this.itmCascade.Size = new System.Drawing.Size(141, 22);
            this.itmCascade.Text = "Cascade";
            this.itmCascade.Click += new System.EventHandler(this.itmCascade_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "Text Document|*.txt";
            this.openFile.Title = "Open File";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Text Document|*.txt";
            this.saveFile.Title = "Save File";
            // 
            // fontandSizeToolStripMenu
            // 
            this.fontandSizeToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbFontName,
            this.cmbFontSize});
            this.fontandSizeToolStripMenu.Location = new System.Drawing.Point(0, 24);
            this.fontandSizeToolStripMenu.Name = "fontandSizeToolStripMenu";
            this.fontandSizeToolStripMenu.Size = new System.Drawing.Size(575, 25);
            this.fontandSizeToolStripMenu.TabIndex = 4;
            this.fontandSizeToolStripMenu.Text = "toolStrip1";
            // 
            // cmbFontName
            // 
            this.cmbFontName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFontName.Name = "cmbFontName";
            this.cmbFontName.Size = new System.Drawing.Size(150, 25);
            this.cmbFontName.SelectedIndexChanged += new System.EventHandler(this.cmbFontName_SelectedIndexChanged);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(75, 25);
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // notifyForCapsLock
            // 
            this.notifyForCapsLock.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyForCapsLock.Icon")));
            this.notifyForCapsLock.Text = "NotePad+";
            this.notifyForCapsLock.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 466);
            this.Controls.Add(this.fontandSizeToolStripMenu);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.fontandSizeToolStripMenu.ResumeLayout(false);
            this.fontandSizeToolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem itmNew;
        private System.Windows.Forms.ToolStripMenuItem itmOpen;
        private System.Windows.Forms.ToolStripMenuItem itmSave;
        private System.Windows.Forms.ToolStripMenuItem itmSaveAz;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itmExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmCut;
        private System.Windows.Forms.ToolStripMenuItem itmCopy;
        private System.Windows.Forms.ToolStripMenuItem itmPaste;
        private System.Windows.Forms.ToolStripMenuItem itmDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem itmWordWrap;
        private System.Windows.Forms.ToolStripMenuItem itmFont;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem itmTileVertical;
        private System.Windows.Forms.ToolStripMenuItem itmCascade;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStrip fontandSizeToolStripMenu;
        private System.Windows.Forms.ToolStripComboBox cmbFontName;
        private System.Windows.Forms.ToolStripComboBox cmbFontSize;
        private System.Windows.Forms.NotifyIcon notifyForCapsLock;
    }
}

