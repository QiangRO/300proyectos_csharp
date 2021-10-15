//Created By HaMeD Rashno
// Mail: CyrusTheGreat206@yahoo.Com
//Mail2: CyrusTheGreat206@GMail.Com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Daneshjoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string d;
        private void Form1_Load(object sender, EventArgs e)
        {
            show();
        }
        private void show()
        {
            string d;
            OleDbConnection con;
           OleDbDataAdapter  adap;
            DataSet ds = new DataSet();
            con = new OleDbConnection ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|daneshjoo.mdb");
            d = "select * from members";
            adap = new OleDbDataAdapter (d, con);
            adap.Fill(ds, "members");
            dataGridView1.DataSource = ds.Tables["members"];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            string cmdstr;
            OleDbCommand  cmdoledb=new OleDbCommand ();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|daneshjoo.mdb";
            con.Open();
            cmdstr = "INSERT into members(nam,lname,reshte,maghta) values('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "')";
            cmdoledb.Connection = con;
            cmdoledb.CommandText = cmdstr;
            cmdoledb.ExecuteNonQuery();
            con.Close();
            show();
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled =true ;
            d = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(d);
            OleDbConnection con = new OleDbConnection();
            string cmdstr;
            OleDbCommand cmdoledb = new OleDbCommand();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|daneshjoo.mdb";
            con.Open();
            cmdstr = "Delete From Members Where id =" + d1 + "";
            cmdoledb.Connection = con;
            cmdoledb.CommandText = cmdstr;
            cmdoledb.ExecuteNonQuery();
            con.Close();
            show(); 
            button2.Enabled = false;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            d = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            g2.Visible = true;
            v1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            v2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            v3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            v4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            g2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(d);
            OleDbConnection con = new OleDbConnection();
            string cmdstr;
            OleDbCommand cmdoledb = new OleDbCommand();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|daneshjoo.mdb";
            con.Open();
            cmdstr = "Update Members Set nam='" + v1.Text + "',lname='" + v2.Text + "',reshte='" + v3.Text + "',maghta='" + v4.Text + "' Where id="+ d1 +"";
            cmdoledb.Connection = con;
            cmdoledb.CommandText = cmdstr;
            cmdoledb.ExecuteNonQuery();
            con.Close();
            show();
            g2.Visible = false;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }
    }
    
}
