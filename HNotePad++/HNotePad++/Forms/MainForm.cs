#region Import Section

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Collections;

#endregion

namespace HNotePad__
{
    public partial class MainForm : Controls.CustomForm
    {

        #region Variables

        private Point _lastEditPoint;
        private string _lastEditOperation;
        private PrintDocument pdoc;
        private int _numOfUnNamedTabs;

        #endregion

        #region Load Initial Settings

        public MainForm(string[] Args)
        {
            InitializeComponent();

            if (Args.Length > 0)
                OpenArgs(Args);

            LoadInitialVariables();
        }

        public void OpenArgs(string[] Args)
        {
            for (int i = 0; i < Args.Length; i++)
            {
                if (File.Exists(Args[i]))
                    CreateNewTab(2, Args[i]);
            }
        }

        /// <summary>
        /// this methods use for load global settings
        /// such as menu sttings and etc ... 
        /// </summary>
        private void LoadInitialVariables()
        {
            wordWrapToolStripMenuItem.Checked = Properties.Settings.Default.IsWordWrap;
            GotoLine.Enabled = !Properties.Settings.Default.IsWordWrap;

            statusBarToolStripMenuItem.Enabled = !wordWrapToolStripMenuItem.Checked;
            RighToLeftDirection.Checked = Properties.Settings.Default.RightToLeft;
            LeftToRightDirection.Checked = !Properties.Settings.Default.RightToLeft;

            _lastEditOperation = string.Empty;
            StatusOfCursor.Text = (Properties.Settings.Default.IsWordWrap == true) ? "" : SetStatusContent();
            this._numOfUnNamedTabs = 1;
            pdoc = new PrintDocument();
            pdoc.DocumentName = "H Notepad File Printing";
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
        }

        private string SetStatusContent()
        {
            string StatusString = string.Empty;
            if (this.CurrentTextBox != null)
            {
                //MessageBox.Show(this.CurrentTextBox);
            }
            return StatusString;
        }
        #endregion

        #region Printing Methods

        private void tspPrintNow_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                PrintDialog dialog = new PrintDialog();
                dialog.Document = pdoc;
                pdoc.Print();
            }
        }

        private void tspPrintFontSettings_Click(object sender, EventArgs e)
        {
            FontPrintDialog.Font = Properties.Settings.Default.Print_Font;
            FontPrintDialog.Color = Properties.Settings.Default.Print_Color;
            if (FontPrintDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Print_Font = FontPrintDialog.Font;
                Properties.Settings.Default.Print_Color = FontPrintDialog.Color;
                Properties.Settings.Default.Save();
            }
        }

        ////////////////////////////////////////////Printing The Document//////////////////////////////////////////
        static int intCurrentChar;
        static int NumOfPagesThatPrinted;
        private void pdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = Properties.Settings.Default.Print_Font;
            SolidBrush brush = new SolidBrush(Properties.Settings.Default.Print_Color);

            int intPrintAreaHeight;
            int intPrintAreaWidth;
            int marginLeft;
            int marginTop;

            intPrintAreaHeight = pdoc.DefaultPageSettings.PaperSize.Height - pdoc.DefaultPageSettings.Margins.Top - pdoc.DefaultPageSettings.Margins.Bottom;
            intPrintAreaWidth = pdoc.DefaultPageSettings.PaperSize.Width - pdoc.DefaultPageSettings.Margins.Left - pdoc.DefaultPageSettings.Margins.Right;

            marginLeft = pdoc.DefaultPageSettings.Margins.Left; // X coordinate
            marginTop = pdoc.DefaultPageSettings.Margins.Top; // Y coordinate


            if (pdoc.DefaultPageSettings.Landscape)
            {
                int intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }

            #region print Header And Footer

            Font fontForHeaderAndFooter = new Font("Tahoma", 8);

            #region Print Each Page The Document Name On Center Of Header(Header)

            int HeaderLength = (int)e.Graphics.MeasureString(this.TextFiles.SelectedTab.Text, fontForHeaderAndFooter).Width;

            //start of rect angle for draw document name
            int HeaderStratRectWidth = ((intPrintAreaWidth - HeaderLength) / 2) + marginLeft;
            int HeaderStratRectHeigth = pdoc.DefaultPageSettings.Margins.Top / 2;

            //height and width of rectangle
            //select 2 pixel for Rect Borders
            int HeaderRectWidth = HeaderLength + 2;
            int HedaerRectHeight = (3 / 2) * pdoc.DefaultPageSettings.Margins.Bottom;

            RectangleF rectForHeader = new RectangleF(HeaderStratRectWidth,
                                                      HeaderStratRectHeigth,
                                                      HeaderRectWidth,
                                                      HedaerRectHeight);

            e.Graphics.DrawString(this.TextFiles.SelectedTab.Text,
                                  fontForHeaderAndFooter,
                                  brush,
                                  rectForHeader);
            #endregion

            #region Print Page Number(Footer)

            NumOfPagesThatPrinted++;

            string footer = ("- " + NumOfPagesThatPrinted.ToString() + " -");
            int FooterLength = (int)e.Graphics.MeasureString(footer, fontForHeaderAndFooter).Width;

            //start of rect angle for draw page number
            int FooterStratRectWidth = ((intPrintAreaWidth - FooterLength) / 2) + marginLeft;
            int FooterStratRectHeigth = intPrintAreaHeight + (5 / 3) * pdoc.DefaultPageSettings.Margins.Top;

            //height and width of rectangle
            //select 2 pixel for Rect Borders
            int FooterRectWidth = FooterLength + 2;
            int FooterRectHeight = (3 / 2) * pdoc.DefaultPageSettings.Margins.Bottom;

            RectangleF rectForFooter = new RectangleF(FooterStratRectWidth,
                                                      FooterStratRectHeigth,
                                                      FooterRectWidth,
                                                      FooterRectHeight);

            e.Graphics.DrawString(footer,
                                  fontForHeaderAndFooter,
                                  brush,
                                  rectForFooter);

            #endregion

            #endregion

            int intLineCount = (int)(intPrintAreaHeight / font.Height);

            RectangleF rectPrintingArea = new RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight);

            StringFormat fmt = (Properties.Settings.Default.RightToLeft == true)
                             ? new StringFormat(StringFormatFlags.DirectionRightToLeft | StringFormatFlags.LineLimit)
                             : new StringFormat(StringFormatFlags.LineLimit);

            int intLinesFilled;
            int intCharsFitted;


            string TempforPrint = ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text.Substring(intCurrentChar);

            e.Graphics.MeasureString(TempforPrint,
                                     font,
                                     new SizeF(intPrintAreaWidth, intPrintAreaHeight),
                                     fmt,
                                     out intCharsFitted,
                                     out intLinesFilled);

            TempforPrint = ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text.Substring(intCurrentChar, intCharsFitted);

            e.Graphics.DrawString(TempforPrint,
                                  font,
                                  brush,
                                  rectPrintingArea,
                                  fmt);
            intCurrentChar += intCharsFitted;

            if (intCurrentChar < (this.CurrentTextBox.TextLength - 1))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                intCurrentChar = 0;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                PrintDialog dialog = new PrintDialog();
                dialog.Document = pdoc;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
        }

        private void tspPageSetup_Click(object sender, EventArgs e)
        {
            psd.Document = this.pdoc;
            psd.PageSettings = pdoc.DefaultPageSettings;

            if (psd.ShowDialog() == DialogResult.OK)
            {
                pdoc.DefaultPageSettings = psd.PageSettings;
            }
        }

        #endregion

        #region Saving Mthods

        private bool CheckWithOrginalContent(string TextForCheck, string OriginalFilePath)
        {
            return (TextForCheck.Equals(File.ReadAllText(OriginalFilePath)));
        }

        private void SafeFormClosingForAll()
        {

            this.IsDocumentHaveAnswer = false;

            while (TextFiles.Controls.Count > 0)
            {
                //image index 1 not saved
                if (this.TextFiles.SelectedTab.ImageIndex == 1)
                {
                    CustomizedTextBox Current = ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]);

                    if (Current.IsOriginalySaved)
                    {
                        if (CheckWithOrginalContent(Current.Text,
                                                    Current.TextBoxPath)) ;
                        else
                        {
                            switch (MessageBox.Show(("تغییرات فایل" + Environment.NewLine +
                                                 this.TextFiles.SelectedTab.Text + Environment.NewLine + "  ذخیره شوند؟ "),
                                                 "اخطار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None,
                                                 MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign))
                            {
                                case DialogResult.Yes:
                                    File.WriteAllText(Current.TextBoxPath,
                                                      Current.Text,
                                                      Encoding.Unicode);
                                    break;
                                case DialogResult.Cancel:
                                    return;
                            }
                        }
                    }
                    else if (Current.TextLength > 0)
                    {
                        switch (MessageBox.Show(("آیا می خواهید" + Environment.NewLine +
                                                                        this.TextFiles.SelectedTab.Text + Environment.NewLine + "  را ذخیره کنید؟"),
                                                                        "اخطار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None,
                                                                        MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign))
                        {
                            case DialogResult.OK:
                                saveAsToolStripMenuItem_Click(null, null);
                                break;
                            case DialogResult.Cancel:
                                return;
                        }
                    }
                    this.TextFiles.SelectedTab.Dispose();

                }
                else if (this.TextFiles.SelectedTab.ImageIndex == 0)
                {
                    this.TextFiles.SelectedTab.Dispose();
                }
                UpdateTheNumOfCharsTextBox();
            }

            if (this.TextFiles.TabCount == 0)
            {
                this.CurrentTextBox = null;
                this.NumberOfCharInEachText.Text = "Char's Count: ";
            }
        }

        private void SafeFormClosingForOne()
        {
            if (TextFiles.TabCount > 0)
            {
                this.IsDocumentHaveAnswer = false;

                if (((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).IsOriginalySaved)
                {
                    if (this.TextFiles.SelectedTab.ImageIndex == 1)
                    {
                        if (CheckWithOrginalContent(((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).Text,
                                                    ((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).TextBoxPath)) ;
                        else
                        {
                            switch (MessageBox.Show(("تغییرات فایل" + Environment.NewLine +
                                                 this.TextFiles.SelectedTab.Text + Environment.NewLine + "  ذخیره شوند؟ "),
                                                 "اخطار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None,
                                                 MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign))
                            {
                                case DialogResult.OK:
                                    File.WriteAllText(((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).TextBoxPath,
                                                      ((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).Text,
                                                      Encoding.Unicode);
                                    break;
                                case DialogResult.Cancel:
                                    return;
                            }

                        }
                    }
                }
                else if (((CustomizedTextBox)(TextFiles.SelectedTab.Controls[0])).TextLength > 0)
                {
                    switch (MessageBox.Show(("آیا می خواهید" + Environment.NewLine +
                                                                    this.TextFiles.SelectedTab.Text + Environment.NewLine + "  را ذخیره کنید؟"),
                                                                    "اخطار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None,
                                                                    MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign))
                    {
                        case DialogResult.OK:
                            saveAsToolStripMenuItem_Click(null, null);
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }

                this.TextFiles.SelectedTab.Dispose();

                UpdateTheNumOfCharsTextBox();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).IsOriginalySaved)
            {
                if (!((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved)
                {
                    File.WriteAllText(((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextBoxPath,
                                      ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text,
                                      Encoding.Unicode);
                    ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved = true;
                }
                this.TextFiles.SelectedTab.ImageIndex = (this.CurrentTextBox.Saved == true) ? 0 : 1;
            }
            else
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (SaveFiles.ShowDialog())
            {
                case DialogResult.OK:
                    File.WriteAllText(SaveFiles.FileName,
                                      ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text,
                                      Encoding.Unicode);
                    ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).ConvertToSaved(SaveFiles.FileName);
                    this.TextFiles.SelectedTab.Text = GetFileHeader("\\", SaveFiles.FileName);
                    break;
                case DialogResult.Cancel:
                    return;
            }

            this.TextFiles.SelectedTab.ImageIndex = (this.CurrentTextBox.Saved == true) ? 0 : 1;
        }

        #endregion

        #region Editing Methods In Menu's

        private void reloadFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
                if (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).IsOriginalySaved &&
                    !((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved)
                {
                    switch (MessageBox.Show("مطمئنی که میخوای سند جاری رو دوباره از فایلش بخونی" +
                                            Environment.NewLine +
                                            "اگه اینکارو بکنی همه تغییراتی که دادی میپره ها", "اخطار",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning,
                                            MessageBoxDefaultButton.Button2,
                                            MessageBoxOptions.RightAlign))
                    {
                        case DialogResult.OK:
                            ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text =
                                File.ReadAllText(((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextBoxPath);
                            ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved = true;
                            this.TextFiles.SelectedTab.ImageIndex = (this.CurrentTextBox.Saved == true) ? 0 : 1;
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }
        }

        private void ChangTextBoxContents()
        {

            if (this.TextFiles.TabCount > 0)
            {
                if (this._lastEditOperation.Equals("Del"))
                {
                    Cursor.Position = this._lastEditPoint;
                    ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Paste();
                    this._lastEditOperation = string.Empty;
                }
                else
                    ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Undo();

                if (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).IsOriginalySaved)
                {
                    if (CheckWithOrginalContent(((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Text,
                                                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextBoxPath))
                        ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved = true;
                    else
                        ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved = false;
                }
                this.TextFiles.SelectedTab.ImageIndex = (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved == true) ? 0 : 1;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangTextBoxContents();
        }

        private void CopyText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0 && this.CurrentTextBox.SelectedText.Length > 0)
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Copy();
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                this.CurrentTextBox.Paste();
                this._lastEditOperation = "Paste";
            }
        }

        private void DeleteText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0 &&
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength > 0 &&
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectedText.Length > 0)
            {
                this._lastEditOperation = "Del";
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Copy();
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectedText =
                                   ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectedText.Remove(0);
                this._lastEditPoint = Cursor.Position;
            }
        }

        private void CutText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0 && ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectedText.Length > 0)
            {
                this._lastEditOperation = "Cut";
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Cut();
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectAll();
            }
        }

        private void InsertTimeDate_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Paste(DateTime.Now.ToString());
            }
        }

        private void GotoLine_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.IsWordWrap)
            {
                GotoSeletionLine();
            }
        }

        private void GotoSeletionLine()
        {

        }

        private void FindText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0 && ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength > 0)
            {
                SearchFom FindFrom = new SearchFom(this);
                FindFrom.Show();
            }
        }

        #endregion

        #region App Setting Method

        private void TC_TextChanged(object sender, EventArgs e)
        {

            UpdateTheNumOfCharsTextBox();

            ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved = false;

            this.TextFiles.SelectedTab.ImageIndex = (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).Saved == true) ? 0 : 1;
        }

        private void TP_Focused(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                this.CurrentTextBox = (CustomizedTextBox)((TabPage)sender).Controls[0];
                ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectionLength = 0;
                this.TextFiles.SelectedTab.Controls[0].Focus();
            }
            this.IsDocumentHaveAnswer = false;
            UpdateTheNumOfCharsTextBox();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSelectDialog.Font = Properties.Settings.Default.FontOfTextFiles;

            if (fontSelectDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FontOfTextFiles = fontSelectDialog.Font;
                Properties.Settings.Default.Save();
                ChangeTabFonts();
            }
        }

        private void rightToLeftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RightToLeft = (!RighToLeftDirection.Checked && true);
            Properties.Settings.Default.Save();
            ChangeTextFilesRighToLeftDirection();
        }

        private void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RightToLeft = (LeftToRightDirection.Checked && true);
            Properties.Settings.Default.Save();
            ChangeTextFilesRighToLeftDirection();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsWordWrap = (!wordWrapToolStripMenuItem.Checked && true);
            Properties.Settings.Default.Save();
            statusBarToolStripMenuItem.Enabled = !Properties.Settings.Default.IsWordWrap;
            GotoLine.Enabled = !Properties.Settings.Default.IsWordWrap;
            ChangeTextFilesWordWrap();
        }

        /// <summary>
        /// chang the word wrap of text files if wordwrap from menu is changed
        /// or program run for first time and load the files
        /// </summary>
        private void ChangeTextFilesWordWrap()
        {

            wordWrapToolStripMenuItem.Checked = Properties.Settings.Default.IsWordWrap;
            foreach (TabPage ctrl in TextFiles.Controls)
                foreach (CustomizedTextBox txt in ctrl.Controls)
                    ((CustomizedTextBox)txt).WordWrap = Properties.Settings.Default.IsWordWrap;

        }

        /// <summary>
        /// chang the word wrap of text files if wordwrap from menu is changed
        /// or program run for first time and load the files
        /// </summary>
        private void ChangeTextFilesRighToLeftDirection()
        {

            RighToLeftDirection.Checked = Properties.Settings.Default.RightToLeft;
            LeftToRightDirection.Checked = !Properties.Settings.Default.RightToLeft;
            foreach (TabPage ctrl in TextFiles.Controls)
                foreach (CustomizedTextBox txt in ctrl.Controls)
                    ((CustomizedTextBox)txt).RightToLeft = (Properties.Settings.Default.RightToLeft)
                                                               ? RightToLeft.Yes : RightToLeft.No;

        }

        /// <summary>
        /// chang the font of text files
        /// </summary>
        private void ChangeTabFonts()
        {
            foreach (TabPage ctrl in TextFiles.Controls)
                foreach (CustomizedTextBox txt in ctrl.Controls)
                    txt.Font = Properties.Settings.Default.FontOfTextFiles;
        }

        private void UpdateTheNumOfCharsTextBox()
        {

            NumberOfCharInEachText.Text = (this.TextFiles.TabCount > 0) ?
                NumberOfCharInEachText.Text = "Char's Count:" + ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength :
                NumberOfCharInEachText.Text = "Char's Count: 0";
            Application.DoEvents();

        }

        #endregion

        #region Create Dynamic Controls Methods

        /// <summary>
        /// create a tab page and a text box with properties that list below
        /// Type == 1 --> unsaved
        /// t -- > 2 saved and required path
        /// </summary>
        private void CreateNewTab(int Type, string TextFilePath)
        {
            TabPage NewTabPage = new TabPage();
            CustomizedTextBox NewTextBoxInTabPage = null;

            if (Type == 1)
            {

                NewTabPage.Text = "New File " + (this._numOfUnNamedTabs++);
                NewTextBoxInTabPage = new CustomizedTextBox();

            }
            else if (Type == 2)
            {

                NewTextBoxInTabPage = new CustomizedTextBox(TextFilePath);
                NewTextBoxInTabPage.Text = File.ReadAllText(TextFilePath);
                NewTabPage.Text = GetFileHeader("\\", TextFilePath);

            }

            NewTabPage.ImageIndex = (NewTextBoxInTabPage.Saved == true) ? 0 : 1;

            NewTabPage.Name = "New Doc Content";
            NewTabPage.BackColor = Color.Honeydew;

            NewTextBoxInTabPage.Dock = DockStyle.Fill;
            NewTextBoxInTabPage.Multiline = true;
            NewTextBoxInTabPage.Name = "txtContent";
            NewTextBoxInTabPage.WordWrap = Properties.Settings.Default.IsWordWrap;
            NewTextBoxInTabPage.Font = Properties.Settings.Default.FontOfTextFiles;
            NewTextBoxInTabPage.ScrollBars = ScrollBars.Both;
            NewTextBoxInTabPage.AllowDrop = true;
            NewTextBoxInTabPage.SelectionLength = 0;
            NewTextBoxInTabPage.HideSelection = false;
            NewTextBoxInTabPage.AcceptsTab = true;

            this.NumberOfCharInEachText.Text = "Char's Count: " + NewTextBoxInTabPage.TextLength.ToString();

            if (Properties.Settings.Default.RightToLeft)
                NewTextBoxInTabPage.RightToLeft = RightToLeft.Yes;
            else
                NewTextBoxInTabPage.RightToLeft = RightToLeft.No;

            NewTabPage.Controls.Add(NewTextBoxInTabPage);
            NewTabPage.ToolTipText = NewTabPage.Text;

            TextFiles.Controls.Add(NewTabPage);
            TextFiles.SelectedIndex = TextFiles.Controls.GetChildIndex(NewTabPage);

            this.CurrentTextBox = NewTextBoxInTabPage;
            this.IsDocumentHaveAnswer = false;

            NewTabPage.Enter += new System.EventHandler(this.TP_Focused);
            NewTextBoxInTabPage.TextChanged += new EventHandler(this.TC_TextChanged);

        }

        /// <summary>
        /// return file name and separate from path
        /// </summary>
        /// <param name="Seprator">separator in path</param>
        /// <param name="OriginalString">path of file name consist of file name</param>
        /// <returns> file name without path detail or extension</returns>
        private string GetFileHeader(string Seprator, string OriginalString)
        {
            int indexOfFileName = OriginalString.LastIndexOf(Seprator) + 1;
            int FileNameWithoutExtention = OriginalString.Length;
            return OriginalString.Substring(indexOfFileName, FileNameWithoutExtention - indexOfFileName);
        }

        #endregion

        #region Other Event Handlers And Methods

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount == 0)
                CreateNewTab(1, "");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm_FormClosing(null, null);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTab(1, "");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFiles.ShowDialog() == DialogResult.OK)
            {
                foreach (string FileName in OpenFiles.FileNames)
                {
                    CreateNewTab(2, FileName);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ChangMenus();
            AboutMe About = new AboutMe();
            About.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e != null)
                e.Cancel = true;

            SafeFormClosingForAll();

            if (this.TextFiles.TabCount == 0)
                if (e != null)
                    e.Cancel = false;
                else
                    Application.Exit();

        }

        private void FindNextText_Click(object sender, EventArgs e)
        {
            if (this.IsDocumentHaveAnswer)
            {
                this.showNextSelection();
            }
            else
            {
                FindText_Click(null, null);
            }
        }

        private void ReplaceText_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0 && ((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength > 0)
            {
                ReplaceForm replaceForm = new ReplaceForm(this);
                replaceForm.Show();
            }
        }

        private void TextFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                SafeFormClosingForOne();
            }
        }

        private void closeAllTabsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeFormClosingForAll();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangMenus();
        }

        private void ChangMenus()
        {
            if (this.TextFiles.TabCount == 0)
            {

                UndoAction.Enabled =
                CutText.Enabled =
                PasteText.Enabled =
                CopyText.Enabled =
                FindNextText.Enabled =
                FindText.Enabled =
                ReplaceText.Enabled =
                DeleteText.Enabled =
                printToolStripMenuItem.Enabled =
                SelectAll.Enabled =
                InsertTimeDate.Enabled =
                GotoLine.Enabled = false;
            }
            else
            {
                SelectAll.Enabled = InsertTimeDate.Enabled = true;
                //undo
                UndoAction.Enabled = (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).CanUndo || this._lastEditOperation == "Del")
                                          ? true : false;
                //copy , dele , cut
                CopyText.Enabled = DeleteText.Enabled = CutText.Enabled =
                                          (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).SelectedText.Length > 0)
                                          ? true : false;
                //find , findnext , replace
                FindNextText.Enabled = FindText.Enabled = ReplaceText.Enabled =
                                          (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength > 0)
                                          ? true : false;
                //gotoline changed when word wrap is changed
                //print 
                printToolStripMenuItem.Enabled = (((CustomizedTextBox)this.TextFiles.SelectedTab.Controls[0]).TextLength > 0)
                                                 ? true : false;
                //paste
                PasteText.Enabled = (Clipboard.ContainsText(TextDataFormat.UnicodeText) ||
                                    Clipboard.ContainsText(TextDataFormat.UnicodeText))
                                    ? true : false;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangMenus();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangMenus();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangMenus();
        }

        private void tspCloseAll_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                SafeFormClosingForAll();
            }
        }

        private void tspClose_Click(object sender, EventArgs e)
        {
            if (this.TextFiles.TabCount > 0)
            {
                SafeFormClosingForOne();
            }
        }

        #endregion

    }
}