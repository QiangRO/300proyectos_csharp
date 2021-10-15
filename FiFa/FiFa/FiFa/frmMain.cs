using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace FiFa
{
    public partial class frmMain : Form
    {
        enum Language { English, Farsi }
        enum SourceControl { MainText, TranslatedText }

        Font font = null;
        Language currentLanguage = Language.Farsi;
        SourceControl source = SourceControl.TranslatedText;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                TextReader tr = new StreamReader(Environment.CurrentDirectory + "\\Language.dat");
                if (tr.ReadToEnd() == "English")
                {
                    ChangeLanguage(Language.English);
                    currentLanguage = Language.English;
                }
                else
                {
                    ChangeLanguage(Language.Farsi);
                    currentLanguage = Language.Farsi;
                }
                tr.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (currentLanguage == Language.English)
            {
                frmAbout about = new frmAbout();
                about.ShowDialog();
            }
            else if (currentLanguage == Language.Farsi)
            {
                frmAbout2 about2 = new frmAbout2();
                about2.ShowDialog();
            }

            label1.Focus();
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "آماده";
            else if (currentLanguage == Language.English)
                statusLabel.Text = "Ready";
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentLanguage == Language.Farsi)
            {
                if (MessageBox.Show("آیا مایلید از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            else if (currentLanguage == Language.English)
            {
                if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8);
                tw.Write(translatedText.Text);
                tw.Close();

                if (currentLanguage == Language.Farsi)
                {
                    MessageBox.Show("متن ترجمه شده ذخیره شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    translatedText.Clear();
                    mainText.Clear();
                    mainText.Focus();
                }
                else if (currentLanguage == Language.English)
                {
                    MessageBox.Show("Text translated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    translatedText.Clear();
                    mainText.Clear();
                    mainText.Focus();
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
            {
                if (MessageBox.Show("آیا مایلید از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            else if (currentLanguage == Language.English)
            {
                if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (source == SourceControl.MainText)
                mainText.Cut();
            else
                translatedText.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (source == SourceControl.MainText)
                mainText.Copy();
            else
                translatedText.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (source == SourceControl.MainText)
                mainText.Paste();
            else
                translatedText.Paste();
        }

        private void mnuClearMainText_Click(object sender, EventArgs e)
        {
            mainText.Clear();
        }

        private void mnuClearTranslatedText_Click(object sender, EventArgs e)
        {
            translatedText.Clear();
            mainText.Focus();
        }

        private void mnuSelecAllMainText_Click(object sender, EventArgs e)
        {
            mainText.Focus();
            mainText.SelectAll();
            source = SourceControl.MainText;
        }

        private void mnuSelectAllTranslatedText_Click(object sender, EventArgs e)
        {
            translatedText.Focus();
            translatedText.SelectAll();
            source = SourceControl.TranslatedText;
        }

        private void mnuFarsi_Click(object sender, EventArgs e)
        {
            SetLanguage(Language.Farsi);
            ChangeLanguage(Language.Farsi);
            currentLanguage = Language.Farsi;
        }

        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            SetLanguage(Language.English);
            ChangeLanguage(Language.English);
            currentLanguage = Language.English;
        }

        private void mnuHowToUse_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
            {
                statusLabel.Text = "آماده";
                frmAbout2 about = new frmAbout2();
                about.ShowDialog();
            }
            else
            {
                statusLabel.Text = "Ready";
                frmAbout about = new frmAbout();
                about.ShowDialog();
            }
        }

        private void mnuFile_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuSaveAs_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "ذخیره متن ترجمه شده با یک نام دلخواه";
            else
                statusLabel.Text = "Saves the translated text with a new name";
        }

        private void mnuExit_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "خروج از برنامه";
            else
                statusLabel.Text = "Exit of program";
        }

        private void mnuEdit_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuCut_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "برش متن انتخاب شده و انتقال آن به کلیپ برد";
            else
                statusLabel.Text = "Cuts the selection and puts it on the clipboard";
        }

        private void mnuCopy_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "کپی کردن متن انتخاب شده و انتفال آن به کلیپ برد";
            else
                statusLabel.Text = "Copies the selection and puts it on the clipboard";
        }

        private void mnuPaste_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "اضافه کردن یک متن از کلیپ برد به متن ترجمه شده";
            else
                statusLabel.Text = "Inserts clipboard contents";
        }

        private void mnuClear_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuClearMainText_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "پاک کردن متن شما";
            else
                statusLabel.Text = "Clear your text";
        }

        private void mnuClearTranslatedText_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "پاک کردن متن ترجمه شده";
            else
                statusLabel.Text = "Clear translated text";
        }

        private void mnuSelectAll_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuSelecAllMainText_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "انتخاب کل متن شما";
            else
                statusLabel.Text = "SelectAll your text";
        }

        private void mnuSelectAllTranslatedText_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "انتخاب کل متن ترجمه شده";
            else
                statusLabel.Text = "SelectAll translated text";
        }

        private void mnuLanguage_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuFarsi_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "تغییر زبان به فارسی";
            else
                statusLabel.Text = "Change language to Farsi";
        }

        private void mnuEnglish_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "تغییر زبان به انگلیسی";
            else
                statusLabel.Text = "Change language to English";
        }

        private void mnuHelp_Select(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void mnuHowToUse_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "راهنمای استفاده از برنامه";
            else
                statusLabel.Text = "Help for program";
        }

        private void mnuAbout_Select(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "اطلاعاتی درباره برنامه و نحوه برقراری ارتباط با برنامه نویس";
            else
                statusLabel.Text = "The information about program and how to contact me!";
        }
        
        private void mainText_TextChanged(object sender, EventArgs e)
        {
            if (translatedText.ForeColor == Color.Gray)
            {
                translatedText.ForeColor = Color.Black;
                translatedText.Clear();
            }

            if (mainText.Text.Length > 0)
                newLine.Enabled = true;
            else
                newLine.Enabled = false;

            previewText.Text = Convertor.ConvertToFinglish(mainText.Text.TrimStart(' '));
        }
        
        private void mainText_Click(object sender, EventArgs e)
        {
            if (mainText.ForeColor == Color.Gray)
            {
                mainText.Clear();
                mainText.ForeColor = Color.Black;
                mainText.Font = new Font("Tahoma", 8.25F);
            }
        }

        private void mainText_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "متن خود را اینجا تایپ کنید";
            else
                statusLabel.Text = "Enter your text here";
        }

        private void mainText_MouseLeave(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "آماده";
            else
                statusLabel.Text = "Ready";
        }

        private void translatedText_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "متن ترجمه شده اینجا قرار می گیرد (اینکار توسط برنامه انجام خواهد شد)";
            else
                statusLabel.Text = "Here is location for translated text (This fill by program)";
        }

        private void translatedText_MouseLeave(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "آماده";
            else
                statusLabel.Text = "Ready";
        }

        private void translatedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                newLine_Click(sender, e);
        }

        private void newLine_Click(object sender, EventArgs e)
        {
            translatedText.Text += Convertor.ConvertToFinglish(mainText.Text.TrimStart(' '));
            mainText.Clear();
            translatedText.Text = translatedText.Text + "\r\n";
            mainText.Focus();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog.Font;
                translatedText.Font = fontDialog.Font;
            }
        }

        private void newLine_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "خط جدید ایجاد کنید";
            else if (currentLanguage == Language.English)
                statusLabel.Text = "Enter new line";
        }

        private void newLine_MouseLeave(object sender, EventArgs e)
        {
            if (currentLanguage == Language.Farsi)
                statusLabel.Text = "آماده";
            else if (currentLanguage == Language.English)
                statusLabel.Text = "Ready";
        }

        void ChangeLanguage(Language language)
        {
            if (language == Language.English)
            {
                mnuFile.Text = "File";
                mnuSaveAs.Text = "Save As...";
                mnuExit.Text = "Exit";
                mnuEdit.Text = "Edit";
                mnuCut.Text = "Cut";
                mnuCopy.Text = "Copy";
                mnuPaste.Text = "Paste";
                mnuClear.Text = "Clear";
                mnuClearMainText.Text = "Your Text";
                mnuClearTranslatedText.Text = "Translated Text";
                mnuSelectAll.Text = "SelectAll";
                mnuSelecAllMainText.Text = "Your Text";
                mnuSelectAllTranslatedText.Text = "Translated Text";
                mnuLanguage.Text = "Language";
                mnuFarsi.Text = "Farsi";
                mnuEnglish.Text = "English";
                mnuHelp.Text = "Help";
                mnuHowToUse.Text = "How To Use?";
                mnuAbout.Text = "About This Program";
                newLine.Text = "New Line";

                statusStrip1.RightToLeft = RightToLeft.No;
                statusLabel.Text = "Ready";

                mnuEnglish.Checked = true;
                mnuFarsi.Checked = false;
            }
            else if (language == Language.Farsi)
            {
                mnuFile.Text = "فایل";
                mnuSaveAs.Text = "ذخیره متن";
                mnuExit.Text = "خروج از برنامه";
                mnuEdit.Text = "متن";
                mnuCut.Text = "برش";
                mnuCopy.Text = "کپی";
                mnuPaste.Text = "چسباندن";
                mnuClear.Text = "پاک کردن";
                mnuClearMainText.Text = "متن شما";
                mnuClearTranslatedText.Text = "متن ترجمه شده";
                mnuSelectAll.Text = "انتخاب کل";
                mnuSelecAllMainText.Text = "متن شما";
                mnuSelectAllTranslatedText.Text = "متن ترجمه شده";
                mnuLanguage.Text = "زبان";
                mnuFarsi.Text = "فارسی";
                mnuEnglish.Text = "انگلیسی";
                mnuHelp.Text = "راهنما";
                mnuHowToUse.Text = "راهنمای استفاده از برنامه";
                mnuAbout.Text = "درباره این برنامه";
                newLine.Text = "برو به سر خط";

                statusStrip1.RightToLeft = RightToLeft.Yes;
                statusLabel.Text = "آماده";

                mnuEnglish.Checked = false;
                mnuFarsi.Checked = true;
            }
        }

        void SetLanguage(Language proLanguage)
        {
            if (proLanguage == Language.English)
            {
                try
                {
                    TextWriter tw = new StreamWriter(Environment.CurrentDirectory + "\\Language.dat");
                    tw.Write("English");
                    tw.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else if (proLanguage == Language.Farsi)
            {
                try
                {
                    TextWriter tw = new StreamWriter(Environment.CurrentDirectory + "\\Language.dat");
                    tw.Write("Farsi");
                    tw.Close();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}
