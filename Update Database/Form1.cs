using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        //You should declare object variables as a class field.
        private DataTable dataTable1 = new DataTable();
        private OleDbConnection oleDbConnection1 = new OleDbConnection();
        private OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();

        public Form1()
        {
            InitializeComponent();

            this.oleDbConnection1.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = |DataDirectory|\\log.mdb; Persist Security Info = True";
            this.oleDbDataAdapter1.SelectCommand = new OleDbCommand("SELECT ID, Field1, Field2 FROM Table1", this.oleDbConnection1);
            this.oleDbDataAdapter1.Fill(this.dataTable1);
            this.dataGridView1.DataSource = dataTable1;

            //Initialize UPDATE Command.
            this.oleDbDataAdapter1.UpdateCommand = new OleDbCommand("UPDATE Table1 SET Field1 = @field1, Field2 = @field2 WHERE ID = @id", this.oleDbConnection1);
            this.oleDbDataAdapter1.UpdateCommand.Parameters.AddWithValue("@field1", typeof(string)).SourceColumn = "Field1";
            this.oleDbDataAdapter1.UpdateCommand.Parameters.AddWithValue("@field2", typeof(string)).SourceColumn = "Field2";
            this.oleDbDataAdapter1.UpdateCommand.Parameters.AddWithValue("@id", typeof(int)).SourceColumn = "ID";

            //Initialize INSERT Command.
            this.oleDbDataAdapter1.InsertCommand = new OleDbCommand("INSERT INTO Table1 (Field1, Field2) VALUES (@field1, @field2)", this.oleDbConnection1);
            this.oleDbDataAdapter1.InsertCommand.Parameters.AddWithValue("@field1", typeof(string)).SourceColumn = "Field1";
            this.oleDbDataAdapter1.InsertCommand.Parameters.AddWithValue("@field2", typeof(string)).SourceColumn = "Field2";

            //Initialize DELETE Command.
            this.oleDbDataAdapter1.DeleteCommand = new OleDbCommand("DELETE FROM Table1 WHERE ID = @id", this.oleDbConnection1);
            this.oleDbDataAdapter1.DeleteCommand.Parameters.AddWithValue("@id", typeof(int)).SourceColumn = "ID";

            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Field1"].HeaderText = "اسم";
            this.dataGridView1.Columns["Field2"].HeaderText = "فامیلی";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //اگر متد زیر را صدا بزنید، تمام تغییرات در بانک اطلاعاتی ذخیره میگردد
            this.oleDbDataAdapter1.Update(dataTable1);
        }
    }
}