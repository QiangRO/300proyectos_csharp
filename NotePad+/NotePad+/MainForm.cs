namespace NotePad_
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        #region Properties...

        public System.Windows.Forms.ToolStripComboBox fontNameComboBox
        {
            get { return cmbFontName; }
            set { cmbFontName = value; }
        }

        public System.Windows.Forms.ToolStripComboBox fontSizeComboBox
        {
            get { return cmbFontSize; }
            set { cmbFontSize = value; }
        }
        #endregion

        #region Constructors...
        public MainForm()
        {
            InitializeComponent();

            assignComboboxesToData();

            changeStatusComboboxesToDisable();

            setSomethingToDisable();



        }

        #endregion

        #region Application Event Handler...
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true).SetValue("BeRMOoDA Notebook", Application.ExecutablePath, Microsoft.Win32.RegistryValueKind.String);


            Program.splashForm.Refresh();


            //Load Main Form
            System.Threading.Thread.Sleep(3000);


            //End Load

            Program.splashForm.Close();
        }

        #region File Menu...

        private void itmNew_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = new TextForm();
            documentForm.MdiParent = this;
            documentForm.Text = "Untitled"+(this.MdiChildren.Length - 1).ToString();
            documentForm.Show();

            capsLockStatus();
            changeStatusComboboxesToEnable();
            setSomethingToEnable();
        }

        private void itmOpen_Click(object sender, System.EventArgs e)
        {
            string path;

            openFile.Multiselect = false;


            System.Windows.Forms.DialogResult enmResult = openFile.ShowDialog();

            if (enmResult == System.Windows.Forms.DialogResult.OK)
            {
                path = openFile.FileName;

                System.IO.StreamReader reader = new System.IO.StreamReader(path);

                TextForm documentForm = new TextForm();
                documentForm.MdiParent = this;
                documentForm.textData = reader.ReadToEnd();
                documentForm.Text = openFile.SafeFileName;
                //documentForm.saveStatus = true;
                documentForm.pathFile = path;
                documentForm.Show();

                setSomethingToEnable();
            }

            capsLockStatus();
        }

        private void itmSave_Click(object sender, System.EventArgs e)
        {

            TextForm documentForm = (TextForm)ActiveMdiChild;

            saveFile.FileName = documentForm.Text + ".txt";

            if (!documentForm.saveStatus)
            {
                System.Windows.Forms.DialogResult enmResult = saveFile.ShowDialog();
                if (enmResult == System.Windows.Forms.DialogResult.OK)
                {
                    documentForm.pathFile = saveFile.FileName;
                    documentForm.Text = saveFile.FileName;
                    _writeToFile(documentForm.pathFile, documentForm.textData);
                    documentForm.saveStatus = true;
                }
            }
            else
                _writeToFile(documentForm.pathFile, documentForm.textData);

        }

        private void itmSaveAz_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            saveFile.FileName = documentForm.Text + ".txt";

            System.Windows.Forms.DialogResult enmResult = saveFile.ShowDialog();
                        
            if (enmResult == System.Windows.Forms.DialogResult.OK)
            {
                documentForm.pathFile = saveFile.FileName;
                documentForm.Text = saveFile.FileName;
                _writeToFile(documentForm.pathFile, documentForm.textData);
            }

        }

        private void itmExit_Click(object sender, System.EventArgs e)
        {
            int mdiChildrenLenght = this.MdiChildren.Length;

            if (mdiChildrenLenght != 0)
            {
                for (int i = 0; i < mdiChildrenLenght; i++)
                {
                    TextForm documentForm = (TextForm)ActiveMdiChild;

                    documentForm.Close();
                }
            }
            System.Windows.Forms.Application.Exit();
        }


        #endregion

        #region Edit Menu...
        private void editToolStripMenuItem_DropDownOpening(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            if (documentForm != null && documentForm.selectedText != "")
            {
                itmCopy.Enabled = true;
                itmCut.Enabled = true;
                itmDelete.Enabled = true;
            }
            else
            {
                itmCopy.Enabled = false;
                itmCut.Enabled = false;
                itmDelete.Enabled = false;
            }
        }

        private void itmCut_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            documentForm.textCut();
        }

        private void itmCopy_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            documentForm.textCopy();
            itmPaste.Enabled = true;
        }

        private void itmPaste_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            documentForm.textPaste();
        }

        private void itmDelete_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            documentForm.textDelete();
        }

        #endregion

        #region Format Menu...
        private void itmFont_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            System.Windows.Forms.DialogResult enmResult = fontDialog.ShowDialog();
            if (enmResult == System.Windows.Forms.DialogResult.OK)
            {
                documentForm.fontData = fontDialog.Font;
            }
        }

        private void itmWordWrap_Click(object sender, System.EventArgs e)
        {
            TextForm documentForm = (TextForm)ActiveMdiChild;

            if (!itmWordWrap.Checked)
            {
                itmWordWrap.Checked = !itmWordWrap.Checked;
                documentForm.textScrollBar = System.Windows.Forms.ScrollBars.Vertical;
            }
            else
            {
                itmWordWrap.Checked = !itmWordWrap.Checked;
                documentForm.textScrollBar = System.Windows.Forms.ScrollBars.Both;
            }
        }
        #endregion

        #region Window Menu...
        private void itmTileHorizontal_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void itmTileVertical_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void itmCascade_Click(object sender, System.EventArgs e)
        {
            LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        #endregion

        #region Font And Size Tool Strip Menu...

        private void cmbFontName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            float size = 8;

            if ((TextForm)ActiveMdiChild != null)
            {
                TextForm documentForm = (TextForm)ActiveMdiChild;

                size = documentForm.fontData.Size;
            }

            setFontAndSizeToText(size);
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            float size;
            size = int.Parse(cmbFontSize.Items[cmbFontSize.SelectedIndex].ToString());

            setFontAndSizeToText(size);
        }


        #endregion

        #endregion

        #region Methods...
        public void _writeToFile(string pathFile, string textData)
        {

            System.IO.StreamWriter writer = new System.IO.StreamWriter(pathFile);
            writer.Write(textData);
            writer.Flush();
            writer.Close();
        }

        public void assignComboboxesToData()
        {
            System.Drawing.FontFamily[] fontNames = System.Drawing.FontFamily.Families;
            for (int i = 0; i < fontNames.Length; i++)
            {
                cmbFontName.Items.Add(fontNames[i].Name);

            }
            cmbFontName.Text = fontNames[0].Name;

            float[] fontSize = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            for (int i = 0; i < fontSize.Length; i++)
            {
                cmbFontSize.Items.Add(fontSize[i]);
            }
            cmbFontSize.Text = fontSize[0].ToString();

        }

        public void changeStatusComboboxesToEnable()
        {
            cmbFontName.Enabled = true;
            cmbFontSize.Enabled = true;
        }

        public void changeStatusComboboxesToDisable()
        {
            cmbFontName.Enabled = false;
            cmbFontSize.Enabled = false;
        }

        public void setFontAndSizeToText(float size)
        {
            System.Drawing.Font font = null;
            System.Drawing.FontFamily[] fontNames = System.Drawing.FontFamily.Families;

            if (fontNames[cmbFontName.SelectedIndex].IsStyleAvailable(System.Drawing.FontStyle.Regular))
                font = new System.Drawing.Font(
                    fontNames[cmbFontName.SelectedIndex].Name,
                    size
                    );
            else if (fontNames[cmbFontName.SelectedIndex].IsStyleAvailable(System.Drawing.FontStyle.Bold))
                font = new System.Drawing.Font(
                    fontNames[cmbFontName.SelectedIndex].Name,
                    size,
                    System.Drawing.FontStyle.Bold
                    );
            else if (fontNames[cmbFontName.SelectedIndex].IsStyleAvailable(System.Drawing.FontStyle.Italic))
                font = new System.Drawing.Font(
                    fontNames[cmbFontName.SelectedIndex].Name,
                    size,
                    System.Drawing.FontStyle.Italic
                    );
            else if (fontNames[cmbFontName.SelectedIndex].IsStyleAvailable(System.Drawing.FontStyle.Strikeout))
                font = new System.Drawing.Font(
                    fontNames[cmbFontName.SelectedIndex].Name,
                    size,
                    System.Drawing.FontStyle.Strikeout
                    );
            else if (fontNames[cmbFontName.SelectedIndex].IsStyleAvailable(System.Drawing.FontStyle.Underline))
                font = new System.Drawing.Font(
                   fontNames[cmbFontName.SelectedIndex].Name,
                   size,
                   System.Drawing.FontStyle.Underline
                   );

            TextForm documentForm = (TextForm)ActiveMdiChild;

            if (documentForm != null)
            {
                documentForm.fontData = font;
            }
        }

        public void setSomethingToDisable()
        {
            itmSave.Enabled = false;
            itmSaveAz.Enabled = false;

            itmCut.Enabled = false;
            itmCopy.Enabled = false;
            itmDelete.Enabled = false;
            itmPaste.Enabled = false;

            itmWordWrap.Enabled = false;
            itmFont.Enabled = false;

            itmTileHorizontal.Enabled = false;
            itmTileVertical.Enabled = false;
            itmCascade.Enabled = false;
        }

        public void setSomethingToEnable()
        {
            itmSave.Enabled = true;
            itmSaveAz.Enabled = true;

            itmWordWrap.Enabled = true;
            itmFont.Enabled = true;

            itmTileHorizontal.Enabled = true;
            itmTileVertical.Enabled = true;
            itmCascade.Enabled = true;
        }

        private void capsLockStatus()
        {
            if (System.Windows.Forms.Control.IsKeyLocked(System.Windows.Forms.Keys.CapsLock))
            {
                notifyForCapsLock.BalloonTipText = "The Caps Lock key is ON.";
                notifyForCapsLock.BalloonTipTitle = "Information!";
                notifyForCapsLock.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;

                notifyForCapsLock.ShowBalloonTip(10000);
            }

        }
        #endregion

    }  
}                           
    
