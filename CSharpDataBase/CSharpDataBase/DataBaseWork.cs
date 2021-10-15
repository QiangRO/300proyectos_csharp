using System;
using System.Data;
using System.Data.OleDb;

namespace CSharpDataBase
{
	public class DataBase
	{
		private OleDbCommand cmd;
		private OleDbConnection con;
		private OleDbDataAdapter da;
		private DataTable dt;

		//for sql
		/*
		private SqlCommand cmd;
		private SqlConnection con;
		private SqlDataAdapter da;
		private DataTable dt;
		*/

		public DataBase()
		{
		}

		public void DoCommand(string ole)
		{	
			con=new OleDbConnection();
			//for sql
			//con=new SqlConnection();

			con.ConnectionString="provider=microsoft.jet.oledb.4.0;data source=database.mdb;";
			//for sql
			//con.ConnectionString="server=(local);trusted_connection=yes;database=telephon;";

			cmd=new OleDbCommand();
			//for sql
			//cmd=new SqlCommand();
			cmd.Connection=con;
			con.Open();
			cmd.CommandText=ole;
			cmd.ExecuteNonQuery();
			con.Close();
		}
	
		public DataTable MySelect(string sql)
		{
			con=new OleDbConnection();
			con.ConnectionString="provider=microsoft.jet.oledb.4.0;data source=database.mdb;";
			cmd=new OleDbCommand();
			cmd.Connection=con;
			da=new OleDbDataAdapter(cmd);
			dt=new DataTable();

			con.Open();
			cmd.CommandText=sql;
			da.Fill(dt);
			con.Close();
			return dt;			
		}
	}
}
