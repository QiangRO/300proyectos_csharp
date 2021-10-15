namespace FiFa
{
    partial class frmMain
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuCut = new System.Windows.Forms.MenuItem();
            this.mnuCopy = new System.Windows.Forms.MenuItem();
            this.mnuPaste = new System.Windows.Forms.MenuItem();
            this.mnuClear = new System.Windows.Forms.MenuItem();
            this.mnuClearMainText = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mnuClearTranslatedText = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuSelectAll = new System.Windows.Forms.MenuItem();
            this.mnuSelecAllMainText = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.mnuSelectAllTranslatedText = new System.Windows.Forms.MenuItem();
            this.HMNU = new System.Windows.Forms.MenuItem();
            this.mnuLanguage = new System.Windows.Forms.MenuItem();
            this.mnuFarsi = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.mnuEnglish = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHowToUse = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainText = new System.Windows.Forms.TextBox();
            this.translatedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newLine = new System.Windows.Forms.Button();
            this.previewText = new System.Windows.Forms.TextBox();
            this.mnuFont = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuLanguage,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSaveAs,
            this.menuItem3,
            this.mnuExit});
            this.mnuFile.Text = "فایل";
            this.mnuFile.Select += new System.EventHandler(this.mnuFile_Select);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Index = 0;
            this.mnuSaveAs.Text = "ذخیره متن";
            this.mnuSaveAs.Select += new System.EventHandler(this.mnuSaveAs_Select);
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 2;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "خروج از برنامه";
            this.mnuExit.Select += new System.EventHandler(this.mnuExit_Select);
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 1;
            this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuClear,
            this.menuItem6,
            this.mnuSelectAll,
            this.menuItem1,
            this.mnuFont,
            this.HMNU});
            this.mnuEdit.Text = "متن";
            this.mnuEdit.Select += new System.EventHandler(this.mnuEdit_Select);
            // 
            // mnuCut
            // 
            this.mnuCut.Index = 0;
            this.mnuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mnuCut.Text = "برش";
            this.mnuCut.Select += new System.EventHandler(this.mnuCut_Select);
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Index = 1;
            this.mnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mnuCopy.Text = "کپی";
            this.mnuCopy.Select += new System.EventHandler(this.mnuCopy_Select);
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Index = 2;
            this.mnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mnuPaste.Text = "چسباندن";
            this.mnuPaste.Select += new System.EventHandler(this.mnuPaste_Select);
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuClear
            // 
            this.mnuClear.Index = 3;
            this.mnuClear.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuClearMainText,
            this.menuItem9,
            this.mnuClearTranslatedText});
            this.mnuClear.Text = "پاک کردن";
            this.mnuClear.Select += new System.EventHandler(this.mnuClear_Select);
            // 
            // mnuClearMainText
            // 
            this.mnuClearMainText.Index = 0;
            this.mnuClearMainText.Text = "متن شما";
            this.mnuClearMainText.Select += new System.EventHandler(this.mnuClearMainText_Select);
            this.mnuClearMainText.Click += new System.EventHandler(this.mnuClearMainText_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // mnuClearTranslatedText
            // 
            this.mnuClearTranslatedText.Index = 2;
            this.mnuClearTranslatedText.Text = "متن ترجمه شده";
            this.mnuClearTranslatedText.Select += new System.EventHandler(this.mnuClearTranslatedText_Select);
            this.mnuClearTranslatedText.Click += new System.EventHandler(this.mnuClearTranslatedText_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "-";
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Index = 5;
            this.mnuSelectAll.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSelecAllMainText,
            this.menuItem13,
            this.mnuSelectAllTranslatedText});
            this.mnuSelectAll.Text = "انتخاب کل";
            this.mnuSelectAll.Select += new System.EventHandler(this.mnuSelectAll_Select);
            // 
            // mnuSelecAllMainText
            // 
            this.mnuSelecAllMainText.Index = 0;
            this.mnuSelecAllMainText.Text = "متن شما";
            this.mnuSelecAllMainText.Select += new System.EventHandler(this.mnuSelecAllMainText_Select);
            this.mnuSelecAllMainText.Click += new System.EventHandler(this.mnuSelecAllMainText_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "-";
            // 
            // mnuSelectAllTranslatedText
            // 
            this.mnuSelectAllTranslatedText.Index = 2;
            this.mnuSelectAllTranslatedText.Text = "متن ترجمه شده";
            this.mnuSelectAllTranslatedText.Select += new System.EventHandler(this.mnuSelectAllTranslatedText_Select);
            this.mnuSelectAllTranslatedText.Click += new System.EventHandler(this.mnuSelectAllTranslatedText_Click);
            // 
            // HMNU
            // 
            this.HMNU.Index = 8;
            this.HMNU.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.HMNU.Text = "";
            this.HMNU.Visible = false;
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.Index = 2;
            this.mnuLanguage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFarsi,
            this.menuItem17,
            this.mnuEnglish});
            this.mnuLanguage.Text = "زبان";
            this.mnuLanguage.Select += new System.EventHandler(this.mnuLanguage_Select);
            // 
            // mnuFarsi
            // 
            this.mnuFarsi.Checked = true;
            this.mnuFarsi.Index = 0;
            this.mnuFarsi.RadioCheck = true;
            this.mnuFarsi.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.mnuFarsi.Text = "فارسی";
            this.mnuFarsi.Select += new System.EventHandler(this.mnuFarsi_Select);
            this.mnuFarsi.Click += new System.EventHandler(this.mnuFarsi_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 1;
            this.menuItem17.Text = "-";
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Index = 2;
            this.mnuEnglish.RadioCheck = true;
            this.mnuEnglish.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.mnuEnglish.Text = "انگلیسی";
            this.mnuEnglish.Select += new System.EventHandler(this.mnuEnglish_Select);
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 3;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHowToUse,
            this.menuItem21,
            this.mnuAbout});
            this.mnuHelp.Text = "راهنما";
            this.mnuHelp.Select += new System.EventHandler(this.mnuHelp_Select);
            // 
            // mnuHowToUse
            // 
            this.mnuHowToUse.Index = 0;
            this.mnuHowToUse.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.mnuHowToUse.Text = "راهنمای استفاده از برنامه";
            this.mnuHowToUse.Select += new System.EventHandler(this.mnuHowToUse_Select);
            this.mnuHowToUse.Click += new System.EventHandler(this.mnuHowToUse_Click);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 1;
            this.menuItem21.Text = "-";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 2;
            this.mnuAbout.Text = "درباره این برنامه";
            this.mnuAbout.Select += new System.EventHandler(this.mnuAbout_Select);
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(29, 17);
            this.statusLabel.Text = "آماده";
            // 
            // mainText
            // 
            this.mainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
            this.mainText.ForeColor = System.Drawing.Color.Gray;
            this.mainText.Location = new System.Drawing.Point(12, 12);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(380, 21);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "متن خود را اینجا تایپ کنید";
            this.mainText.TextChanged += new System.EventHandler(this.mainText_TextChanged);
            this.mainText.MouseLeave += new System.EventHandler(this.mainText_MouseLeave);
            this.mainText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainText_MouseMove);
            this.mainText.Click += new System.EventHandler(this.mainText_Click);
            this.mainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainText_KeyPress);
            // 
            // translatedText
            // 
            this.translatedText.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.translatedText.ForeColor = System.Drawing.Color.Gray;
            this.translatedText.Location = new System.Drawing.Point(12, 66);
            this.translatedText.Multiline = true;
            this.translatedText.Name = "translatedText";
            this.translatedText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.translatedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translatedText.Size = new System.Drawing.Size(472, 211);
            this.translatedText.TabIndex = 2;
            this.translatedText.Text = "متن ترجمه شده اینجا قرار می گیرد (اینکار توسط برنامه انجام خواهد شد)";
            this.translatedText.MouseLeave += new System.EventHandler(this.translatedText_MouseLeave);
            this.translatedText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.translatedText_MouseMove);
            this.translatedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.translatedText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // newLine
            // 
            this.newLine.Enabled = false;
            this.newLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLine.Location = new System.Drawing.Point(398, 12);
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(86, 21);
            this.newLine.TabIndex = 4;
            this.newLine.Text = "برو به سر خط";
            this.newLine.UseVisualStyleBackColor = true;
            this.newLine.MouseLeave += new System.EventHandler(this.newLine_MouseLeave);
            this.newLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newLine_MouseMove);
            this.newLine.Click += new System.EventHandler(this.newLine_Click);
            // 
            // previewText
            // 
            this.previewText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.previewText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewText.ForeColor = System.Drawing.Color.Black;
            this.previewText.Location = new System.Drawing.Point(12, 39);
            this.previewText.Name = "previewText";
            this.previewText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.previewText.Size = new System.Drawing.Size(472, 21);
            this.previewText.TabIndex = 5;
            this.previewText.Text = "پیش نمایش متن";
            // 
            // mnuFont
            // 
            this.mnuFont.Index = 7;
            this.mnuFont.Text = "تغییر فونت";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 6;
            this.menuItem1.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 311);
            this.Controls.Add(this.previewText);
            this.Controls.Add(this.newLine);
            this.Controls.Add(this.translatedText);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiFa Translator © 2008 By Samson Davidoff";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuSaveAs;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuCut;
        private System.Windows.Forms.MenuItem mnuCopy;
        private System.Windows.Forms.MenuItem mnuPaste;
        private System.Windows.Forms.MenuItem mnuClear;
        private System.Windows.Forms.MenuItem mnuClearMainText;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem mnuClearTranslatedText;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem mnuSelectAll;
        private System.Windows.Forms.MenuItem mnuSelecAllMainText;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem mnuSelectAllTranslatedText;
        private System.Windows.Forms.MenuItem mnuLanguage;
        private System.Windows.Forms.MenuItem mnuFarsi;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem mnuEnglish;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuHowToUse;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.TextBox translatedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuItem HMNU;
        private System.Windows.Forms.Button newLine;
        private System.Windows.Forms.TextBox previewText;
        private System.Windows.Forms.MenuItem mnuFont;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

