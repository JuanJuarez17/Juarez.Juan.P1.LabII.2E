using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE_APP
{
    public class DbQuery : DbConnection
    {
        private static SqlCommand command;
        public DbQuery()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        protected DataTable ExecuteReader(string inputQuery)
        {
            OpenConnection();
            command.CommandText = inputQuery;
            DataTable dataTable = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            CloseConnection();
            return dataTable;
        }
        protected int ExecuteNonQuery(string inputQuery)
        {
            int rtn;
            OpenConnection();
            command.CommandText = inputQuery;
            rtn = command.ExecuteNonQuery();
            CloseConnection();
            return rtn;
        }
        protected object ExecuteScalar(string inputQuery)
        {
            object rtn;
            OpenConnection();
            command.CommandText = inputQuery;
            rtn = command.ExecuteScalar();
            CloseConnection();
            return rtn;
        }
    }
}
