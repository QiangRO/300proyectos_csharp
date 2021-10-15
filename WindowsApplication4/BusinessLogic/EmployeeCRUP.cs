using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class EmployeeCRUP
    {
        public List<Employee> GetEmployee()
        {
            IDatabase input = new Methods("sp_3");
            SqlDataReader reader =(SqlDataReader) input.ExecuteReader();
            return (List<Employee>)DatabaseToEmployee(reader);
        }

        private object DatabaseToEmployee(SqlDataReader reader)
        {
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee(reader["FirstName"].ToString(), reader["LastName"].ToString());
                employees.Add(employee);
            }

            return employees;
        }
    }
}
