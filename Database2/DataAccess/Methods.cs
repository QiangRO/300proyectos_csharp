using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccess
{
     public class Methods:BaseClass,IDatabase
    {
         public Methods() { }

         public Methods(string SQL)
         {
             this.Command.CommandText = SQL;
             this.Command.CommandType = CommandType.StoredProcedure;
         }

         public object ExecuteReader()
         {
             try
             {
                 this.Connection.Open();
                 return this.Command.ExecuteReader();
             }
             catch (SqlException ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
                 return null;
             }

         }

       
    }
}
