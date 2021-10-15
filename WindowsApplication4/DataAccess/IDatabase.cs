using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public interface IDatabase
    {
        object ExecuteReader();
    }
}
