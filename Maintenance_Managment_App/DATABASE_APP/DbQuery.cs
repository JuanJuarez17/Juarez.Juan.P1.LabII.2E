using System.Data;
using System.Data.SqlClient;

namespace DATABASE_APP
{
    public class DbQuery : DbConnection
    {
        private SqlCommand command;
        public DbQuery()
        {
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
        }
        protected DataTable ExecuteReader(string inputCommand, string[] inputParameters, object[] inputValues)
        {
            OpenConnection();
            command.Parameters.Clear();
            command.CommandText = inputCommand;
            for (int i = 0; i < inputParameters.Length; i++)
            {
                command.Parameters.AddWithValue($"@{inputParameters[i].ToLower()}", inputValues[i]);
            }
            DataTable dataTable = new DataTable();
            SqlDataReader dataReader = command.ExecuteReader();
            dataTable.Load(dataReader);
            CloseConnection();
            return dataTable;
        }
        protected int ExecuteNonQuery(string inputCommand, string[] inputParameters, object[] inputValues)
        {
            int rtn;
            OpenConnection();
            command.Parameters.Clear();
            command.CommandText = inputCommand;
            for (int i = 0; i < inputParameters.Length; i++)
            {
                command.Parameters.AddWithValue($"@{inputParameters[i].ToLower()}", inputValues[i]);
            }
            rtn = command.ExecuteNonQuery();
            CloseConnection();
            return rtn;
        }
        protected object ExecuteScalar(string inputCommand, string[] inputParameters, object[] inputValues)
        {
            object rtn;
            OpenConnection();
            command.Parameters.Clear();
            command.CommandText = inputCommand;
            for (int i = 0; i < inputParameters.Length; i++)
            {
                command.Parameters.AddWithValue($"@{inputParameters[i].ToLower()}", inputValues[i]);
            }
            rtn = command.ExecuteScalar();
            CloseConnection();
            return rtn;
        }
    }
}
