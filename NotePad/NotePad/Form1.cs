using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            editor.Text = "";
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "باز کردن فایل";
            openFileDialog.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    editor.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            catch (Exception ex)
            {
                // Show the exception to the user.
                MessageBox.Show("خطا در بازگشایی یا خواندن فایل" + Environment.NewLine + "نام فایل یا سطح دسترسی به فایل را بررسی کنید." + Environment.NewLine + Environment.NewLine + "Exception: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Language Changer
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.Name == "fa-IR")
                {
                    InputLanguage.CurrentInputLanguage = lang;
                }

            } 
           #endregion

        }

        private void ToolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            editor.Cut();
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                editor.SaveFile(saveFileDialog.FileName.ToString(),RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                // Show the error to the user.
                MessageBox.Show("خطا در ذخیره فایل" + Environment.NewLine + "نام فایل یا سطح دسترسی به فایل را بررسی کنید." + Environment.NewLine + Environment.NewLine + "Exception: " + ex.Message);
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            editor.Copy();
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            editor.Paste();
        }

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog myFontDialog = new FontDialog();
            myFontDialog.ShowDialog();
            System.Drawing.Font myFont = new Font(myFontDialog.Font.Name, myFontDialog.Font.Size, myFontDialog.Font.Style);
            editor.SelectionFont  = myFont;
        }

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog myColorDialog = new ColorDialog();
            myColorDialog.ShowDialog();
            editor.ForeColor = myColorDialog.Color;

        }

        private void ToolStripMenuItemBColor_Click(object sender, EventArgs e)
        {
            ColorDialog myColorDialog = new ColorDialog();
            myColorDialog.ShowDialog();
            editor.BackColor = myColorDialog.Color;
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               محمد علی خسرونژاد" + Environment.NewLine + "نمونه برنامه جهت سایت برنامه نویس" + Environment.NewLine + Environment.NewLine, "درباره ما", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void ToolStripMenuItemR_Click(object sender, EventArgs e)
        {
            editor.RightToLeft = RightToLeft.Yes;

        }

        private void ToolStripMenuItemL_Click(object sender, EventArgs e)
        {
            editor.RightToLeft = RightToLeft.No;
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}