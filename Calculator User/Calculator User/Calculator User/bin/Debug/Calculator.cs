using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Calculator_User
{
    [ToolboxBitmap("C:\\Calculator.jpg")]

    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            cal = "";
            num = "";
            flag_dat = false;
        }

        #region Set Input Character

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBox.Capture == false)
                e.Handled = true;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) && flag_dat == false)
                {
                    flag_dat = true;
                    if (textBox.Text == "0.")
                    {
                        cal = "0.";
                    }
                    else if (cal == "")
                    {
                        cal = cal + "0.";
                        textBox.Text = "0.";
                    }
                    else
                    {
                        cal = cal + ".";
                    }
                }

                if ((e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) && flag_dat == true)
                {
                    cal = cal + "0";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) && flag_dat == true)
                {
                    cal = cal + "1";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) && flag_dat == true)
                {
                    cal = cal + "2";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) && flag_dat == true)
                {
                    cal = cal + "3";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) && flag_dat == true)
                {
                    cal = cal + "4";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) && flag_dat == true)
                {
                    cal = cal + "5";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) && flag_dat == true)
                {
                    cal = cal + "6";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) && flag_dat == true)
                {
                    cal = cal + "7";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) && flag_dat == true)
                {
                    cal = cal + "8";
                    textBox.Text = cal;
                }
                if ((e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) && flag_dat == true)
                {
                    cal = cal + "9";
                    textBox.Text = cal;
                }

                if ((e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "0";
                        textBox.Text = cal + ".";
                    }
                }
                if ((e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "1";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "1";
                        textBox.Text = "1.";
                    }
                }
                if ((e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "2";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "2";
                        textBox.Text = "2.";
                    }
                }
                if ((e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "3";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "3";
                        textBox.Text = "3.";
                    }
                }
                if ((e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "4";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "4";
                        textBox.Text = "4.";
                    }
                }
                if ((e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "5";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "5";
                        textBox.Text = "5.";
                    }
                }
                if ((e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "6";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "6";
                        textBox.Text = "6.";
                    }
                }
                if ((e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "7";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "7";
                        textBox.Text = "7.";
                    }
                }
                if ((e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "8";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "8";
                        textBox.Text = "8.";
                    }
                }
                if ((e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) && flag_dat == false)
                {
                    if (textBox.Text != "0.")
                    {
                        cal = cal + "9";
                        textBox.Text = cal + ".";
                    }
                    else
                    {
                        cal = "9";
                        textBox.Text = "9.";
                    }
                }
                if (e.KeyCode == Keys.Back && flag_dat == false && textBox.Text != "0.")
                {

                    int len = cal.Length;

                    if (len > 1)
                    {
                        cal = cal.Substring(0, (len - 1));
                        textBox.Text = cal + ".";
                    }
                    if (len == 1)
                    {
                        cal = "";
                        textBox.Text = "0.";
                    }
                }
                if (e.KeyCode == Keys.Back && flag_dat == true)
                {
                    int len = cal.Length;
                    char dat;
                    dat = cal[len - 1];
                    if (dat != '.')
                    {
                        cal = cal.Substring(0, (len - 1));
                        textBox.Text = cal;
                        if (cal[cal.Length - 1] == '.')
                        {
                            cal = cal.Substring(0, (cal.Length - 1));
                            flag_dat = false;
                        }
                    }
                }
                if (e.KeyCode == Keys.Subtract)
                {
                    Subtract_method();
                }
                if ((e.Shift && e.KeyCode == Keys.Oemplus) || e.KeyCode == Keys.Add)
                {
                    Add_method();
                }
                if (e.KeyCode == Keys.Multiply)
                {
                    multiply_method();
                }
                if (e.KeyCode == Keys.Divide)
                {
                    Divide_method();
                }
                if (e.KeyCode == Keys.Return)
                {
                    equals_method();
                }
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void InputStr0(string str)
        {
            if (flag_dat == true)
            {
                cal = cal + str;
                textBox.Text = cal;
            }

            if (flag_dat == false)
            {
                if (textBox.Text != "0.")
                {
                    cal = cal + str;
                    textBox.Text = cal + ".";
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            InputStr0("0");
        }

        private void button_00_Click(object sender, EventArgs e)
        {
            InputStr0("00");
        }

        private void button_000_Click(object sender, EventArgs e)
        {
            InputStr0("000");
        }

        private void InputStr(string str)
        {
            if (flag_dat == true)
            {
                cal = cal + str;
                textBox.Text = cal;
            }
            if (flag_dat == false)
            {
                if (textBox.Text != "0.")
                {
                    cal = cal + str;
                    textBox.Text = cal + ".";
                }
                else
                {
                    cal = str;
                    textBox.Text = str + ".";
                }
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            InputStr("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            InputStr("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            InputStr("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            InputStr("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            InputStr("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            InputStr("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            InputStr("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            InputStr("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            InputStr("9");
        }

        private void button_dat_Click(object sender, EventArgs e)
        {
            if (flag_dat == false)
            {
                flag_dat = true;
                if (textBox.Text == "0.")
                {
                    cal = "0.";
                }
                else if (cal == "")
                {
                    cal = cal + "0.";
                    textBox.Text = "0.";
                }
                else
                {
                    cal = cal + ".";
                }
            }
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            flag_dat = false;
            cal = "";
            num = "";
            sign_str = "";
            textBox.Text = "0.";
        }

        private void ce_button_Click(object sender, EventArgs e)
        {
            flag_dat = false;
            cal = "";
            textBox.Text = "0.";
        }

        private void Backspace_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag_dat == false && textBox.Text != "0.")
                {

                    int len = cal.Length;

                    if (len > 1)
                    {
                        cal = cal.Substring(0, (len - 1));
                        textBox.Text = cal + ".";
                    }
                    if (len == 1)
                    {
                        cal = "";
                        textBox.Text = "0.";
                    }
                }
                if (flag_dat == true)
                {
                    int len = cal.Length;
                    char dat;
                    dat = cal[len - 1];
                    if (dat != '.')
                    {
                        cal = cal.Substring(0, (len - 1));
                        textBox.Text = cal;
                        if (cal[cal.Length - 1] == '.')
                        {
                            cal = cal.Substring(0, (cal.Length - 1));
                            flag_dat = false;
                        }
                    }
                }
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_subtract_Click(object sender, EventArgs e)
        {
            Subtract_method();
        }

        private void Subtract_method()
        {
            float num2 = 0;
            flag_dat = false;

            if (sign_str == "&")
            {
                if (textBox.Text == num || textBox.Text == (num + "."))
                {
                    sign_str = "-";
                }
                else
                {
                    num = "";
                }
            }
            try
            {
                if (num != "" && cal != "" && sign_str != "-")
                {
                    equals_method();
                    sign_str = "-";
                }

                else if (num == "" && cal != "")
                {
                    num = cal;
                    sign_str = "-";
                }
                else
                {
                    if (cal != "")
                    {
                        cal2 = cal;
                        num2 = float.Parse(num) - float.Parse(cal);
                        num = num2.ToString();
                        dat_Text();
                        sign_str = "-";
                    }
                    else if (sign_str == "-" && cal2 != "")
                    {
                        num2 = float.Parse(num) - float.Parse(cal2);
                        num = num2.ToString();
                        dat_Text();
                    }
                    else
                    {
                        sign_str = "-";
                    }
                }
                cal = "";
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Add_method();
        }

        private void Add_method()
        {
            float num2 = 0;
            flag_dat = false;

            if (sign_str == "&")
            {
                if (textBox.Text == num || textBox.Text == (num + "."))
                {
                    sign_str = "+";
                }
                else
                {
                    num = "";
                }
            }
            try
            {
                if (num != "" && cal != "" && sign_str != "+")
                {
                    equals_method();
                    sign_str = "+";
                }
                else if (num == "" && cal != "")
                {
                    num = cal;
                    sign_str = "+";
                }
                else
                {
                    if (cal != "")
                    {
                        cal2 = cal;
                        num2 = float.Parse(num) + float.Parse(cal);
                        num = num2.ToString();
                        dat_Text();
                        sign_str = "+";
                    }
                    else if (sign_str == "+" && cal2 != "")
                    {
                        num2 = float.Parse(num) + float.Parse(cal2);
                        num = num2.ToString();
                        dat_Text();
                    }
                    else
                    {
                        sign_str = "+";
                    }
                }
                cal = "";
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            multiply_method();
        }

        private void multiply_method()
        {
            float num2 = 0;
            flag_dat = false;

            if (sign_str == "&")
            {
                if (textBox.Text == num || textBox.Text == (num + "."))
                {
                    sign_str = "*";
                }
                else
                {
                    num = "";
                }
            }
            try
            {
                if (num != "" && cal != "" && sign_str != "*")
                {
                    equals_method();
                    sign_str = "*";
                }
                else if (num == "")
                {
                    num = cal;
                    sign_str = "*";
                }
                else
                {
                    if (cal != "")
                    {
                        cal2 = cal;
                        num2 = float.Parse(num) * float.Parse(cal);
                        num = num2.ToString();
                        dat_Text();
                        sign_str = "*";
                    }
                    else if (sign_str == "*" && cal2 != "")
                    {
                        num2 = float.Parse(num) * float.Parse(cal2);
                        num = num2.ToString();
                        dat_Text();
                    }
                    else
                    {
                        sign_str = "*";
                    }
                }
                cal = "";
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            Divide_method();
        }

        private void Divide_method()
        {
            float num2 = 0;
            flag_dat = false;

            if (sign_str == "&")
            {
                if (textBox.Text == num || textBox.Text == (num + "."))
                {
                    sign_str = "/";
                }
                else
                {
                    num = "";
                }
            }
            try
            {
                if (num != "" && cal != "" && sign_str != "/")
                {
                    equals_method();
                    sign_str = "/";
                }
                else if (num == "")
                {
                    num = cal;
                    sign_str = "/";
                }
                else
                {
                    if (cal != "")
                    {
                        cal2 = cal;
                        num2 = float.Parse(num) / float.Parse(cal);
                        num = num2.ToString();
                        dat_Text();
                        sign_str = "/";
                    }
                    else if (sign_str == "/" && cal2 != "")
                    {
                        num2 = float.Parse(num) / float.Parse(cal2);
                        num = num2.ToString();
                        dat_Text();
                    }
                    else
                    {
                        sign_str = "/";
                    }
                }
                cal = "";
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_sing_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text[0] == '-')
                {
                    textBox.Text = textBox.Text.Substring(1);
                    num = textBox.Text;
                }
                else
                {
                    textBox.Text = "-" + textBox.Text;
                    num = textBox.Text;
                }
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_darsad_Click(object sender, EventArgs e)
        {
            flag_dat = false;

            try
            {
                if (sign_str == "*" && num != "" && cal != "")
                {
                    if (0 < float.Parse(cal) && float.Parse(cal) < 100)
                    {
                        float darsad = float.Parse(num) * float.Parse(cal);
                        darsad = darsad / 100;
                        num = darsad.ToString();
                        dat_Text();
                    }
                }
                cal = "";
                num = "";
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (cal != "")
            {
                equals_method();
                cal2 = "";
                sign_str = "&";
            }
        }

        private void equals_method()
        {
            flag_dat = false;
            try
            {
                float num2;

                switch (sign_str)
                {
                    case "-":
                        {
                            num2 = float.Parse(num) - float.Parse(cal);
                            num = num2.ToString();
                            dat_Text();
                            break;
                        }
                    case "+":
                        {
                            num2 = float.Parse(num) + float.Parse(cal);
                            num = num2.ToString();
                            dat_Text();
                            break;
                        }
                    case "*":
                        {
                            num2 = float.Parse(num) * float.Parse(cal);
                            num = num2.ToString();
                            dat_Text();
                            break;
                        }
                    case "/":
                        {
                            num2 = float.Parse(num) / float.Parse(cal);
                            num = num2.ToString();
                            dat_Text();
                            break;
                        }
                }
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal2 = "";
                num = "";
            }
            cal = "";

        }

        private void dat_Text()
        {
            try
            {
                bool flag = true;
                for (int i = 1; i < num.Length; i++)
                {
                    if (num[i] == '.' || num[i] == 'E')
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    textBox.Text = num + ".";
                }
                else
                {
                    textBox.Text = num;
                }
            }
            catch
            {
                textBox.Text = ".«Ì‰ „Õ«”»Â €Ì— ﬁ«»· «‰Ã«„ «” ";
                cal = "";
                cal2 = "";
                num = "";
            }
        }

        #endregion

        #region Set Fore Color Button

        Color colorButNum = Color.Blue;

        /// <summary>
        /// Gets or Set ForeColor Buttons(0, 00, 000, 1, 2, 3, 4, 5, 6, 7, 8, 9, ., [+/-], BackSpase)
        /// </summary>
        public Color NumberButtonColor
        {
            get
            {
                return colorButNum;
            }
            set
            {
                colorButNum = value;
                button_0.ForeColor = colorButNum;
                button_00.ForeColor = colorButNum;
                button_000.ForeColor = colorButNum;
                button_1.ForeColor = colorButNum;
                button_2.ForeColor = colorButNum;
                button_3.ForeColor = colorButNum;
                button_4.ForeColor = colorButNum;
                button_5.ForeColor = colorButNum;
                button_6.ForeColor = colorButNum;
                button_7.ForeColor = colorButNum;
                button_8.ForeColor = colorButNum;
                button_9.ForeColor = colorButNum;
                Backspace_button.ForeColor = colorButNum;
                button_sing.ForeColor = colorButNum;
                button_darsad.ForeColor = colorButNum;
                button_dat.ForeColor = colorButNum;
            }
        }

        Color colorButSing = Color.Red;

        /// <summary>
        /// Gets or Sets ForeColor Buttons(-, +, *, /, =, C, CE)
        /// </summary>
        public Color SingButtonColor
        {
            get
            {
                return colorButSing;
            }
            set
            {
                colorButSing = value;
                c_button.ForeColor = colorButSing;
                ce_button.ForeColor = colorButSing;
                button_subtract.ForeColor = colorButSing;
                button_add.ForeColor = colorButSing;
                button_multiply.ForeColor = colorButSing;
                button_Divide.ForeColor = colorButSing;
                button_equals.ForeColor = colorButSing;
            }
        }

        #endregion

        #region Set Back Color Button

        Color colorNum;

        /// <summary>
        /// Gets or Sets BackColor Buttons(0, 00, 000, 1, 2, 3, 4, 5, 6, 7, 8, 9, ., [+/-], BackSpase)
        /// </summary>
        public Color NumberBackColor
        {
            get
            {
                return colorNum;
            }
            set
            {
                colorNum = value;
                button_0.BackColor = colorNum;
                button_00.BackColor = colorNum;
                button_000.BackColor = colorNum;
                button_1.BackColor = colorNum;
                button_2.BackColor = colorNum;
                button_3.BackColor = colorNum;
                button_4.BackColor = colorNum;
                button_5.BackColor = colorNum;
                button_6.BackColor = colorNum;
                button_7.BackColor = colorNum;
                button_8.BackColor = colorNum;
                button_9.BackColor = colorNum;
                Backspace_button.BackColor = colorNum;
                button_sing.BackColor = colorNum;
                button_darsad.BackColor = colorNum;
                button_dat.BackColor = colorNum;
            }
        }

        Color colorSing;

        /// <summary>
        /// Gets or Sets BackColor Buttons(-, +, * , /, =, C, CE)
        /// </summary>
        public Color SingBackColor
        {
            get
            {
                return colorSing;
            }
            set
            {
                colorSing = value;
                c_button.BackColor = colorSing;
                ce_button.BackColor = colorSing;
                button_subtract.BackColor = colorSing;
                button_add.BackColor = colorSing;
                button_multiply.BackColor = colorSing;
                button_Divide.BackColor = colorSing;
                button_equals.BackColor = colorSing;
            }
        }

        #endregion

        #region Set FlatStyle Button

        FlatStyle ButFlat = FlatStyle.Standard;

        /// <summary>
        /// Gets or Sets FlatStyle Buttons(0, 00, 000, 1, 2, 3, 4, 5, 6, 7, 8, 9, ., [+/-], BackSpase, -, +, *, /, =, C, CE)
        /// </summary>
        public FlatStyle ButFlatStyle
        {
            get
            {
                return ButFlat;
            }
            set
            {
                ButFlat = value;
                button_0.FlatStyle = ButFlat;
                button_00.FlatStyle = ButFlat;
                button_000.FlatStyle = ButFlat;
                button_1.FlatStyle = ButFlat;
                button_2.FlatStyle = ButFlat;
                button_3.FlatStyle = ButFlat;
                button_4.FlatStyle = ButFlat;
                button_5.FlatStyle = ButFlat;
                button_6.FlatStyle = ButFlat;
                button_7.FlatStyle = ButFlat;
                button_8.FlatStyle = ButFlat;
                button_9.FlatStyle = ButFlat;
                Backspace_button.FlatStyle = ButFlat;
                button_sing.FlatStyle = ButFlat;
                button_darsad.FlatStyle = ButFlat;
                button_dat.FlatStyle = ButFlat;
                c_button.FlatStyle = ButFlat;
                ce_button.FlatStyle = ButFlat;
                button_subtract.FlatStyle = ButFlat;
                button_add.FlatStyle = ButFlat;
                button_multiply.FlatStyle = ButFlat;
                button_Divide.FlatStyle = ButFlat;
                button_equals.FlatStyle = ButFlat;
            }
        }

        #endregion

        #region Set Color TextBox

        Color TextColor = Color.Black;

        /// <summary>
        /// Get or Set ForeColor TextBox
        /// </summary>
        public Color colorText
        {
            get
            {
                return TextColor;
            }
            set
            {
                TextColor = value;
                textBox.ForeColor = TextColor;
            }
        }

        Color colorBackText = Color.White;

        /// <summary>
        /// Get or Set BackColor TextBox
        /// </summary>
        public Color BackTextColor
        {
            get
            {
                return colorBackText;
            }
            set
            {
                colorBackText = value;
                textBox.BackColor = colorBackText;
            }
        }

        #endregion

        #region Set FlatStyle TextBox

        BorderStyle BorText = BorderStyle.Fixed3D;

        /// <summary>
        /// Get or Set BorderStyle TextBox
        /// </summary>
        public BorderStyle BorderStyleText
        {
            get
            {
                return BorText;
            }
            set
            {
                BorText = value;
                textBox.BorderStyle = BorText;
            }
        }

        #endregion

        #region Set KeyEventArgs

        /// <summary>
        /// Set KeyEventArgs code for OnKeyDown Method
        /// </summary>
        public KeyEventArgs KeyEvent
        {
            set
            {
                Key = value;
                OnKeyDown(Key);
            }
        }
        #endregion

        #region Gets or Sets Text

        string text;
        /// <summary>
        /// Gets or Sets Text of TextBox User 
        /// </summary>
        public string TextofTextBox
        {
            get
            {
                text = textBox.Text;
                return text;
            }
            set
            {
                text = value;
                textBox.Text = text;
            }
        }

        #endregion

    }
}