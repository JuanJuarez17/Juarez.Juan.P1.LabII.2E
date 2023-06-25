using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DATABASE_APP
{
    public class QueryCommands
    {
        private string commandString;

        public string CommandString { get => commandString; }

        public QueryCommands()
        {
            this.commandString = string.Empty;
        }

        // Basic Querys
        public void Insert(string databaseTable)
        {
            this.commandString = $"INSERT INTO {databaseTable} VALUES ";
        }
        public void InsertAddAttributes(string[] attributes)
        {
            StringBuilder query = new StringBuilder();
            query.Append(this.commandString);
            if (attributes.Length == 1)
            {
                query.Append($"(@{attributes[0].ToLower()})");
            }
            else
            {
                for (int i = 0; i < attributes.Length; i++)
                {
                    if (i == 0)
                    {
                        query.Append($"(@{attributes[i].ToLower()}");
                    }
                    else if (i == (attributes.Length - 1))
                    {
                        query.Append($", @{attributes[i].ToLower()})");
                    }
                    else
                    {
                        query.Append($", @{attributes[i].ToLower()}");
                    }
                }
            }
            this.commandString = query.ToString();
        }
        public void Update(string databaseTable)
        {
            this.commandString = $"UPDATE {databaseTable} SET ";
        }
        public void UpdateAddAttributes(string[] attributes)
        {
            StringBuilder query = new StringBuilder();
            query.Append(this.commandString);
            if (attributes.Length == 2)
            {
                query.Append($"{attributes[0]} = @{attributes[0].ToLower()} ");
            }
            else
            {
                for (int i = 0; i < attributes.Length - 1; i++)
                {
                    if (i == (attributes.Length - 2))
                    {
                        query.Append($"{attributes[i]} = @{attributes[i].ToLower()} ");
                    }
                    else
                    {
                        query.Append($"{attributes[i]} = @{attributes[i].ToLower()}, ");
                    }
                }
            }
            this.commandString = query.ToString();
        }
        public void Select(string attribute, string databaseTable)
        {
            this.commandString = $"SELECT {attribute} FROM {databaseTable} ";
        }
        public void SelectTop(string attribute, string databaseTable)
        {
            this.commandString = $"SELECT TOP(1) {attribute} FROM {databaseTable} ";
        }
        public void SelectCount(string attribute, string databaseTable)
        {
            this.commandString = $"SELECT COUNT({attribute}) FROM {databaseTable} ";
        }

        // Condition Querys
        public void WhereCondition(string condition)
        {
            this.commandString += $"WHERE {condition} = @{condition.ToLower()} ";
        }

        public void WhereConditionInner(string condition)
        {
            this.commandString += $"WHERE {condition[0].ToString().ToLower()}.{condition} = @{condition.ToLower()} ";
        }

        public void AndCondition(string condition)
        {
            this.commandString += $"AND {condition} = @{condition.ToLower()} ";
        }

        // Order Query
        public void OrderCondition(string attribute, string orderCriteria)
        {
            this.commandString += $"ORDER BY {attribute} {orderCriteria} ";
        }



        public void InnerJoin(string primaryTable, string sndTable, string primaryKey, string foreignKey)
        {
            this.commandString += $"INNER JOIN {sndTable} m ON {primaryTable[0].ToString().ToLower()}.{primaryKey} = {sndTable[0].ToString().ToLower()}.{foreignKey} ";
        }
    }
}
