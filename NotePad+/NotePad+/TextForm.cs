namespace NotePad_
{
    public partial class TextForm : System.Windows.Forms.Form
    {
        #region Fields...
        
        private string _pathFile;
        private bool _saveStatus;

        #endregion
        
        #region Properties...
        public string textData
        {
            get { return txtData.Text; }
            set { txtData.Text = value; }
        }

        public System.Drawing.Font fontData
        {
            get { return txtData.Font; }
            set { txtData.Font = value; }
        }

        public System.Windows.Forms.ScrollBars textScrollBar
        {
            get { return txtData.ScrollBars; }
            set { txtData.ScrollBars = value; }
        }

        public string selectedText
        {
            get { return txtData.SelectedText; }
            set { txtData.SelectedText = value; }
        }

        public string pathFile
        {
            get { return _pathFile; }
            set { _pathFile = value; }
        }

        public bool saveStatus
        {
            get { return _saveStatus; }
            set { _saveStatus = value; }
        }
        #endregion

        #region Methods...

        public void textCopy()
        {
            txtData.Copy();
        }

        public void textPaste()
        {           
           txtData.Paste();                     
        }

        public void textCut()
        {
            txtData.Cut();
        }

        public void textDelete()
        {
            txtData.SelectedText = txtData.SelectedText.Remove(0);
        }

        #endregion
                
        #region Constructors...
        public TextForm()
        {
            InitializeComponent();

            _saveStatus = false;
        }
        #endregion

        #region Application Event Handler...
        private void TextForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = true;
            
            System.Windows.Forms.DialogResult enmResult;
            
            enmResult = System.Windows.Forms.MessageBox.Show("Do you want to save your text?", "NotePad+", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Warning, System.Windows.Forms.MessageBoxDefaultButton.Button3);

            switch (enmResult)
	        {
		
                case System.Windows.Forms.DialogResult.Cancel:
                    break;

                case System.Windows.Forms.DialogResult.No:
                    {
                        e.Cancel = false;
                        break;
                    }

                case System.Windows.Forms.DialogResult.Yes:
                    {                        
                        if (!_saveStatus)
                        {
                            System.Windows.Forms.DialogResult enmResult2 = saveFileTextForm.ShowDialog();
                            if (enmResult2 == System.Windows.Forms.DialogResult.OK)
                            {
                                _pathFile = saveFileTextForm.FileName;
                                _writeToFileTextForm(_pathFile, textData);
                                
                                _saveStatus = true;
                            }
                        }
                        else
                            _writeToFileTextForm(_pathFile, textData);

                        e.Cancel = false;                      
                        break;
                    }
                
                default:
                    break;
	        }

            MainForm mainForm = (MainForm)MdiParent;
            if (mainForm.MdiChildren.Length == 1 && enmResult!=System.Windows.Forms.DialogResult.Cancel)
            {
                mainForm.changeStatusComboboxesToDisable();
                mainForm.setSomethingToDisable();
            }
        }

        
        private void TextForm_Enter(object sender, System.EventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;

            mainForm.fontNameComboBox.Text = txtData.Font.Name;
            mainForm.fontSizeComboBox.Text = txtData.Font.Size.ToString();
        }
        #endregion

        #region Methods...
        private void _writeToFileTextForm(string pathFile, string textData)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(pathFile);
            writer.Write(textData);
            writer.Flush();
            writer.Close();
        }
        #endregion
                
    }
}
