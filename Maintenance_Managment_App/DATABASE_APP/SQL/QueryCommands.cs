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


        public void WhereCondition(string condition)
        {
            this.commandString += $"WHERE {condition} = @{condition.ToLower()} ";
        }
        public void AndCondition(string condition)
        {
            this.commandString += $"AND {condition} = @{condition.ToLower()} ";
        }
        public void OrderCondition(string attribute, string orderCriteria)
        {
            this.commandString += $"ORDER BY {attribute} {orderCriteria} ";
        }





        public static string SelectQuery(string atribute, string table)
        {
            return $"SELECT {atribute} FROM {table}";
        }
        public static string InsertQuery(string table, string[] attributes, string[] values)
        {
            string query = $"INSERT INTO {table} ";
            for (int i = 0; i < attributes.Length; i++)
            {
                if (i == 0)
                {
                    query = string.Concat(query, $"({attributes[i]}");
                }
                else if (i == (attributes.Length - 1))
                {
                    query = string.Concat(query, $", {attributes[i]}) VALUES ");
                }
                else
                {
                    query = string.Concat(query, $", {attributes[i]}");
                }
            }
            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                {
                    query = string.Concat(query, $"({values[i]}");
                }
                else if (i == (attributes.Length - 1))
                {
                    query = string.Concat(query, $", {values[i]})");
                }
                else
                {
                    query = string.Concat(query, $", {values[i]}");
                }
            }
            return query;
        }
        public static string UpdateQuery(string table, string attribute, string value)
        {
            return $"UPDATE {table} SET {attribute} = '{value}'";
        }
        public static string ConditionWhere(string attribute, string comparator, string condition)
        {
            return $" WHERE {attribute} {comparator} {condition}";
        }
        public static string OrderQuery(string attribute, string criteria)
        {
            return $" ORDER BY {attribute} {criteria}";
        }

    }
}
