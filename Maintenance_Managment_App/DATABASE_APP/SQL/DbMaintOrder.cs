using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace DATABASE_APP
{
    public class DbMaintOrder : DbQuery, IDbManipulation<MaintenanceOrder>
    {
        public string[] ArrayProperties(MaintenanceOrder input)
        {
            string[] rtn = { $"'{input.Active}'", $"'{input.Username}'", $"'{input.Section}'", $"'{input.Machine}'", $"'{input.Urgency}'", $"'{input.Description}'", $"'{input.CreationDate:yyyy-MM-dd}'", $"'{input.Completed}'", $"'{input.EndDate:yyyy-MM-dd}'", };
            return rtn;
        }
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
        public List<MaintenanceOrder> Import()
        {
            List<MaintenanceOrder> rtn = new List<MaintenanceOrder>();
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1"));
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public List<MaintenanceOrder> Import(string atribute, int value)
        {
            List<MaintenanceOrder> rtn = new List<MaintenanceOrder>();
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1")
                                    + " AND " + $"{atribute} = {value}");
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }
        public void Create(MaintenanceOrder inputInstance)
        {
            string[] attributes = { "ACTIVE", "MAKER", "SECTION", "MACHINE", "URGENCY", "DESCR", "CREATION_DATE", "COMPLETED", "END_DATE" };
            string commandQuery = QueryCommands.InsertQuery("MAINTORDER", attributes, ArrayProperties(inputInstance));
            ExecuteNonQuery(commandQuery);
        }
        public void Update(int id, string attribute, string value)
        {
            ExecuteNonQuery(QueryCommands.UpdateQuery("MAINTORDER", attribute, value) + QueryCommands.ConditionWhere("ID", "=", id.ToString()));
        }
        public MaintenanceOrder Read(int id)
        {
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "MAINTORDER") + QueryCommands.ConditionWhere("ID", "=", id.ToString()));
            MaintenanceOrder rtn = ParseRow(dataTable.Rows[0]);
            return rtn;
        }
        public void Delete(int id)
        {
            ExecuteNonQuery(QueryCommands.UpdateQuery("MAINTORDER", "ACTIVE", "0") + QueryCommands.ConditionWhere("ID", "=", id.ToString()));
        }
        public int Count()
        {
            return (int)ExecuteScalar(QueryCommands.SelectQuery("COUNT(ID)", "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1"));
        }
        public int Count(string parameter, int value)
        {
            return (int)ExecuteScalar(QueryCommands.SelectQuery("COUNT(ID)", "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1")
                + $"AND {parameter} = {value}");
        }
        public string GetLast(string parameter)
        {
            return ExecuteScalar(QueryCommands.SelectQuery("TOP (1)" + parameter, "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1") + QueryCommands.OrderQuery("ID", "DESC")).ToString();
        }
        public string PrintParameter(int id, string parameter)
        {
            return ExecuteScalar(QueryCommands.SelectQuery(parameter, "MAINTORDER") + QueryCommands.ConditionWhere("ID", "=", id.ToString())).ToString();
        }
        public List<MaintenanceOrder> Sort(string parameter, string criteria)
        {
            List<MaintenanceOrder> rtn = new List<MaintenanceOrder>();
            DataTable dataTable = ExecuteReader(QueryCommands.SelectQuery("*", "MAINTORDER") + QueryCommands.ConditionWhere("ACTIVE", "=", "1") + QueryCommands.OrderQuery(parameter, criteria));
            foreach (DataRow row in dataTable.Rows)
            {
                rtn.Add(ParseRow(row));
            }
            return rtn;
        }


    }
}
