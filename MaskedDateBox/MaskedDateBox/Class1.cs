using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;



namespace MaskedDateBox
{
    public class MaskedDateBox : MaskedTextBox
    {
        public MaskedDateBox()
        {
            this.MouseWheel += new MouseEventHandler(MaskedDateBox_MouseWheel);
            this.Paint += new PaintEventHandler(MaskedDateBox_Paint);
            this.Click += new EventHandler(MaskedDateBox_Click);
            this.DoubleClick += new EventHandler(MaskedDateBox_DoubleClick);
            this.KeyPress += new KeyPressEventHandler(MaskedDateBox_KeyPress);
            this.KeyUp += new KeyEventHandler(MaskedDateBox_KeyUp);
            this.KeyDown += new KeyEventHandler(MaskedDateBox_KeyDown);
            this.Mask = "0000/00/00";
            this.PromptChar = '-';
        }
        //____________________________________________________________________________________________
        private string ToPersianNumbers(string text)
        {
            string output = "";
            foreach (char ch in text.ToCharArray())
                if (char.IsDigit(ch))
                    output += ((char)(int.Parse(ch.ToString()) + 1776));
                else
                    output += ch.ToString();
            return output;
        }


        private string ToWinNumbers(string text)
        {

            string output = "";
            foreach (char ch in text.ToCharArray())
                if ((int)ch >= 1776 && (int)ch < 1786)
                    output += ((int)((int)ch - 1776)).ToString();
                else
                    output += ch.ToString();
            return output;

        }


        //____________________________________________________________________________________________

        private void MaskedDateBox_Click(object sender, EventArgs e)
        {
            this.Select(this.SelectionStart, 1);
            if (this.SelectedText == "/")
            {
                this.SelectionStart = this.SelectionStart + 1;
            }
        }

        private void MaskedDateBox_DoubleClick(object sender, EventArgs e)
        {
            this.Select(this.SelectionStart, 1);
            if (this.SelectedText == "/")
            {
                this.SelectionStart = this.SelectionStart + 1;
            }
        }

        //------------------KeyPress---------------------------------------------------------------------------------------------------------------------------

        private void MaskedDateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                char[] ch = new char[10];

                string Mask = ToWinNumbers(this.Text.Replace("/", ""));
                for (int i = 0; i < Mask.Length; i++)
                    ch[i] = Mask[i];
                if (this.SelectionStart == 6 || this.SelectionStart == 9)
                {
                    for (int i = 0; i < this.SelectionStart - 1; i++)
                    {
                        int j = i;
                        if (i == 6)
                            --j;
                        else if (i == 9)
                            j -= 2;
                        if (!char.IsNumber(ch[j]) && i != 4 && i != 7)
                        {
                            this.SelectionStart = i;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= this.SelectionStart; i++)
                    {
                        if (i == 4 || i == 7)
                            ++i;
                        int j = i;
                        if (i == 6)
                            --j;
                        else if (i == 9)
                            j -= 2;
                        if (!char.IsNumber(ch[j]))
                        {
                            this.SelectionStart = i;
                            break;
                        }
                    }
                }
                //----------------Day---------------------------------------------------------------------
                try
                {
                    if (this.SelectionStart == 8)
                    {
                        ch[6] = (char)e.KeyChar;
                        string mo = ch[6].ToString() + ch[7].ToString();
                        if (Convert.ToInt32(mo) > 31)
                        {
                            // MessageBox.Show("خطاروز بزرگتر از 31", "");
                            ch[6] = this.PromptChar;
                            ch[7] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            //e.Handled = true;
                            this.SelectionStart = 9;
                            SendKeys.Send("{Left}");
                        }
                    }
                    else if (this.SelectionStart == 9)
                    {
                        ch[7] = (char)e.KeyChar;
                        if (!char.IsNumber(ch[6]))
                            ch[6] = '0';
                        if (ch[6] == '0' && ch[7] == '0')
                        {
                            ch[7] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            this.SelectionStart = 8;
                            this.Select(this.SelectionStart, 1);
                        }
                        else
                        {
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            this.SelectionStart = 10;
                        }
                        string mo = ch[6].ToString() + ch[7].ToString();
                        if (Convert.ToInt32(mo) > 31)
                        {
                            //MessageBox.Show("خطاروز بزرگتر از 31", "");
                            ch[6] = this.PromptChar;
                            ch[7] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            //e.Handled = true;
                            this.SelectionStart = 9;
                            SendKeys.Send("{Left}");
                        }
                    }
                }
                catch { }

                //------------------Month-----------------------------------------------------------
                try
                {
                    if (this.SelectionStart == 5)
                    {
                        ch[4] = (char)e.KeyChar;
                        string mo = ch[4].ToString() + ch[5].ToString();
                        if (Convert.ToInt32(mo) > 12)
                        {
                            // MessageBox.Show("خطا ماه بزرگتر از 12", "");
                            ch[4] = this.PromptChar;
                            ch[5] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            e.Handled = true;
                            this.SelectionStart = 6;
                            SendKeys.Send("{Left}");
                        }
                    }
                    else if (this.SelectionStart == 6)
                    {
                        ch[5] = (char)e.KeyChar;
                        if (!char.IsNumber(ch[4]))
                        {
                            ch[4] = '0';
                        }
                        if (ch[4] == '0' && ch[5] == '0')
                        {
                            ch[5] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            e.Handled = true;
                            this.SelectionStart = 8;
                            SendKeys.Send("{Left}");
                            return;
                        }
                        else if (ch[4] == '0')
                        {
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            this.SelectionStart = 9;
                            SendKeys.Send("{Left}");
                        }
                        string mo = ch[4].ToString() + ch[5].ToString();
                        if (Convert.ToInt32(mo) > 12)
                        {
                            //MessageBox.Show("خطا ماه بزرگتر از 12", "");
                            ch[4] = this.PromptChar;
                            ch[5] = this.PromptChar;
                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;
                            e.Handled = true;
                            this.SelectionStart = 6;
                            SendKeys.Send("{Left}");
                        }
                    }
                }
                catch { }
                //-------------------Year------------------------------------------------------------
                try
                {
                    if (this.SelectionStart == 3)
                    {
                        ch[3] = (char)e.KeyChar;
                        string mo = ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString();
                        if ((Convert.ToInt32(mo) > 1500 || Convert.ToInt32(mo) < 1300))
                        {
                            // MessageBox.Show("خطا ", "");
                            ch[0] = this.PromptChar;
                            ch[1] = this.PromptChar;
                            ch[2] = this.PromptChar;
                            ch[3] = this.PromptChar;

                            string MaskedTxt = ToPersianNumbers((ch[0].ToString() + ch[1].ToString() + ch[2].ToString() + ch[3].ToString() + ch[4].ToString() + ch[5].ToString() + ch[6].ToString() + ch[7].ToString()));
                            this.Text = MaskedTxt;
                            e.KeyChar = this.PromptChar;

                            this.SelectionStart = 0;
                            SendKeys.Send("{Left}");
                        }
                    }

                }

                catch { }
            }

            if ((int)e.KeyChar >= 48 && (int)e.KeyChar < 58)
                e.KeyChar = (char)(1776 + int.Parse(e.KeyChar.ToString()));
        }
        //---------------------------------------------------------------------------------------------------------------------------------

        private void MaskedDateBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8 || e.KeyValue == 37 || e.KeyValue == 38)
            {
                if (this.SelectionStart > 0)
                    this.Select(this.SelectionStart - 1, 1);
                if (this.SelectedText == "/")
                {
                    this.SelectionStart = this.SelectionStart - 1;
                }
            }
            else if (e.KeyValue == 39 || e.KeyValue == 40)
            {
                this.Select(this.SelectionStart - 1, 1);
                if (this.SelectedText == "/")
                {
                    this.SelectionStart = this.SelectionStart + 1;
                }
            }
            else
            {
                this.Select(this.SelectionStart, 1);
                if (this.SelectedText == "/")
                {
                    this.SelectionStart = this.SelectionStart + 1;
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        private void MaskedDateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                char[] ch = new char[10];

                string Mask = ToWinNumbers(this.Text.Replace("/", ""));
                for (int i = 0; i < Mask.Length; i++)
                    ch[i] = Mask[i];

            }

        }

        //-----------------Paint----------------------------------------------------
        private void MaskedDateBox_Paint(object sender, PaintEventArgs e)
        {

        }

        //------------------MouseWheel------------------------------------------------------
        private void MaskedDateBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta.Equals(120))
                SendKeys.Send("{Up}");

            else if (!e.Delta.Equals(120))

                SendKeys.Send("{Down}");
        }
        //------------------------------------------------------------------
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Back)
                return false;

            else
                return base.ProcessDialogKey(keyData);
        }
    }
}



