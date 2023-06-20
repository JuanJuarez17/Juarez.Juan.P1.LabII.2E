using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE_APP
{
    public class DbConnection
    {
        private string connectionString;
        protected SqlConnection connection;

        public DbConnection()
        {
            this.connectionString = @"Data Source=localhost;Initial Catalog=MAINTMANAG_DB;Integrated Security=True";
            this.connection = new SqlConnection(connectionString);
        }
        protected void OpenConnection()
        {
            this.connection.Open();
        }
        protected void CloseConnection()
        {
            this.connection.Close();
        }
    }
}
