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
    public partial class FrmScan : Form
    {                
        object[] row = new object[2];
        public FrmScan(int infected, int deleted)
        {
            InitializeComponent();
            dataGridView1.DataSource = ScanCore.SearchTable;
            lblinfect.Text = infected.ToString();
            lbldelete.Text = deleted.ToString();            
            dataGridView1.Columns[0].Width = 35;
        }

        private void FrmScan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                switch (dataGridView1.Rows[i].Cells[2].Value.ToString()){                    
                    case "Deleted":
                        dataGridView1.Rows[i].Cells[0].Value=imageList1.Images[2];
                        break;
                    case "Not Deleted":
                        dataGridView1.Rows[i].Cells[0].Value=imageList1.Images[3];
                        break;
                    default:
                        dataGridView1.Rows[i].Cells[0].Value=imageList1.Images[0];
                        dataGridView1.Rows[i].Cells[0].Tag = "ok";
                        break;}                
            }
        }

        private void FrmScan_Resize(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Width = dataGridView1.MinimumSize.Width + this.Width - this.MinimumSize.Width;
                dataGridView1.Height = dataGridView1.MinimumSize.Height + this.Height - this.MinimumSize.Height;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 0) return;
                if (dataGridView1.Rows[e.RowIndex].Cells["select"].Tag == "ok")
                {
                    dataGridView1.Rows[e.RowIndex].Cells["select"].Value = imageList1.Images[1];
                    dataGridView1.Rows[e.RowIndex].Cells["select"].Tag = "no";
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells["select"].Tag == "no")
                {
                    dataGridView1.Rows[e.RowIndex].Cells["select"].Value = imageList1.Images[0];
                    dataGridView1.Rows[e.RowIndex].Cells["select"].Tag = "ok";
                }
            }
            catch { }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["select"].Tag != "ok") continue;                
                if (File.Exists(dataGridView1.Rows[i].Cells["Directory"].Value.ToString()))
                {
                    try
                    {
                        File.Delete(dataGridView1.Rows[i].Cells["Directory"].Value.ToString());
                        ScanCore.deleted++;
                        dataGridView1.Rows[i].Cells["Action"].Value= "Deleted";
                        dataGridView1.Rows[i].Cells["select"].Tag = "Deleted";
                        dataGridView1.Rows[i].Cells["select"].Value = imageList1.Images[2];
                    }
                    catch
                    {
                        dataGridView1.Rows[i].Cells["Action"].Value = "Not Deleted";
                        dataGridView1.Rows[i].Cells["select"].Tag = "Not Deleted";
                        dataGridView1.Rows[i].Cells["select"].Value = imageList1.Images[3];
                    }
                }
            }
            lbldelete.Text = ScanCore.deleted.ToString();
        }

    }
}