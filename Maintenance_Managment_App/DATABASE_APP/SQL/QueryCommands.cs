using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DATABASE_APP
{
    public class QueryCommands
    {




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
        public static string UpdateQuery(string table, string[] attributes, string[] values)
        {
            string query = $"UPDATE {table} SET ";

            for (int i = 0; i < attributes.Length; i++)
            {
                if (i == (attributes.Length - 1))
                {
                    query = string.Concat(query, $"{attributes[i]} = {values[i]} ");
                }
                else
                {
                    query = string.Concat(query, $"{attributes[i]} = {values[i]}, ");
                }
            }
            return query;
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
