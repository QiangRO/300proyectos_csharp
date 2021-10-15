using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DraggableForm
{
    class MainClass
    {
        #region Public Variable Declare
        protected OleDbCommand cmd;
        //public OleDbConnection con = new OleDbConnection();
        //public string source = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\HMS\HMS\bin\HMS.mdb";
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\DB\\Membership.mdb"); 
        protected OleDbDataReader rdr;
        protected OleDbDataAdapter DataAdapt;
        protected DataSet ds;
        protected DataTable dt;
        protected bool Rtnvalue;
        protected string StrValue;
        protected string Errorstr;
        public long headId;
        protected string connectionstring;
        protected string message;
        protected string line;
        public string ErrorMessage = "Error";
        public string SuccessMessage = "Successfully saved";
        public string UpdateMessage = "Successfully Updated";
        public string DeleteMessage = "Successfully Deleted";
        #endregion
        public DataSet BindDataset(String query, OleDbConnection connection)
        {
            try
            {
                connection.Open();
                DataSet Ds=new DataSet();
                OleDbCommand cmd = new OleDbCommand(query, connection);
                OleDbDataAdapter Ad = new OleDbDataAdapter(cmd);
                Ad.Fill(Ds);
                return Ds;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public OleDbDataReader QueryExecuteDataReader(string str)
        {
            if (str != "")
            {
                try
                {
                    cmd = new OleDbCommand(str, con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return rdr;
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return rdr;
        }
        public bool QueryExecuted(string str)
        {
            if (str != "")
            {
                try
                {
                    cmd = new OleDbCommand(str, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Rtnvalue = true;
                }
                catch (Exception e)
                {
                    Rtnvalue = false;
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            return Rtnvalue;
        }
        public string QueryExecuteReturnSingleString(string str)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand(str, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rdr.Read())
                {
                    StrValue = rdr[0].ToString();
                }
                else
                {
                    StrValue = "";
                }
            }
            catch (Exception)
            {
                StrValue = "";
                throw;
            }
            finally
            {
                con.Close();
            }
            return StrValue;
        }
        public void geterror(Exception e, long userid)
        {
           
            try
            {
                message = e.Message.ToString();

                if (message.IndexOf("Thread was being aborted.") >= 0)
                {
                    return;
                }
                line = e.StackTrace.ToString();
                con.Open(); 
                OleDbCommand com = new OleDbCommand("hospital_sp_Error", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new OleDbParameter("@message", OleDbType.VarChar, 1000)).Value = message;
                com.Parameters.Add(new OleDbParameter("@Formname", OleDbType.VarChar, 100)).Value = e.StackTrace.ToString();
                com.Parameters.Add(new OleDbParameter("@line", OleDbType.VarChar, 5000)).Value = line;
                com.Parameters.Add(new OleDbParameter("@userid", OleDbType.Integer, 25)).Value = userid;
                com.Parameters.Add(new OleDbParameter("@return", OleDbType.Integer)).Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();
                int ret = Convert.ToInt32(com.Parameters["@return"].Value.ToString());
                if (ret == 1)
                {
                    string mm = "true";

                }

            }
            catch (Exception Ex)
            {
                
            }
            finally
            {
                con.Close();
            }

        }
    }
}
