namespace HNotePad__
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadFromDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tspPrintFontSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPrintNow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoAction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteText = new System.Windows.Forms.ToolStripMenuItem();
            this.CutText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GotoLine = new System.Windows.Forms.ToolStripMenuItem();
            this.FindText = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNextText = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RighToLeftDirection = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftToRightDirection = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusOfCursor = new System.Windows.Forms.ToolStripTextBox();
            this.NumberOfCharInEachText = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextFiles = new System.Windows.Forms.TabControl();
            this.cmsForTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeAllTabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavedOrNotImages = new System.Windows.Forms.ImageList(this.components);
            this.fontSelectDialog = new System.Windows.Forms.FontDialog();
            this.OpenFiles = new System.Windows.Forms.OpenFileDialog();
            this.SaveFiles = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.psd = new System.Windows.Forms.PageSetupDialog();
            this.FontPrintDialog = new System.Windows.Forms.FontDialog();
            this.MainMenu.SuspendLayout();
            this.cmsForTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = false;
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.StatusOfCursor,
            this.NumberOfCharInEachText,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(721, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.reloadFromDiskToolStripMenuItem,
            this.toolStripSeparator1,
            this.tspPrintFontSettings,
            this.tspPageSetup,
            this.printToolStripMenuItem,
            this.tspPrintNow,
            this.toolStripSeparator2,
            this.tspClose,
            this.tspCloseAll,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // reloadFromDiskToolStripMenuItem
            // 
            this.reloadFromDiskToolStripMenuItem.Name = "reloadFromDiskToolStripMenuItem";
            this.reloadFromDiskToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reloadFromDiskToolStripMenuItem.Text = "&Reload from Disk";
            this.reloadFromDiskToolStripMenuItem.Click += new System.EventHandler(this.reloadFromDiskToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // tspPrintFontSettings
            // 
            this.tspPrintFontSettings.Name = "tspPrintFontSettings";
            this.tspPrintFontSettings.Size = new System.Drawing.Size(195, 22);
            this.tspPrintFontSettings.Text = "Font Settings &For Print";
            this.tspPrintFontSettings.Click += new System.EventHandler(this.tspPrintFontSettings_Click);
            // 
            // tspPageSetup
            // 
            this.tspPageSetup.Name = "tspPageSetup";
            this.tspPageSetup.Size = new System.Drawing.Size(195, 22);
            this.tspPageSetup.Text = "Pa&ge Setup";
            this.tspPageSetup.Click += new System.EventHandler(this.tspPageSetup_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // tspPrintNow
            // 
            this.tspPrintNow.Name = "tspPrintNow";
            this.tspPrintNow.Size = new System.Drawing.Size(195, 22);
            this.tspPrintNow.Text = "Print now";
            this.tspPrintNow.Click += new System.EventHandler(this.tspPrintNow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // tspClose
            // 
            this.tspClose.Name = "tspClose";
            this.tspClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tspClose.Size = new System.Drawing.Size(195, 22);
            this.tspClose.Text = "&Close";
            this.tspClose.Click += new System.EventHandler(this.tspClose_Click);
            // 
            // tspCloseAll
            // 
            this.tspCloseAll.Name = "tspCloseAll";
            this.tspCloseAll.Size = new System.Drawing.Size(195, 22);
            this.tspCloseAll.Text = "C&lose All";
            this.tspCloseAll.Click += new System.EventHandler(this.tspCloseAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoAction,
            this.toolStripSeparator3,
            this.CopyText,
            this.PasteText,
            this.DeleteText,
            this.CutText,
            this.toolStripSeparator4,
            this.GotoLine,
            this.FindText,
            this.FindNextText,
            this.ReplaceText,
            this.toolStripSeparator5,
            this.SelectAll,
            this.InsertTimeDate});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // UndoAction
            // 
            this.UndoAction.Name = "UndoAction";
            this.UndoAction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoAction.Size = new System.Drawing.Size(164, 22);
            this.UndoAction.Text = "&Undo";
            this.UndoAction.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // CopyText
            // 
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyText.Size = new System.Drawing.Size(164, 22);
            this.CopyText.Text = "&Copy";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // PasteText
            // 
            this.PasteText.Name = "PasteText";
            this.PasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteText.Size = new System.Drawing.Size(164, 22);
            this.PasteText.Text = "&Paste";
            this.PasteText.Click += new System.EventHandler(this.PasteText_Click);
            // 
            // DeleteText
            // 
            this.DeleteText.Name = "DeleteText";
            this.DeleteText.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteText.Size = new System.Drawing.Size(164, 22);
            this.DeleteText.Text = "&Delete";
            this.DeleteText.Click += new System.EventHandler(this.DeleteText_Click);
            // 
            // CutText
            // 
            this.CutText.Name = "CutText";
            this.CutText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutText.Size = new System.Drawing.Size(164, 22);
            this.CutText.Text = "C&ut";
            this.CutText.Click += new System.EventHandler(this.CutText_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // GotoLine
            // 
            this.GotoLine.Name = "GotoLine";
            this.GotoLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.GotoLine.Size = new System.Drawing.Size(164, 22);
            this.GotoLine.Text = "&Go to";
            this.GotoLine.Click += new System.EventHandler(this.GotoLine_Click);
            // 
            // FindText
            // 
            this.FindText.Name = "FindText";
            this.FindText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindText.Size = new System.Drawing.Size(164, 22);
            this.FindText.Text = "&Find";
            this.FindText.Click += new System.EventHandler(this.FindText_Click);
            // 
            // FindNextText
            // 
            this.FindNextText.Name = "FindNextText";
            this.FindNextText.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FindNextText.Size = new System.Drawing.Size(164, 22);
            this.FindNextText.Text = "Find &Next";
            this.FindNextText.Click += new System.EventHandler(this.FindNextText_Click);
            // 
            // ReplaceText
            // 
            this.ReplaceText.Name = "ReplaceText";
            this.ReplaceText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.ReplaceText.Size = new System.Drawing.Size(164, 22);
            this.ReplaceText.Text = "&Replace";
            this.ReplaceText.Click += new System.EventHandler(this.ReplaceText_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAll.Size = new System.Drawing.Size(164, 22);
            this.SelectAll.Text = "&Select All";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // InsertTimeDate
            // 
            this.InsertTimeDate.Name = "InsertTimeDate";
            this.InsertTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.InsertTimeDate.Size = new System.Drawing.Size(164, 22);
            this.InsertTimeDate.Text = "&Time Date";
            this.InsertTimeDate.Click += new System.EventHandler(this.InsertTimeDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.rightToLeftToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.formatToolStripMenuItem.Text = "F&ormat";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RighToLeftDirection,
            this.LeftToRightDirection});
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rightToLeftToolStripMenuItem.Text = "&Direction";
            // 
            // RighToLeftDirection
            // 
            this.RighToLeftDirection.Name = "RighToLeftDirection";
            this.RighToLeftDirection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RighToLeftDirection.Size = new System.Drawing.Size(183, 22);
            this.RighToLeftDirection.Text = "&Right To Left";
            this.RighToLeftDirection.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem1_Click);
            // 
            // LeftToRightDirection
            // 
            this.LeftToRightDirection.Name = "LeftToRightDirection";
            this.LeftToRightDirection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LeftToRightDirection.Size = new System.Drawing.Size(183, 22);
            this.LeftToRightDirection.Text = "&Left To Right";
            this.LeftToRightDirection.Click += new System.EventHandler(this.leftToRightToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem,
            this.wordWrapToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Checked = true;
            this.wordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "&Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // StatusOfCursor
            // 
            this.StatusOfCursor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusOfCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StatusOfCursor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusOfCursor.Enabled = false;
            this.StatusOfCursor.Name = "StatusOfCursor";
            this.StatusOfCursor.ReadOnly = true;
            this.StatusOfCursor.Size = new System.Drawing.Size(120, 24);
            this.StatusOfCursor.Text = "Ln 1 , Col 1";
            this.StatusOfCursor.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumberOfCharInEachText
            // 
            this.NumberOfCharInEachText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NumberOfCharInEachText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumberOfCharInEachText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberOfCharInEachText.Enabled = false;
            this.NumberOfCharInEachText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCharInEachText.ForeColor = System.Drawing.SystemColors.Window;
            this.NumberOfCharInEachText.Name = "NumberOfCharInEachText";
            this.NumberOfCharInEachText.ReadOnly = true;
            this.NumberOfCharInEachText.Size = new System.Drawing.Size(250, 24);
            this.NumberOfCharInEachText.Text = "Char In This :";
            this.NumberOfCharInEachText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TextFiles
            // 
            this.TextFiles.ContextMenuStrip = this.cmsForTabs;
            this.TextFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextFiles.ImageList = this.SavedOrNotImages;
            this.TextFiles.ItemSize = new System.Drawing.Size(58, 19);
            this.TextFiles.Location = new System.Drawing.Point(0, 28);
            this.TextFiles.Name = "TextFiles";
            this.TextFiles.SelectedIndex = 0;
            this.TextFiles.ShowToolTips = true;
            this.TextFiles.Size = new System.Drawing.Size(721, 422);
            this.TextFiles.TabIndex = 2;
            this.TextFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextFiles_MouseDoubleClick);
            // 
            // cmsForTabs
            // 
            this.cmsForTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllTabsToolStripMenuItem});
            this.cmsForTabs.Name = "contextMenuStrip1";
            this.cmsForTabs.Size = new System.Drawing.Size(149, 26);
            // 
            // closeAllTabsToolStripMenuItem
            // 
            this.closeAllTabsToolStripMenuItem.Name = "closeAllTabsToolStripMenuItem";
            this.closeAllTabsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeAllTabsToolStripMenuItem.Text = "Close All Tabs";
            this.closeAllTabsToolStripMenuItem.Click += new System.EventHandler(this.closeAllTabsToolStripMenuItem_Click);
            // 
            // SavedOrNotImages
            // 
            this.SavedOrNotImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SavedOrNotImages.ImageStream")));
            this.SavedOrNotImages.TransparentColor = System.Drawing.Color.Transparent;
            this.SavedOrNotImages.Images.SetKeyName(0, "1.png");
            this.SavedOrNotImages.Images.SetKeyName(1, "1 (2).png");
            // 
            // OpenFiles
            // 
            this.OpenFiles.FileName = "Please Select Your\'r Files";
            this.OpenFiles.Filter = "Text Documents|*.txt|XML Documents|*.xml|All Files|*.*";
            this.OpenFiles.Multiselect = true;
            this.OpenFiles.RestoreDirectory = true;
            this.OpenFiles.Title = "انتخاب فایل ها برای باز کردن";
            // 
            // SaveFiles
            // 
            this.SaveFiles.Filter = "Text Files|*.txt|All Files|*.*";
            this.SaveFiles.Title = "مسیر و نام فایل را برای ذخیره مشخص کنید";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // FontPrintDialog
            // 
            this.FontPrintDialog.ShowColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.TextFiles);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "HNotepad++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.cmsForTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox NumberOfCharInEachText;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl TextFiles;
        private System.Windows.Forms.FontDialog fontSelectDialog;
        private System.Windows.Forms.OpenFileDialog OpenFiles;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RighToLeftDirection;
        private System.Windows.Forms.ToolStripMenuItem LeftToRightDirection;
        private System.Windows.Forms.ImageList SavedOrNotImages;
        private System.Windows.Forms.SaveFileDialog SaveFiles;
        private System.Windows.Forms.ToolStripMenuItem UndoAction;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem PasteText;
        private System.Windows.Forms.ToolStripMenuItem DeleteText;
        private System.Windows.Forms.ToolStripMenuItem CutText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem FindText;
        private System.Windows.Forms.ToolStripMenuItem FindNextText;
        private System.Windows.Forms.ToolStripMenuItem ReplaceText;
        private System.Windows.Forms.ToolStripMenuItem GotoLine;
        private System.Windows.Forms.ToolStripMenuItem InsertTimeDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox StatusOfCursor;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog psd;
        private System.Windows.Forms.ToolStripMenuItem tspPageSetup;
        private System.Windows.Forms.FontDialog FontPrintDialog;
        private System.Windows.Forms.ToolStripMenuItem tspPrintFontSettings;
        private System.Windows.Forms.ContextMenuStrip cmsForTabs;
        private System.Windows.Forms.ToolStripMenuItem closeAllTabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspClose;
        private System.Windows.Forms.ToolStripMenuItem tspCloseAll;
        private System.Windows.Forms.ToolStripMenuItem reloadFromDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspPrintNow;
        //-----------------------------------------------------------------------
    }
}

