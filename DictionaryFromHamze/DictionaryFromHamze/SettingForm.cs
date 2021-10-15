using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryFromHamze
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                radioButton2.Checked = radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                radioButton1.Checked = radioButton3.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                radioButton1.Checked = radioButton2.Checked = false;
        }
        private void LoadSettings()
        {
            switch ((string)Properties.Settings.Default.BackImage)
            {
                case "Green":
                    radioButton3.Checked = true;
                    radioButton1.Checked = radioButton2.Checked = false;
                    break;
                case "Red":
                    radioButton1.Checked = true;
                    radioButton3.Checked = radioButton2.Checked = false;
                    break;
                case "Blue":
                    radioButton2.Checked = true;
                    radioButton1.Checked = radioButton3.Checked = false; 
                    break;
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                Properties.Settings.Default.BackImage = "Red";
            else if (radioButton2.Checked)
                Properties.Settings.Default.BackImage = "Blue";
            else if (radioButton3.Checked)
                Properties.Settings.Default.BackImage = "Green";

            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
