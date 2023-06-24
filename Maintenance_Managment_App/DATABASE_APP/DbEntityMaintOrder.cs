using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Data;

namespace DATABASE_APP
{
    public class DbEntityMaintOrder : DbQuery, IDbManipulation<MaintenanceOrder>
    {
        public MaintenanceOrder ParseRow(DataRow inputRow)
        {
            MaintenanceOrder rtn = new MaintenanceOrder();
            int.TryParse(inputRow["ID"].ToString(), out int inputId);
            bool.TryParse(inputRow["ACTIVE"].ToString(), out bool inputActive);
            string inputUser = inputRow["MAKER"].ToString();
            Enum.TryParse(inputRow["SECTION"].ToString(), out Section inputSection);
            Enum.TryParse(inputRow["MACHINE"].ToString(), out Machine inputMachine);
            Enum.TryParse(inputRow["URGENCY"].ToString(), out Urgency inputUrgency);
            string inputDescription = inputRow["DESCR"].ToString();
            DateTime.TryParse(inputRow["CREATION_DATE"].ToString(), out DateTime inputCreationDate);
            bool.TryParse(inputRow["COMPLETED"].ToString(), out bool inputCompleted);
            DateTime.TryParse(inputRow["END_DATE"].ToString(), out DateTime inputEndDate);
            rtn.Id = inputId;
            rtn.Active = inputActive;
            rtn.Username = inputUser;
            rtn.Section = inputSection;
            rtn.Machine = inputMachine;
            rtn.Urgency = inputUrgency;
            rtn.Description = inputDescription;
            rtn.CreationDate = inputCreationDate;
            rtn.Completed = inputCompleted;
            rtn.EndDate = inputEndDate;
            return rtn;
        }

        // ExecuteReader
        public List<MaintenanceOrder> Import()
        {
            string[] attributes = { "ACTIVE" };
            object[] instanceProperties = { 1 };
            QueryCommands command = new QueryCommands();
            command.Select("*", "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 1]);
            List<MaintenanceOrder> rtn = new List<MaintenanceOrder>();
            DataTable dataTable = ExecuteReader(command.CommandString, attributes, instanceProperties);
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public List<MaintenanceOrder> Import(string parameter, string parameterValue)
        {
            string[] attributes = { "ACTIVE", parameter};
            object[] instanceProperties = { 1, parameterValue };
            QueryCommands command = new QueryCommands();
            command.Select("*", "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 2]);
            command.AndCondition(attributes[attributes.Length - 1]);
            List<MaintenanceOrder> rtn = new List<MaintenanceOrder>();
            DataTable dataTable = ExecuteReader(command.CommandString, attributes, instanceProperties);
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public MaintenanceOrder Read(string conditionValue)
        {
            string[] attributes = { "ID" };
            object[] instanceProperties = { conditionValue };
            QueryCommands command = new QueryCommands();
            command.Select("*", "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 1]);
            DataTable dataTable = ExecuteReader(command.CommandString, attributes, instanceProperties);
            MaintenanceOrder rtn = ParseRow(dataTable.Rows[0]);
            return rtn;
        }

        // ExecuteNonQuery
        public void Create(MaintenanceOrder input)
        {
            string[] attributes = { "ACTIVE", "MAKER", "SECTION", "MACHINE", "URGENCY", "DESCR", "CREATION_DATE", "COMPLETED", "END_DATE" };
            object[] instanceProperties = { input.Active, input.Username, input.Section.ToString(), input.Machine.ToString(), input.Urgency.ToString(), input.Description, input.CreationDate, input.Completed, input.EndDate };
            QueryCommands command = new QueryCommands();
            command.Insert("MAINTORDER");
            command.InsertAddAttributes(attributes);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }
        public void Update(MaintenanceOrder input, string conditionValue)
        {
            string[] attributes = { "SECTION", "MACHINE", "URGENCY", "DESCR", "COMPLETED", "ID"};
            object[] instanceProperties = { input.Section.ToString(), input.Machine.ToString(), input.Urgency.ToString(), input.Description, input.Completed, conditionValue };
            QueryCommands command = new QueryCommands();
            command.Update("MAINTORDER");
            command.UpdateAddAttributes(attributes);
            command.WhereCondition(attributes[attributes.Length - 1]);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }
        public void Update(string updateAttribute, string updateValue, string conditionValue)
        {
            string[] attributes = { updateAttribute, "ID" };
            object[] instanceProperties = { updateValue, conditionValue };
            QueryCommands command = new QueryCommands();
            command.Update("MAINTORDER");
            command.UpdateAddAttributes(attributes);
            command.WhereCondition(attributes[attributes.Length - 1]);
            ExecuteNonQuery(command.CommandString, attributes, instanceProperties);
        }
        public void Delete(string conditionValue)
        {
            string[] attributes = { "ACTIVE", "ID" };
            object[] instanceProperties = { 0, conditionValue };
            QueryCommands command = new QueryCommands();
            command.Update("MAINTORDER");
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
            command.SelectCount("ID", "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 1]);
            return (int)ExecuteScalar(command.CommandString, attributes, instanceProperties);
        }
        public int Count(string parameter, string parameterValue, string sndParameter, string sndParameterValue)
        {
            string[] attributes = { parameter, sndParameter };
            object[] instanceProperties = { parameterValue, sndParameterValue };
            QueryCommands command = new QueryCommands();
            command.SelectCount("ID", "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 2]);
            command.AndCondition(attributes[attributes.Length - 1]);
            return (int)ExecuteScalar(command.CommandString, attributes, instanceProperties);
        }
        public string GetLast(string parameter)
        {
            string[] attributes = { "ACTIVE" };
            object[] instanceProperties = { 1 };
            QueryCommands command = new QueryCommands();
            command.SelectTop(parameter, "MAINTORDER");
            command.WhereCondition(attributes[attributes.Length - 1]);
            command.OrderCondition(parameter, "DESC");
            return (ExecuteScalar(command.CommandString, attributes, instanceProperties)).ToString();
        }
    }
}
