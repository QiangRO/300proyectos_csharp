using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string strfilename;


        public string EditText
        {
            get
            {
                return textbox.Text;
            }
            set
            {
               textbox .Text = value;
            }
        }
        public string StatusText
        {
            get
            {
                return sspstatus.Text;
            }
            set
            {
                sspstatus.Text = value;
            }
        }
        
    
        private void touper_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text.ToUpper();
        }

        private void toolStripobj_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textbox.Text=textbox.Text.ToLower();
        }

        private void backcolor_Click(object sender, EventArgs e)
        {
            Colorgrop.Visible = false;
            if (backcolorgroup.Visible == true)
            {
                backcolorgroup.Visible = false;
            }
            else
            {
                backcolorgroup.Visible = true;
                StatusText = "Back Color Choice?";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Red;
            StatusText = "Back Color:Red";
            backcolorgroup.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.White ;
            StatusText = "Back Color:White";
            backcolorgroup.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Yellow;
            StatusText = "Back Color:Yellow";
            backcolorgroup.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Lime ;
            StatusText = "Back Color:Lime";
            backcolorgroup.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Fuchsia ;
            StatusText = "Back Color:Fuchsia";
            backcolorgroup.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Cyan ;
            StatusText = "Back Color:Cyan";
            backcolorgroup.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Green ;
            StatusText = "Back Color:Green";
            backcolorgroup.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Blue ;
            StatusText = "Back Color:Blue";
            backcolorgroup.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textbox.BackColor = Color.Black ;
            StatusText = "Back Color:Black";
            backcolorgroup.Visible = false;
        }

        private void Colorchange_Click(object sender, EventArgs e)
        {
            backcolorgroup.Visible = false;
            if (Colorgrop.Visible == true)
            {
                Colorgrop.Visible = false;
            }
            else
            {
                Colorgrop.Visible = true;
                StatusText  = "Choice a Color to Font?";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.White;
            StatusText = "Font Color:White";
            Colorgrop.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Yellow ;
            StatusText = "Font Color:Yellow";
            Colorgrop.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textbox.ForeColor = Color.Lime  ;
            StatusText = "Font Color:Lime";
            Colorgrop.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Fuchsia ;
            StatusText = "Font Color:Fuchsia";
            Colorgrop.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Red;
            StatusText = "Font Color:Red";
            Colorgrop.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Cyan;
            StatusText = "Font Color:Cyan";
            Colorgrop.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Green ;
            StatusText = "Font Color:Green";
            Colorgrop.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Blue ;
            StatusText = "Font Color:Blue";
            Colorgrop.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = Color.Black ;
            StatusText = "Font Color:Black";
            Colorgrop.Visible = false;
        }

      
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt) |*.txt|" + "All Files (*.*) |*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Open File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfilename = openFileDialog1.FileName;
                textbox.Text = System.IO.File.ReadAllText(strfilename);
                StatusText = "Open file";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile();
        }
        private void savefile()
        {
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.FileName = strfilename;
            saveFileDialog1.Filter = "Text File (*.txt) |*.txt|" + " All File (*.*) |*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strfilename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(strfilename,textbox.Text );
            }
        }

        private void textbox_MouseClick(object sender, MouseEventArgs e)
        {
            StatusText = "Ready";
            Colorgrop.Visible = false;
            backcolorgroup.Visible = false;
        }

        private void font_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fontDialog1.ShowDialog();
            fd.Font = fontDialog1.Font;
            textbox.Font= fd.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            colorDialog1.ShowDialog();
            cd.Color = colorDialog1.Color;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bcd = new ColorDialog();
            colorDialog1.ShowDialog();
            bcd.Color = colorDialog1.Color;
            textbox.BackColor= bcd.Color;
        }

        private void bold_Click(object sender, EventArgs e)
        {
            

        }

        private void italic_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult  messbox=MessageBox.Show("Save And New?","New",
                MessageBoxButtons.YesNoCancel);
            if (messbox ==DialogResult.Yes)
            {
                savefile();
                textbox.Clear();
                StatusText = "Save And New File";
            }
            else if (messbox == DialogResult.No)
            {
                textbox.Clear();
                StatusText = "New File";
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult messbox = MessageBox.Show("Save And Exit?", "Exit",
                MessageBoxButtons.YesNoCancel);
            if (messbox == DialogResult.Yes)
            {
                savefile();
                this.Close();
            }
            else if (messbox == DialogResult.No)
            {
                this.Close();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.TextAlign = HorizontalAlignment.Left;
            StatusText = "Write to Left";
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.TextAlign = HorizontalAlignment.Center;
            StatusText = "Write to Center";
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.TextAlign = HorizontalAlignment.Right;
            StatusText = "Write to Right";
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripobj.Visible == false)
            {
                toolStripobj.Visible = true;
                toolBarToolStripMenuItem.Checked = true;
                StatusText = "ToolBar Is Show";
            }
            else
            {
                toolStripobj.Visible = false;
                toolBarToolStripMenuItem.Checked = false;
                StatusText = "ToolBar Is Hide";
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ttt_Click(object sender, EventArgs e)
        {

        }


        
    }
}