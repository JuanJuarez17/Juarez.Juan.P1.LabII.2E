using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace DATABASE_APP
{
    public class DbEntityUser : DbQuery, IDbManipulation<User>
    {
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

        // ExecuteReader
        public List<User> Import()
        {
            string[] attributes = { "ACTIVE" };
            object[] instanceProperties = { 1 };
            QueryCommands command = new QueryCommands();
            command.Select("*", "[USER]");
            command.WhereCondition(attributes[attributes.Length - 1]);
            List<User> rtn = new List<User>();
            DataTable dataTable = ExecuteReader(command.CommandString, attributes, instanceProperties);
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public User Read(string conditionValue)
        {
            string[] attributes = { "ACTIVE", "USERNAME" };
            object[] instanceProperties = { 1, conditionValue };
            QueryCommands command = new QueryCommands();
            command.Select("*", "[USER]");
            command.WhereCondition(attributes[attributes.Length - 2]);
            command.AndCondition(attributes[attributes.Length - 1]);
            DataTable dataTable = ExecuteReader(command.CommandString, attributes, instanceProperties);
            User rtn = ParseRow(dataTable.Rows[0]);
            return rtn;
        }

        // ExecuteNonQuery
        public void Create(User input)
        {
            string[] attributes = { "ACTIVE", "FILE_NUMBER", "USERNAME", "PASSWORD", "ADMIN", "NAME", "SURNAME", "AGE", "ENTRY_DATE", "DIVISION", "SHIFT", "CATEGORY" };
            object[] instanceProperties;
            if (input is Operator inputOp)
            {
                instanceProperties = new object[] { inputOp.Active, inputOp.FileNumber, inputOp.Username, inputOp.Password, inputOp.Admin, inputOp.Name, inputOp.Surname, inputOp.Age, inputOp.EntryDate, inputOp.Division.ToString(), inputOp.Shift.ToString(), inputOp.Category.ToString() };
            }
            else
            {
                instanceProperties = new object[] { input.Active, input.FileNumber, input.Username, input.Password, input.Admin, input.Name, input.Surname, input.Age, input.EntryDate, string.Empty, string.Empty, string.Empty };
            }

            QueryCommands command = new QueryCommands();
            command.Insert("[USER]");
            command.InsertAddAttributes(attributes);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }
        public void Update(User input, string conditionValue)
        {
            string[] attributes = { "NAME", "SURNAME", "AGE", "ENTRY_DATE", "DIVISION", "SHIFT", "CATEGORY", "USERNAME" };
            object[] instanceProperties;
            if (input is Operator inputOp)
            {
                instanceProperties = new object[] { inputOp.Name, inputOp.Surname, inputOp.Age, inputOp.EntryDate, inputOp.Division.ToString(), inputOp.Shift.ToString(), inputOp.Category.ToString(), conditionValue };
            }
            else
            {
                instanceProperties = new object[] { input.Name, input.Surname, input.Age, input.EntryDate, null, null, null, conditionValue };
            }
            QueryCommands command = new QueryCommands();
            command.Update("[USER]");
            command.UpdateAddAttributes(attributes);
            command.WhereCondition(attributes[attributes.Length - 1]);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }
        public void Delete(string conditionValue)
        {
            string[] attributes = { "ACTIVE", "USERNAME" };
            object[] instanceProperties = { 0, conditionValue };
            QueryCommands command = new QueryCommands();
            command.Update("[USER]");
            command.UpdateAddAttributes(attributes);
            command.WhereCondition(attributes[attributes.Length - 1]);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }

        // ExecuteScalar
        public int Count(string parameter, string parameterValue)
        {
            string[] attributes = { parameter };
            object[] instanceProperties = { parameterValue };
            QueryCommands command = new QueryCommands();
            command.SelectCount("USERNAME", "[USER]");
            command.WhereCondition(attributes[attributes.Length - 1]);
            return (int)ExecuteScalar(command.CommandString, attributes, instanceProperties);
        }
        public string GetLast(string parameter)
        {
            throw new NotImplementedException();
        }
    }
}
