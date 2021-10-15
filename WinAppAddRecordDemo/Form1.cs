using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinAppAddRecordDemo
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable dt;
        BindingManagerBase mBase;

        public Form1()
        {
            InitializeComponent();

            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            da = new SqlDataAdapter("SELECT * FROM Table1", cn);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            mBase = dataGridView1.BindingContext[dt];

            nameTextBox.DataBindings.Add("Text", dt, "Name");
            phoneTextBox.DataBindings.Add("Text", dt, "Phone");

            da.InsertCommand = new SqlCommand("INSERT INTO Table1 VALUES (@name, @phone)", cn);
            da.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 20, "Name");
            da.InsertCommand.Parameters.Add("@phone", SqlDbType.VarChar, 11, "Phone");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //add new empty record.
            dt.Rows.Add(dt.NewRow());

            //set new row as current row.
            mBase.Position = mBase.Count - 1;
            
            //disable 'dataGridView1', so user can not change current row.
            dataGridView1.Enabled = false;

            //enable 'groupBox1', so user can input new record fields.
            groupBox1.Enabled = true;

            //change edit box to 'nameTextBox', so user can add new row quickly.
            nameTextBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string
                name = nameTextBox.Text,
                phone = phoneTextBox.Text;

            if(name != "" && phone != "")
            {
                //get new record fields that was entered by user.
                mBase.EndCurrentEdit();

                //update 'Database1.mdf'
                da.Update(dt);

                groupBox1.Enabled = false;
                dataGridView1.Enabled = true;
            }
            else
            {
                //cancel any thing taht user was entered.
                mBase.CancelCurrentEdit();
                MessageBox.Show("Data is not valid, Try again later.");
                CancelAdding();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelAdding();
        }

        private void CancelAdding()
        {
            //delete new row and rowback to the previous time. it work something like UNDO.
            ((DataRowView)mBase.Current).Row.Delete();

            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
        }
    }
}