using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATABASE_APP.SQL
{
    public class MySqlCommand
    {
        private string commandString;

        public string CommandString { get => commandString; }

        public MySqlCommand()
        {
            this.commandString = string.Empty;
        }
        public static implicit operator string(MySqlCommand input) 
        {
            return input.CommandString;
        }
        public void Select(string databaseTable)
        {
            this.commandString = $"SELECT * FROM {databaseTable}";
        }
        public void Select(string databaseTable, string attribute)
        {
            this.commandString = $"SELECT {attribute} FROM {databaseTable}";
        }
        public void Insert(string databaseTable)
        {
            this.commandString = $"INSERT INTO {databaseTable} VALUES";
        }
        public void Update(string databaseTable)
        {
            this.commandString = $"UPDATE {databaseTable} SET";
        }
        public void Delete(string databaseTable)
        {
            this.commandString = $"DELETE FROM {databaseTable}";
        }
    }
}
