using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigitsGame
{
    public partial class frmMain : Form
    {
        int row = 1;
        string originalNumber = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (originalNumber == null)
            {
                int counter = 0;
                originalNumber = GetRandomNumber();
                foreach (Control ctrl in this.Controls)
                    if (ctrl.GetType() == typeof(System.Windows.Forms.Label) && ctrl.Name.Length == 4)
                    {
                        ctrl.Text = originalNumber[counter].ToString();
                        counter += 1;
                    }
            }

            start.Enabled = false;
            timer.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            enter.Enabled = true;
            pause.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (gameTime.Text == "00:00")
            {
                timer.Enabled = false;
                DialogResult dlg = MessageBox.Show("Game Over!\nDo you want to start another game?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.No)
                    this.Close();
                else
                {
                    gameTime.Text = "02:00";
                    ClearAllLabels();
                    foreach (Control ctrl in this.Controls)
                        if (ctrl.GetType() == typeof(System.Windows.Forms.TextBox))
                            ((TextBox)ctrl).Clear();
                    enter.Enabled = false;
                    pause.Enabled = false;
                    start.Enabled = true;
                    start.Focus();
                }
            }
            else if (gameTime.Text == "05:00")
                gameTime.Text = "04:59";
            else if (gameTime.Text == "04:00")
                gameTime.Text = "03:59";
            else if (gameTime.Text == "03:00")
                gameTime.Text = "02:59";
            else if (gameTime.Text == "02:00")
                gameTime.Text = "01:59";
            else if (gameTime.Text == "01:00")
                gameTime.Text = "00:59";
            else
                if (Convert.ToInt32(gameTime.Text.Substring(3, 2)) <= 10)
                    gameTime.Text = gameTime.Text.Substring(0, 2) + ":0" + Convert.ToString(Convert.ToInt32(gameTime.Text.Substring(3, 2)) - 1);
                else
                    gameTime.Text = gameTime.Text.Substring(0, 2) + ":" + Convert.ToString(Convert.ToInt32(gameTime.Text.Substring(3, 2)) - 1);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            start.Focus();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (pause.Text == "Pause")
            {
                timer.Enabled = false;
                enter.Enabled = false;
                pause.Text = "Resume";
            }
            else
            {
                timer.Enabled = true;
                enter.Enabled = true;
                pause.Text = "Pause";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (gameTime.Text == "02:00")
                this.Close();
            else
            {
                timer.Enabled = false;
                DialogResult dlg = MessageBox.Show("Are you sure you want to exit?", 
                    "Question", MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                    this.Close();
                else if (pause.Text == "Pause")
                    timer.Enabled = true;
            }
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {
            if (number1.Text.Length > 0)
            {
                number2.Focus();
                number2.SelectAll();
            }
        }

        private void number2_TextChanged(object sender, EventArgs e)
        {
            if (number2.Text.Length > 0)
            {
                number3.Focus();
                number3.SelectAll();
            }
        }

        private void number3_TextChanged(object sender, EventArgs e)
        {
            if (number3.Text.Length > 0)
            {
                number4.Focus();
                number4.SelectAll();
            }
        }

        private void number4_TextChanged(object sender, EventArgs e)
        {
            if (number4.Text.Length > 0)
            {
                number5.Focus();
                number5.SelectAll();
            }
        }

        private void number5_TextChanged(object sender, EventArgs e)
        {
            if (number5.Text.Length > 0)
            {
                number6.Focus();
                number6.SelectAll();
            }
        }

        private void number6_TextChanged(object sender, EventArgs e)
        {
            if (number6.Text.Length > 0)
            {
                number7.Focus();
                number7.SelectAll();
            }
        }

        private void number7_TextChanged(object sender, EventArgs e)
        {
            if (number7.Text.Length > 0)
            {
                number8.Focus();
                number8.SelectAll();
            }
        }

        private void number8_TextChanged(object sender, EventArgs e)
        {
            if (number8.Text.Length > 0)
            {
                number1.Focus();
                number1.SelectAll();
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string reversedNumber = ReverseString(originalNumber);
                if (CheckNotEmpty())
                {
                    if (number1.Text == reversedNumber[0].ToString())
                    {
                        if (row == 1)
                        {
                            n11.Text = reversedNumber[0].ToString();
                            n11.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n21.Text = reversedNumber[0].ToString();
                            n21.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n31.Text = reversedNumber[0].ToString();
                            n31.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n41.Text = reversedNumber[0].ToString();
                            n41.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n51.Text = reversedNumber[0].ToString();
                            n51.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n61.Text = reversedNumber[0].ToString();
                            n61.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n11.Text = "X";
                            n11.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n21.Text = "X";
                            n21.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n31.Text = "X";
                            n31.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n41.Text = "X";
                            n41.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n51.Text = "X";
                            n51.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n61.Text = "X";
                            n61.BackColor = Color.Red;
                        }
                    }

                    if (number2.Text == reversedNumber[1].ToString())
                    {
                        if (row == 1)
                        {
                            n12.Text = reversedNumber[1].ToString();
                            n12.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n22.Text = reversedNumber[1].ToString();
                            n22.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n32.Text = reversedNumber[1].ToString();
                            n32.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n42.Text = reversedNumber[1].ToString();
                            n42.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n52.Text = reversedNumber[1].ToString();
                            n52.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n62.Text = reversedNumber[1].ToString();
                            n62.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n12.Text = "X";
                            n12.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n22.Text = "X";
                            n22.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n32.Text = "X";
                            n32.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n42.Text = "X";
                            n42.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n52.Text = "X";
                            n52.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n62.Text = "X";
                            n62.BackColor = Color.Red;
                        }
                    }

                    if (number3.Text == reversedNumber[2].ToString())
                    {
                        if (row == 1)
                        {
                            n13.Text = reversedNumber[2].ToString();
                            n13.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n23.Text = reversedNumber[2].ToString();
                            n23.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n33.Text = reversedNumber[2].ToString();
                            n33.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n43.Text = reversedNumber[2].ToString();
                            n43.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n53.Text = reversedNumber[2].ToString();
                            n53.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n63.Text = reversedNumber[2].ToString();
                            n63.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n13.Text = "X";
                            n13.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n23.Text = "X";
                            n23.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n33.Text = "X";
                            n33.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n43.Text = "X";
                            n43.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n53.Text = "X";
                            n53.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n63.Text = "X";
                            n63.BackColor = Color.Red;
                        }
                    }

                    if (number4.Text == reversedNumber[3].ToString())
                    {
                        if (row == 1)
                        {
                            n14.Text = reversedNumber[3].ToString();
                            n14.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n24.Text = reversedNumber[3].ToString();
                            n24.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n34.Text = reversedNumber[3].ToString();
                            n34.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n44.Text = reversedNumber[3].ToString();
                            n44.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n54.Text = reversedNumber[3].ToString();
                            n54.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n64.Text = reversedNumber[3].ToString();
                            n64.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n14.Text = "X";
                            n14.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n24.Text = "X";
                            n24.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n34.Text = "X";
                            n34.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n44.Text = "X";
                            n44.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n54.Text = "X";
                            n54.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n64.Text = "X";
                            n64.BackColor = Color.Red;
                        }
                    }

                    if (number5.Text == reversedNumber[4].ToString())
                    {
                        if (row == 1)
                        {
                            n15.Text = reversedNumber[4].ToString();
                            n15.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n25.Text = reversedNumber[4].ToString();
                            n25.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n35.Text = reversedNumber[4].ToString();
                            n35.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n45.Text = reversedNumber[4].ToString();
                            n45.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n55.Text = reversedNumber[4].ToString();
                            n55.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n65.Text = reversedNumber[4].ToString();
                            n65.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n15.Text = "X";
                            n15.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n25.Text = "X";
                            n25.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n35.Text = "X";
                            n35.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n45.Text = "X";
                            n45.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n55.Text = "X";
                            n55.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n65.Text = "X";
                            n65.BackColor = Color.Red;
                        }
                    }

                    if (number6.Text == reversedNumber[5].ToString())
                    {
                        if (row == 1)
                        {
                            n16.Text = reversedNumber[5].ToString();
                            n16.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n26.Text = reversedNumber[5].ToString();
                            n26.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n36.Text = reversedNumber[5].ToString();
                            n36.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n46.Text = reversedNumber[5].ToString();
                            n46.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n56.Text = reversedNumber[5].ToString();
                            n56.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n66.Text = reversedNumber[5].ToString();
                            n66.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n16.Text = "X";
                            n16.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n26.Text = "X";
                            n26.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n36.Text = "X";
                            n36.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n46.Text = "X";
                            n46.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n56.Text = "X";
                            n56.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n66.Text = "X";
                            n66.BackColor = Color.Red;
                        }
                    }

                    if (number7.Text == reversedNumber[6].ToString())
                    {
                        if (row == 1)
                        {
                            n17.Text = reversedNumber[6].ToString();
                            n17.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n27.Text = reversedNumber[6].ToString();
                            n27.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n37.Text = reversedNumber[6].ToString();
                            n37.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n47.Text = reversedNumber[6].ToString();
                            n47.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n57.Text = reversedNumber[6].ToString();
                            n57.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n67.Text = reversedNumber[6].ToString();
                            n67.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n17.Text = "X";
                            n17.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n27.Text = "X";
                            n27.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n37.Text = "X";
                            n37.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n47.Text = "X";
                            n47.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n57.Text = "X";
                            n57.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n67.Text = "X";
                            n67.BackColor = Color.Red;
                        }
                    }

                    if (number8.Text == reversedNumber[7].ToString())
                    {
                        if (row == 1)
                        {
                            n18.Text = reversedNumber[7].ToString();
                            n18.BackColor = Color.Green;
                        }
                        else if (row == 2)
                        {
                            n28.Text = reversedNumber[7].ToString();
                            n28.BackColor = Color.Green;
                        }
                        else if (row == 3)
                        {
                            n38.Text = reversedNumber[7].ToString();
                            n38.BackColor = Color.Green;
                        }
                        else if (row == 4)
                        {
                            n48.Text = reversedNumber[7].ToString();
                            n48.BackColor = Color.Green;
                        }
                        else if (row == 5)
                        {
                            n58.Text = reversedNumber[7].ToString();
                            n58.BackColor = Color.Green;
                        }
                        else if (row == 6)
                        {
                            n68.Text = reversedNumber[7].ToString();
                            n68.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        if (row == 1)
                        {
                            n18.Text = "X";
                            n18.BackColor = Color.Red;
                        }
                        else if (row == 2)
                        {
                            n28.Text = "X";
                            n28.BackColor = Color.Red;
                        }
                        else if (row == 3)
                        {
                            n38.Text = "X";
                            n38.BackColor = Color.Red;
                        }
                        else if (row == 4)
                        {
                            n48.Text = "X";
                            n48.BackColor = Color.Red;
                        }
                        else if (row == 5)
                        {
                            n58.Text = "X";
                            n58.BackColor = Color.Red;
                        }
                        else if (row == 6)
                        {
                            n68.Text = "X";
                            n68.BackColor = Color.Red;
                        }
                    }

                    row += 1;
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl.GetType() == typeof(System.Windows.Forms.Label) && ctrl.Name.Length == 4)
                    if (ctrl.Text != "X")
                        ctrl.Text = "X";
            timer2.Enabled = false;
        }
        
        string GetRandomNumber()
        {
            string temp = null;
            Random rnd = new Random();
            for (int counter = 0; counter < 8; counter++)
                temp += rnd.Next(0, 9).ToString();

            return temp;
        }

        string ReverseString(string text)
        {
            if (text != null)
            {
                int counter = text.Length;
                string temp = text, result = null;

                while (counter > 0)
                {
                    result += temp[counter - 1].ToString();
                    counter -= 1;
                }

                return result;
            }
            else
                return null;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (row == 7)
            {
                row = 1;
                int counter = 0;
                timer.Enabled = false;
                timer3.Enabled = false;
                foreach (Control ctrl in this.Controls)
                    if (ctrl.GetType() == typeof(System.Windows.Forms.Label) && ctrl.Name.Length == 4)
                    {
                        ctrl.Text = originalNumber[counter].ToString();
                        counter += 1;
                    }
                DialogResult dlg = MessageBox.Show("Game Over!\nDo you want to start another game?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.No)
                    this.Close();
                else
                {
                    originalNumber = null;
                    gameTime.Text = "02:00";
                    ClearAllLabels();
                    foreach (Control ctrl in this.Controls)
                        if (ctrl.GetType() == typeof(System.Windows.Forms.TextBox))
                            ((TextBox)ctrl).Clear();
                    enter.Enabled = false;
                    pause.Enabled = false;
                    start.Enabled = true;
                    start.Focus();
                }
            }
        }
        
        bool CheckNotEmpty()
        {
            bool succed = false;
            if (number1.Text.Length > 0 && number2.Text.Length > 0 && number3.Text.Length > 0 && number4.Text.Length > 0 && number5.Text.Length > 0 && number6.Text.Length > 0 && number7.Text.Length > 0 && number8.Text.Length > 0)
                succed = true;
            else
                succed = false;
            
            return succed;
        }

        void ClearAllLabels()
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (ctrl.Name.Length == 3)
                    {
                        ctrl.Text = "";
                        ctrl.BackColor = Color.LightGray;
                    }

                    if (ctrl.Name.Length == 4)
                        ctrl.Text = "X";
                }
        }
    }
}