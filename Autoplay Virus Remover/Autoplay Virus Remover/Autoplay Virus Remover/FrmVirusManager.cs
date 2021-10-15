using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Autoplay_Virus_Remover
{
    public partial class FrmVirusManager : Form
    {
        FileStream input = null;
        FileStream output = null;
        BinaryReader binaryinput;
        BinaryWriter binaryoutput;
        string patch = "VirusDefinition.mmm";
        public FrmVirusManager()
        {
            InitializeComponent();
            if (File.Exists(patch) == false)
            {
                #region Entering_Default_Viruses
                try
                {
                    output = new FileStream(patch, FileMode.Create, FileAccess.Write);
                    binaryoutput = new BinaryWriter(output);
                    binaryoutput.Seek(0, 0);
                    binaryoutput.Write("autoplay.exe");
                    binaryoutput.Write("autoplay.exe-open");
                    binaryoutput.Write("autoplay.exe -open");
                    binaryoutput.Write("autoplay.exe - open");
                    binaryoutput.Write("fool.exe");
                    binaryoutput.Write("fooool.exe");
                    binaryoutput.Write("new folder.exe");
                    binaryoutput.Write("New Folder.exe");
                    binaryoutput.Write("kazme__gheyz.exe");
                    binaryoutput.Write("xfoolavp.com");
                    binaryoutput.Write("spoolsv.exe");
                    binaryoutput.Write("Turn Off.exe");
                    binaryoutput.Write("gntext.dll");
                    binaryoutput.Write("jwgkvsq.vmx");
                    binaryoutput.Write("ise323.exe");
                    binaryoutput.Write("eimvmg.cmd");
                    binaryoutput.Write("Recycled.exe");
                    binaryoutput.Write("hunmep.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot Create Virus Databse File. Error Message:\n" + ex.Message, "Virus Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (output != null) output.Close();
                }
                #endregion
            }

        }

        private void FrmVirusManager_Load(object sender, EventArgs e)
        {
            input = new FileStream(patch, FileMode.Open, FileAccess.Read);
            binaryinput = new BinaryReader(input);
            input.Seek(0, 0);
            int i = 0;
            while (true)
            {
                try
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    dataGridView1.Rows[i].Cells[1].Value = binaryinput.ReadString();
                    i++;
                }
                catch (EndOfStreamException) { break; } 
            }
            if (input != null) input.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Cells[0].Value =int.Parse( dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0].Value.ToString()) + 1;
            }
            catch { }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                output = new FileStream(patch, FileMode.Create, FileAccess.Write);
                binaryoutput = new BinaryWriter(output);
                binaryoutput.Seek(0, 0);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = true;
                    if (dataGridView1.Rows[i].Cells["Virus"].Value == null) continue;
                    if ( dataGridView1.Rows[i].Cells["Virus"].Value.ToString().Trim().Length == 0)
                    {
                        MessageBox.Show("This Row Includes null Value And Cannot Be Saved");
                        continue;
                    }
                    binaryoutput.Write(dataGridView1.Rows[i].Cells["virus"].Value.ToString());
                }
                
                MessageBox.Show("Virus Databse Updated.", "virus Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virus Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (output != null) output.Close();
            }
        }
       
    }
}
