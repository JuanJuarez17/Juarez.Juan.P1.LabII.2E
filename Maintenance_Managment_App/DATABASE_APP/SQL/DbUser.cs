using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE_APP
{
    public class DbUser : DbQuery, IDbManipulation<User>
    {
        public string[] ArrayProperties(User inputInstance)
        {
            if (inputInstance is Operator auxOperator)
            {
                string[] rtn = { $"'{auxOperator.Active}'", $"'{auxOperator.FileNumber}'", $"'{auxOperator.Username}'", $"'{auxOperator.Password}'", $"'{auxOperator.Admin}'", $"'{auxOperator.Name}'", $"'{auxOperator.Surname}'", $"'{auxOperator.Age}'", $"'{auxOperator.EntryDate:yyyy-MM-dd}'", $"'{auxOperator.Division}'", $"'{auxOperator.Shift}'", $"'{auxOperator.Category}'" };
                return rtn;
            }
            else
            {
                string[] rtn = { $"'{inputInstance.Active}'", $"'{inputInstance.FileNumber}'", $"'{inputInstance.Username}'", $"'{inputInstance.Password}'", $"'{inputInstance.Admin}'", $"'{inputInstance.Name}'", $"'{inputInstance.Surname}'", $"'{inputInstance.Age}'", $"'{inputInstance.EntryDate:yyyy-MM-dd}'", "null", "null", "null" };
                return rtn;
            }
        }

        public int Count()
        {
            return (int)ExecuteScalar(QueryCommands.SelectQuery("COUNT(USERNAME)", "[USER]") + QueryCommands.ConditionWhere("ACTIVE", "=", "1"));
        }

        public void Create(User inputInstance)
        {
            string[] attributes = { "ACTIVE", "FILE_NUMBER", "USERNAME", "PASSWORD", "ADMIN", "NAME", "SURNAME", "AGE", "ENTRY_DATE", "DIVISION", "SHIFT", "CATEGORY" };
            string commandQuery = QueryCommands.InsertQuery("[USER]", attributes, ArrayProperties(inputInstance));
            ExecuteNonQuery(commandQuery);
        }

        public void Delete(string username)
        {
            ExecuteNonQuery(QueryCommands.UpdateQuery("[USER]", "ACTIVE", "0") + QueryCommands.ConditionWhere("USERNAME", "=", $"'{username}'"));
        }

        public string GetLast(string parameter)
        {
            throw new NotImplementedException();
        }

        public List<User> Import()
        {
            List<User> rtn = new List<User>();
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "[USER]") + QueryCommands.ConditionWhere("ACTIVE", "=", "1"));
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public List<string> ImportUsernames()
        {
            List<User> list = Import();
            List<string> rtn = new List<string>();
            foreach (User item in list)
            {
                if (!item.Admin && item.Username != "Operario")
                {
                    rtn.Add(item.Username);
                }
            }
            return rtn;
        }

        public User ParseRow(DataRow inputRow)
        {
            User rtn;
            bool.TryParse(inputRow["ADMIN"].ToString(), out bool inputAdmin);
            int.TryParse(inputRow["FILE_NUMBER"].ToString(), out int inputFileNumber);
            string inputUsername = inputRow["USERNAME"].ToString();
            string inputPassword = inputRow["PASSWORD"].ToString();
            bool.TryParse(inputRow["ACTIVE"].ToString(), out bool inputActive);
            string inputName = inputRow["NAME"].ToString();
            string inputSurname = inputRow["SURNAME"].ToString();
            int.TryParse(inputRow["AGE"].ToString(), out int inputAge);
            DateTime.TryParse(inputRow["ENTRY_DATE"].ToString(), out DateTime inputEntryDate);
            if (!inputAdmin)
            {
                Enum.TryParse(inputRow["DIVISION"].ToString(), out Division inputDivision);
                Enum.TryParse(inputRow["SHIFT"].ToString(), out Shift inputShift);
                Enum.TryParse(inputRow["CATEGORY"].ToString(), out Category inputCategory);
                rtn = new Operator(inputFileNumber, inputUsername, inputPassword);
                rtn.Active = inputActive;
                rtn.Name = inputName;
                rtn.Surname = inputSurname;
                rtn.Age = inputAge;
                rtn.EntryDate = inputEntryDate;
                ((Operator)rtn).Division = inputDivision;
                ((Operator)rtn).Shift = inputShift;
                ((Operator)rtn).Category = inputCategory;
            }
            else
            {
                rtn = new Supervisor(inputFileNumber, inputUsername, inputPassword);
                rtn.Active = inputActive;
                rtn.Name = inputName;
                rtn.Surname = inputSurname;
                rtn.Age = inputAge;
                rtn.EntryDate = inputEntryDate;
            }
            return rtn;
        }

        public string PrintParameter(string primaryKey, string parameter)
        {
            throw new NotImplementedException();
        }

        public User Read(string username)
        {
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "[USER]") + QueryCommands.ConditionWhere("ACTIVE", "=", "1") + $"AND USERNAME = '{username}'");
            User rtn = ParseRow(dataTable.Rows[0]);
            return rtn;
        }

        public List<User> Sort(string parameter, string criteria)
        {
            throw new NotImplementedException();
        }

        public void Update(string username, string attribute, string value)
        {
            ExecuteNonQuery(QueryCommands.UpdateQuery("[USER]", attribute, value) + QueryCommands.ConditionWhere("USERNAME", "=", $"'{username}'"));
        }
    }
}
