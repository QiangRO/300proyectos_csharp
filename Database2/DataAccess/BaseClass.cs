using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class BaseClass
    {
        private SqlConnection _conn = null;
        private SqlCommand _cmd = null;

        public BaseClass()
        {
            _conn = new SqlConnection();
            _conn.ConnectionString = ConnectionString;
            SetCommand();
        }

        private void SetCommand()
        {
            _cmd = new SqlCommand();
            _cmd.Connection = _conn;
        }

        public string ConnectionString
        {
            get
            {
                Properties.Settings settings = new DataAccess.Properties.Settings();
                return settings.DBConnection;
            }
        }

        public SqlCommand Command
        {
            get { return _cmd; }
        }

        public SqlConnection Connection
        {
            get { return _conn; }
        }

       
    }
}
