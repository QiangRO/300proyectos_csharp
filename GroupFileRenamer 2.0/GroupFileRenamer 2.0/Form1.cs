using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GroupFileRenamer_2._
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog source_FolderBrowsing=new FolderBrowserDialog()   ;
        private FolderBrowserDialog target_FolderBrowsing = new FolderBrowserDialog();
        private FileInfo file_info;
        int first_selected_extiontion = 0;
        int NumOfSelectedFiles = 0;
        int code_time_started=-1 ;
        string Report_path;
/******************************************************************************/
        public Form1()
        {
            InitializeComponent();
        }
/******************************************************************************/
        private void btnSource_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = source_FolderBrowsing.ShowDialog();
            if (myResult == DialogResult.Cancel)
            {
                return;
            }

            txtSource.Text = source_FolderBrowsing.SelectedPath;
            lstbFiles.SelectionMode = SelectionMode.MultiExtended;

            fill_listbox_and_combobox();
        }
/******************************************************************************/
        private void fill_listbox_and_combobox()
        {
            pgbAllFilesInSource.Visible = true;
            pgbAllFilesInSource.Minimum = 0;
            pgbAllFilesInSource.Maximum = Directory.GetFiles(txtSource.Text).Length;
            pgbAllFilesInSource.Value = 0;

            lstbFiles.Items.Clear();
            cmbExtentions.Items.Clear();
            cmbExtentions.Items.Add("[All]");
            cmbExtentions.Items.Add("[None]");

            foreach (string myFileName in Directory.GetFiles(txtSource.Text))
            {
                pgbAllFilesInSource.Value++ ;
                
                file_info = new FileInfo(myFileName);
                lstbFiles.Items.Add(file_info.Name);
                bool found_extention = false;

                foreach (string file_extention in cmbExtentions.Items)
                {
                    if (file_info.Extension == file_extention.ToLower())
                    {
                        found_extention = true;
                        break;
                    }
                }
                if (found_extention == false) cmbExtentions.Items.Add(file_info.Extension.ToLower());
            }
            pgbAllFilesInSource.Visible = false;
            cmbExtentions.ResetText();
        }
/******************************************************************************/
        private void cmbExtentions_SelectedValueChanged(object sender, EventArgs e)
        {
            pgbAllFilesInSource.Visible = true;
            pgbAllFilesInSource.Minimum = 0;
            pgbAllFilesInSource.Maximum = Directory.GetFiles(txtSource.Text).Length;
            pgbAllFilesInSource.Value = 0;

            first_selected_extiontion = 0;
            if (cmbExtentions.SelectedItem.ToString() == "[All]")
            {
                for (int myIndex = 0; myIndex < lstbFiles.Items.Count; myIndex++)
                {
                    lstbFiles.SetSelected(myIndex, true);
                    pgbAllFilesInSource.Value++;
                }
            }
            else 
            {
                lstbFiles.ClearSelected();
            }
            pgbAllFilesInSource.Value = 0;
            if (cmbExtentions.SelectedItem.ToString() != "[None]")
            {
                for (int myIndex = 0; myIndex < lstbFiles.Items.Count; myIndex++)
                {
                    if (((string)lstbFiles.Items[myIndex]).Substring(((string)lstbFiles.Items[myIndex]).LastIndexOf('.')).ToLower() == cmbExtentions.SelectedItem.ToString().ToLower())
                    {
                        lstbFiles.SetSelected(myIndex, true);
                        pgbAllFilesInSource.Value++;
                    }
                }
            }
            pgbAllFilesInSource.Visible = false;
        }
/******************************************************************************/
        private void lstbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            first_selected_extiontion++;
            if (first_selected_extiontion > 1) cmbExtentions.ResetText();

            NumOfSelectedFiles = lstbFiles.SelectedItems.Count;
            lblNumOfSelectedFiles.Text = NumOfSelectedFiles.ToString() + "  Selected files";
        }
/******************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            lblAbout.Text = "";
            lblNumOfSelectedFiles.Text = "0  Selected files";
            pgbAllFilesInSource.Visible = false;
            pgbSelectedFilesInSource.Visible = false;
        }
/******************************************************************************/
        private void btnInvert_Click(object sender, EventArgs e)
        {
            for (int myIndex = 0; myIndex < lstbFiles.Items.Count; myIndex++)
            {
                if (lstbFiles.GetSelected(myIndex) == true)
                {
                    lstbFiles.SetSelected(myIndex, false);
                }
                else lstbFiles.SetSelected(myIndex, true);
            }
            cmbExtentions.ResetText();
        }
/******************************************************************************/
        private void btnTarget_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = target_FolderBrowsing.ShowDialog();
            if (myResult == DialogResult.Cancel) return;

            txtTarget.Text = target_FolderBrowsing.SelectedPath;
        }
/******************************************************************************/
        private void btnStart_Click(object sender, EventArgs e)
        {
            StreamWriter sw ;
            if (txtSource.Text == "" || txtTarget.Text == "")
            {
                MessageBox.Show("Please select source and target pathes .", "GFR 2.0", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return;
            }
            if (chbSameAsSource.Checked == false && chbNormal.Checked == false &&
                chbHidden.Checked == false && chbReadOnly.Checked == false)
            {
                MessageBox.Show("Please select one of attributes .", "GFR 2.0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (lstbFiles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No item selected.\nPlease select one or more files from listbox.", "GFR 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pgbSelectedFilesInSource.Visible = true;
                pgbSelectedFilesInSource.Minimum = 0;
                pgbSelectedFilesInSource.Maximum = NumOfSelectedFiles;
                pgbSelectedFilesInSource.Value = 0;

                pgbAllFilesInSource.Visible = true;
                pgbAllFilesInSource.Minimum = 0;
                pgbAllFilesInSource.Maximum = lstbFiles.Items.Count;
                pgbAllFilesInSource.Value = 0;

                string new_extention, new_filename, old_extention, old_filename;
                string source_path, target_path, source_fullname, target_fullname;
                int file_number;
                source_path = txtSource.Text;
                target_path = txtTarget.Text;
                DateTime moment=DateTime.Now;
                string Report_time =moment.Year+"-"+moment.Month +"-"+moment.Day 
                                    +"  T  " + moment.Hour +"-"+moment.Minute +"-"+ moment.Second ;
                Report_path = target_path + "\\Report_(" + Report_time + ").txt";
                sw = new StreamWriter(Report_path);
                sw.WriteLine("Report of Group File Renamer 2.0");
                for (int i = 1; i < 100; i++)
                {
                    sw.Write("*");
                }
                sw.WriteLine("");

                string CaseOfCopy = "Copy";
                for (int myIndex = 0; myIndex < lstbFiles.Items.Count; myIndex++)
                {
                    pgbAllFilesInSource.Value ++ ;
                    if (lstbFiles.GetSelected(myIndex) == true)
                    {
                        old_filename = ((string)lstbFiles.Items[myIndex]).Substring(0, ((string)lstbFiles.Items[myIndex]).LastIndexOf('.'));
                        old_extention = ((string)lstbFiles.Items[myIndex]).Substring(((string)lstbFiles.Items[myIndex]).LastIndexOf('.') + 1);

                        new_filename = old_filename;
                        new_extention = old_extention;

                        if (txtNewExtention.Text != "") new_extention = txtNewExtention.Text.Substring(txtNewExtention.Text.LastIndexOf('.') + 1);
                        if (txtNewFileName.Text != "") new_filename = txtNewFileName.Text;

                        source_fullname = source_path + "\\" + (string)lstbFiles.Items[myIndex];
                        target_fullname = target_path + "\\" + new_filename + "." + new_extention;


                        //////////////
                        string namesake_folder;
                        int folder_number;

                        if (chbMakeNamesakeFolder.Checked == true)
                        {
                            try
                            {
                                namesake_folder = target_path + "\\" + new_filename;
                                folder_number = 0;
                                while (Directory.Exists(namesake_folder) == true)
                                {
                                    folder_number++;
                                    namesake_folder = target_path + "\\" + new_filename + "(" + folder_number + ")";
                                }
                                Directory.CreateDirectory(namesake_folder);
                                target_fullname = namesake_folder + "\\" + new_filename + "." + new_extention;
                            }
                            catch (Exception e1)
                            {
                                Console.WriteLine("The process failed: {0}", e1.ToString());
                            }
                            finally { }
                        }
                        //////////////

                        file_number = 0;
                        while (File.Exists(target_fullname) == true)
                        {
                            file_number++;
                            target_fullname = target_path + "\\" + new_filename + "(" + file_number + ")" + "." + new_extention;
                        }

                        if (rdbCopy.Checked == true)
                        {
                            File.Copy(source_fullname, target_fullname);
                        }
                        else
                        {
                            File.Move(source_fullname, target_fullname);
                            CaseOfCopy = "Move";
                        }
                        
                        if (chbNormal.Checked == true)
                        {
                            File.SetAttributes(target_fullname, FileAttributes.Normal );
                        }
                        if (chbHidden.Checked == true && chbReadOnly.Checked==true )
                        {
                            File.SetAttributes(target_fullname, FileAttributes.Hidden | FileAttributes.ReadOnly);
                        }
                        if (chbHidden.Checked == true && chbReadOnly.Checked == false )
                        {
                            File.SetAttributes(target_fullname, FileAttributes.Hidden );
                        }
                        if (chbHidden.Checked == false  && chbReadOnly.Checked == true)
                        {
                            File.SetAttributes(target_fullname, FileAttributes.ReadOnly);
                        }
                        sw.WriteLine(source_fullname+"          =====>       "+target_fullname );

                        pgbSelectedFilesInSource.Value++ ;
                    }
                }
                sw.Close();
                pgbSelectedFilesInSource.Visible = false;
                fill_listbox_and_combobox();

                MessageBox.Show(CaseOfCopy +" of "+ NumOfSelectedFiles +
                    " file(s) succeed.\n\nFor more information,please read Report file in this path :\n\n"
                    +Report_path , "GFR 2.0") ;
                NumOfSelectedFiles = 0;
                lblNumOfSelectedFiles.Text = NumOfSelectedFiles.ToString() + "  Selected files";
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return;
            }
            finally
            {

            }
        }
/******************************************************************************/
        private void btnGoToSourceFolder_Click(object sender, EventArgs e)
        {
            if (txtSource.Text == "") return;
            try
            {
                Process.Start(txtSource.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
/******************************************************************************/
        private void btnGoToTargetFolder_Click(object sender, EventArgs e)
        {
            if (txtTarget.Text == "") return;
            try
            {
                Process.Start(txtTarget.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
/******************************************************************************/
        private void chbSameAsSource_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSameAsSource.Checked == true)
            {
                chbNormal.Enabled = false;
                chbHidden.Enabled = false;
                chbReadOnly.Enabled = false;
            }
            else
            {
                chbNormal.Enabled = true ;
                chbHidden.Enabled = true ;
                chbReadOnly.Enabled = true ;

            }
        }
/******************************************************************************/
        private void chbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNormal.Checked == true)
            {
                chbSameAsSource.Enabled = false;
                chbHidden.Enabled = false;
                chbReadOnly.Enabled = false;
            }
            else
            {
                chbSameAsSource.Enabled = true;
                chbHidden.Enabled = true;
                chbReadOnly.Enabled = true;

            }
        }
/******************************************************************************/
        private void chbHidden_CheckedChanged(object sender, EventArgs e)
        {
            chbHidden_and_ReadOnly_Change_Check();
        }
/******************************************************************************/
        private void chbReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            chbHidden_and_ReadOnly_Change_Check();
        }
 /******************************************************************************/
        private void chbHidden_and_ReadOnly_Change_Check()
        {
            if (chbReadOnly.Checked == true || chbHidden.Checked == true)
            {
                chbSameAsSource.Enabled = false;
                chbNormal.Enabled = false;
            }
            else
            {
                chbSameAsSource.Enabled = true;
                chbNormal.Enabled = true;
            }
        }
/******************************************************************************/
        private void btnAbout_Click(object sender, EventArgs e)
        {
            code_time_started *= -1;
            if (code_time_started > 0)
            {
                timer1.Interval = 20;
                lblAbout.Left = 20;
                timer1.Start();
                lblAbout.Text = "Group File Renamer 2.0 , by Sharifsoft , 2007/06/18 , SharifLotfi@yahoo.com";

            }
            else
            {
                timer1.Stop();
                lblAbout.Text = "";
            }
        }
/******************************************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblAbout.Right  == 0) lblAbout.Left = panel1.Width ;
            lblAbout.Left--;
        }
/******************************************************************************/
        private void btnOpenReportFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (Report_path == null)
                {
                    MessageBox.Show("No Report file in access.", "GFR 2.0");
                    return;
                }
                Process.Start("notepad.exe", Report_path);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
/******************************************************************************/
    }
}