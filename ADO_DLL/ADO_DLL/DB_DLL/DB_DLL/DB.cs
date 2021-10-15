using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DB_DLL
{
    public class DB
    {
        public DB()
        { 
            //Constructor
        }
        public static bool dbConnected(string ConnectionString)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string insert(string ConnectionString, string InsertCommand)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand insCmd = new SqlCommand(InsertCommand,cn);
                cn.Open();
                insCmd.ExecuteNonQuery();
                cn.Close();
                return "Insert 1 record successful.";
            }
            catch (Exception ex)
            {
                return ex.StackTrace.ToString();
            }
        }

        public string update(string ConnectionString, string UpdateCommand)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand updCmd = new SqlCommand(UpdateCommand, cn);
                cn.Open();
                updCmd.ExecuteNonQuery();
                cn.Close();
                return "Update successful.";
            }
            catch (Exception ex)
            {
                return ex.StackTrace.ToString();
            }
        }
    
        public string delete(string ConnectionString, string DeleteCommand)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConnectionString);
                SqlCommand delCmd = new SqlCommand(DeleteCommand, cn);
                cn.Open();
                delCmd.ExecuteNonQuery();
                cn.Close();
                return "Delete successful.";
            }
            catch (Exception ex)
            {
                return ex.StackTrace.ToString();
            }
        }

        public DataSet select(string ConnectionString, string SelectCommand)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            //SqlCommand insCmd = new SqlCommand(SelectCommand);
            SqlDataAdapter da = new SqlDataAdapter(SelectCommand, cn);
            DataSet ds = new DataSet();
            cn.Open();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}
