using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewFilterColumn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool focus = true;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (focus == true)
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    if (e.KeyChar == 8)
                    {}
                    else
                        e.Handled = true;
                }

            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Clipboard.Clear();
            if (dataGridView1.Columns[1].Index == e.ColumnIndex)
                focus = true;
            else
                focus = false;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1[1, dataGridView1.CurrentRow.Index].Value = "0";
        }

        

      

        

    }
    
}
