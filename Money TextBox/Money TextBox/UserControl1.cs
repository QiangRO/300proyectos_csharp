using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Money_TextBox
{
    public partial class moneyTxtBx : TextBox
    {
        /// <summary>
        /// Initialize the TextBox
        /// </summary>
        public moneyTxtBx()
        {
            InitializeComponent();
            strCrncySymbol = "ریال";
            strCrncyGrpSep = ",";
            base.RightToLeft = RightToLeft.Yes;
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value != null)
                {
                    // del strCrncySymbol = "ریال" if exist
                    if (value.IndexOf(strCrncySymbol) > 0)
                    {
                        value = value.Replace(strCrncySymbol, String.Empty);
                    }

                    // del strCrncyGrpSep = ","  if exist
                    if (value.IndexOf(strCrncyGrpSep) > 0)
                    {
                        value = value.Replace(strCrncyGrpSep, String.Empty);
                    }
                }
                // convert value to "#,#" style without decimal point 
                decimal d;
                decimal.TryParse(value, out d);
                value = d.ToString("#,#");

                //add strCrncySymbol = "ریال" to value
                value = value.Insert(value.Length, strCrncySymbol);

                base.Text = value;
            }
        }

        public override RightToLeft RightToLeft
        {
            get
            {
                return base.RightToLeft;
            }
            set
            {
                base.RightToLeft = value;
            }
        }

        /// <summary>
        /// CurrencySymbol for Money
        /// default is "ریال"
        /// </summary>
        private string strCrncySymbol;

        public string CurrencySymbol
        {
            get { return strCrncySymbol; }
            set { strCrncySymbol = value.Trim(); }
        }

        /// <summary>
        /// CurrencyGroupSeparator for Money
        /// default is ","
        /// </summary>
        private string strCrncyGrpSep;

        public string CurrencyGroupSeparator
        {
            get { return strCrncyGrpSep; }
            set { strCrncyGrpSep = value.Trim(); }
        }


        /// <summary>
        /// the value of TextBox that dosnt have "CurrencyGroupSeparator" and "CurrencySymbol"
        /// to do calculation with it you should casting it
        /// </summary>
        private static string strValue;

        public string Value
        {
            get
            {
                return base.Text.Replace(strCrncyGrpSep, string.Empty).Replace(strCrncySymbol, string.Empty);
            }
        }

        /// <summary>
        /// Overrided method OnEnter that Select all text on TextBox when focus enter
        /// </summary>
        /// <param name="e"></param>
        protected override void OnEnter(EventArgs e)
        {
            base.SelectAll();
        }

        /// <summary>
        /// Overrided method Click that Select all text on TextBox when TextBox Clicked
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.SelectAll();
        }
        /// <summary>
        /// Overrided method OnLeave that add "CurrencySymbol" and "CurrencyGroupSeparator" to text in TextBox
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            // del strCrncySymbol = "ریال" if exist
            if (base.Text.IndexOf(strCrncySymbol) > 0)
            {
                base.Text = base.Text.Replace(strCrncySymbol, String.Empty);
            }

            // del strCrncyGrpSep = ","  if exist
            if (base.Text.IndexOf(strCrncyGrpSep) > 0)
            {
                base.Text = base.Text.Replace(strCrncyGrpSep, String.Empty);
            }

            // convert value to "#,#" style without decimal point
            decimal d;
            decimal.TryParse(base.Text, out d);
            base.Text = d.ToString("#,#");

            //add strCrncySymbol = "ریال" to value            
            base.Text = base.Text.Insert(base.Text.Length, strCrncySymbol);   
            
            //if ((base.Text.IndexOf(strCrncySymbol) == -1) && (base.Text.IndexOf(strCrncyGrpSep) == -1) && (!string.IsNullOrEmpty(base.Text)) && (base.Text.IndexOf('.') == -1))
            //{
            //    NumberFormatInfo nfi = new NumberFormatInfo();
            //    nfi.CurrencyDecimalDigits = 0;
            //    nfi.CurrencyGroupSeparator = strCrncyGrpSep;
            //    base.Text = decimal.Parse(base.Text, NumberStyles.AllowThousands).ToString("#" + strCrncyGrpSep + "#", nfi);
            //    base.Text = base.Text.Insert(base.Text.Length, strCrncySymbol);
            //}
            //else
            //    base.Clear();
        }

        /// <summary>
        /// Overrided method KeyPress that only allow  user to enter Digit value and Control key
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) ? false : true;
        }


    }
}