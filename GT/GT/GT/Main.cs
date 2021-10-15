using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.API.Translate;

namespace GT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void TranslateByGoogle(int from, int to)
        {
            Language LanguageFrom = Language.Unknown;
            Language LanguageTo = Language.Unknown;

            switch (from)
            {
                case 0: LanguageFrom = Language.Arabic;
                    break;
                case 1: LanguageFrom = Language.Bulgarian;
                    break;
                case 2: LanguageFrom = Language.Chinese;
                    break;
                case 3: LanguageFrom = Language.Croatian;
                    break;
                case 4: LanguageFrom = Language.Czech;
                    break;
                case 5: LanguageFrom = Language.Danish;
                    break;
                case 6: LanguageFrom = Language.Dutch;
                    break;
                case 7: LanguageFrom = Language.English;
                    break;
                case 8: LanguageFrom = Language.Finnish;
                    break;
                case 9: LanguageFrom = Language.French;
                    break;
                case 10: LanguageFrom = Language.German;
                    break;
                case 11: LanguageFrom = Language.Greek;
                    break;
                case 12: LanguageFrom = Language.Hindi;
                    break;
                case 13: LanguageFrom = Language.Italian;
                    break;
                case 14: LanguageFrom = Language.Japanese;
                    break;
                case 15: LanguageFrom = Language.Korean;
                    break;
                case 16: LanguageFrom = Language.Norwegian;
                    break;
                case 17: LanguageFrom = Language.Persian;
                    break;
                case 18: LanguageFrom = Language.Polish;
                    break;
                case 19: LanguageFrom = Language.Portuguese;
                    break;
                case 20: LanguageFrom = Language.Romanian;
                    break;
                case 21: LanguageFrom = Language.Russian;
                    break;
                case 22: LanguageFrom = Language.Spanish;
                    break;
                case 23: LanguageFrom = Language.Swedish;
                    break;
            }

            switch (to)
            {
                case 0: LanguageTo = Language.Arabic;
                    break;
                case 1: LanguageTo = Language.Bulgarian;
                    break;
                case 2: LanguageTo = Language.Chinese;
                    break;
                case 3: LanguageTo = Language.Croatian;
                    break;
                case 4: LanguageTo = Language.Czech;
                    break;
                case 5: LanguageTo = Language.Danish;
                    break;
                case 6: LanguageTo = Language.Dutch;
                    break;
                case 7: LanguageTo = Language.English;
                    break;
                case 8: LanguageTo = Language.Finnish;
                    break;
                case 9: LanguageTo = Language.French;
                    break;
                case 10: LanguageTo = Language.German;
                    break;
                case 11: LanguageTo = Language.Greek;
                    break;
                case 12: LanguageTo = Language.Hindi;
                    break;
                case 13: LanguageTo = Language.Italian;
                    break;
                case 14: LanguageTo = Language.Japanese;
                    break;
                case 15: LanguageTo = Language.Korean;
                    break;
                case 16: LanguageTo = Language.Norwegian;
                    break;
                case 17: LanguageTo = Language.Persian;
                    break;
                case 18: LanguageTo = Language.Polish;
                    break;
                case 19: LanguageTo = Language.Portuguese;
                    break;
                case 20: LanguageTo = Language.Romanian;
                    break;
                case 21: LanguageTo = Language.Russian;
                    break;
                case 22: LanguageTo = Language.Spanish;
                    break;
                case 23: LanguageTo = Language.Swedish;
                    break;
            }

            try
            {
                txtTo.Text = Translator.Translate(txtFrom.Text, LanguageFrom, LanguageTo);
            }
            catch (TranslateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == string.Empty)
            {
                MessageBox.Show("Enter something first.");
                txtFrom.Focus();
                return;
            }
            this.Enabled = false;
            TranslateByGoogle(cboFrom.SelectedIndex, cboTo.SelectedIndex);
            this.Enabled = true;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int i = cboFrom.SelectedIndex;
            cboFrom.SelectedIndex = cboTo.SelectedIndex;
            cboTo.SelectedIndex = i;
        }
    }
}
