using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DGV_WheelMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            dataGridView1.EndEdit();
            if (e.Delta.Equals(120) && dataGridView1.CurrentRow.Index != 0)
                SendKeys.Send("{Up}");

            else if (!e.Delta.Equals(120) && dataGridView1.CurrentRow.Index != dataGridView1.Rows.Count - 1)

                SendKeys.Send("{Down}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MouseWheel += new MouseEventHandler(dataGridView1_MouseWheel);
            dataGridView1.Rows.Add("1","2","3");
            dataGridView1.Rows.Add("1", "2", "3");
            dataGridView1.Rows.Add("1", "2", "3");

        }
    }
}
