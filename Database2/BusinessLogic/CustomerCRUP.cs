using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class CustomerCRUP
    {

        public List<Customer> GetCustomer()
        {
            IDatabase x = new Methods("sp_1");

            SqlDataReader reader = (SqlDataReader)x.ExecuteReader();
            return (List<Customer>) DatabaseToCustomer(reader);
            
        }

        private object DatabaseToCustomer(SqlDataReader reader)
        {
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer(reader["CompanyName"].ToString(), reader["Country"].ToString(), reader["City"].ToString());
                customers.Add(customer);
            }
            
            return customers;
        }

       
        
    }
}
