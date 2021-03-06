using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AddToDic
{
    public partial class AddOneByOne : Form
    {
        DialogResult result;
        string str;
        StreamWriter stream = new StreamWriter("Memory.txt", true);

        public AddOneByOne()
        {
            InitializeComponent();
            oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            oleDbConnection1.Open();

            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Dic.English,Dic.Farsi FROM Dic WHERE Dic.English = '" +
                richTextBox2.Text + "'";
            oleDbDataAdapter1.Fill(dataSet1, "Dic");

            if (result == DialogResult.Yes)
            {
                oleDbDataAdapter1.InsertCommand.CommandText = "UPDATE Dic SET English = '" +
                                richTextBox2.Text + "', Farsi = '" + richTextBox1.Text + "'" +
                                "WHERE Dic.English = '" + str + "'";
                oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                result = DialogResult.None;
                stream.Write(richTextBox2.Text + "\n    -Edited- *");
                MessageBox.Show("! لغت ویرایش شد");
                button1.Text = "وارد کردن لغت (Enter)";
                dataSet1.Reset();
                oleDbConnection1.Close();
                return;
            }

            if (dataSet1.Tables["Dic"].Rows.Count > 0)
            {
                result = MessageBox.Show("این لغت موجود است آیا مایل به نمایش و ویرایش آن هستید؟", "", MessageBoxButtons.YesNo
                    ,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    str = richTextBox2.Text;
                    button1.Text = "ویرایش این لغت (Enter)";
                    richTextBox1.Text = dataSet1.Tables["Dic"].Rows[0][1].ToString();
                    richTextBox2.Text = dataSet1.Tables["Dic"].Rows[0][0].ToString();
                }
            }
            else
            {
                oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO `Dic` (`English`, `Farsi`) " +
                                "VALUES ('" + richTextBox2.Text + "', '" + richTextBox1.Text + "')";
                oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();
                stream.Write(richTextBox2.Text + "\n    -Writed- *");
                MessageBox.Show("! لغت اضافه شد");
            }

            dataSet1.Reset();
            oleDbConnection1.Close();
        }

        private void AddOneByOne_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                this.TopMost = false;
                //this.Location = new Point(this.Location.X, this.Location.Y + this.Height / 9);
                this.Refresh();
                this.Opacity -= 0.10;
                System.Threading.Thread.Sleep(10);
            }
            stream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Clipboard.GetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();

            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Dic.English,Dic.Farsi FROM Dic WHERE Dic.English = '" +
                richTextBox2.Text + "'";
            oleDbDataAdapter1.Fill(dataSet1, "Dic");

            if (dataSet1.Tables["Dic"].Rows.Count > 0)
            {                
                if (MessageBox.Show("لغت یافت شد، آیا مایل به حذف آن هستید؟", "", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    oleDbDataAdapter1.SelectCommand.CommandText = "DELETE FROM Dic WHERE Dic.English = '" +
                        richTextBox2.Text + "'";
                    oleDbDataAdapter1.Fill(dataSet1, "Dic");
                    stream.Write(richTextBox2.Text + "\n    -Deleted- *");
                    MessageBox.Show("! لغت حذف شد");
                }
            }

            else
            {
                MessageBox.Show("! لغت یافت نشد");
            }

            dataSet1.Reset();
            oleDbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();

            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Dic.English,Dic.Farsi FROM Dic WHERE Dic.English = '" +
                richTextBox2.Text + "'";
            oleDbDataAdapter1.Fill(dataSet1, "Dic");


            if (dataSet1.Tables["Dic"].Rows.Count > 0)
            {                
                if (MessageBox.Show("این لغت موجود است آیا مایل به نمایش هستید؟", "", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    richTextBox1.Text = dataSet1.Tables["Dic"].Rows[0][1].ToString();
                    richTextBox2.Text = dataSet1.Tables["Dic"].Rows[0][0].ToString();
                }
            }
            else
            {
                MessageBox.Show("! لغت یافت نشد");
            }

            dataSet1.Reset();
            oleDbConnection1.Close();
        }

        private void ctrl1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(new object(), new EventArgs());
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6_Click(new object(), new EventArgs());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(new object(), new EventArgs());
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(new object(), new EventArgs());
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button5_Click(new object(), new EventArgs());
        }

        private void AddOneByOne_Load(object sender, EventArgs e)
        {
            button8_Click(new object(), new EventArgs());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stream.Close();
            stream = new StreamWriter("Memory.txt", true);
            System.Diagnostics.Process.Start("Memory.txt");
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7_Click(new object(), new EventArgs());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - this.Width - 1,
                System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height - 1);
        }
    }
}