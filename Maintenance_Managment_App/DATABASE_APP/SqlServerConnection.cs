using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITIES_APP;
using System.Windows.Input;

namespace DATABASE_APP
{
    public static class SqlServerConnection
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static bool importedDbFlag = false;
        private static string sqlSelectQuery = "SELECT * FROM";
        public static bool ImportedDbFlag
        {
            get { return importedDbFlag; }
        }
        static SqlServerConnection()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=MAINTMANAG_DB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        public static List<MaintenanceOrder> ImportDb(string inputCriteria)
        {
            List<MaintenanceOrder> maintOrders = new List<MaintenanceOrder>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                switch (inputCriteria)
                {
                    case "COMPLETED":
                        command.CommandText = "SELECT * FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 1";
                        break;
                    case "UNCOMPLETED":
                        command.CommandText = sqlSelectQuery + " MAINTORDER" + " WHERE ACTIVE = 1 AND COMPLETED = 0";
                        break;
                    default:
                        command.CommandText = sqlSelectQuery + " MAINTORDER" + " WHERE ACTIVE = 1";
                        break;
                }
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MaintenanceOrder auxMaintOrder = new MaintenanceOrder();

                    int.TryParse(dataReader["ID"].ToString(), out int inputId);
                    bool.TryParse(dataReader["ACTIVE"].ToString(), out bool inputActive);
                    string inputUser = dataReader["MAKER"].ToString();
                    Enum.TryParse(dataReader["SECTION"].ToString(), out Section inputSection);
                    Enum.TryParse(dataReader["MACHINE"].ToString(), out Machine inputMachine);
                    Enum.TryParse(dataReader["URGENCY"].ToString(), out Urgency inputUrgency);
                    string inputDescription = dataReader["DESCR"].ToString();
                    DateTime.TryParse(dataReader["CREATION_DATE"].ToString(), out DateTime inputCreationDate);
                    bool.TryParse(dataReader["COMPLETED"].ToString(), out bool inputCompleted);
                    DateTime.TryParse(dataReader["END_DATE"].ToString(), out DateTime inputEndDate);

                    auxMaintOrder.Id = inputId;
                    auxMaintOrder.Active = inputActive;
                    auxMaintOrder.Username = inputUser;
                    auxMaintOrder.Section = inputSection;
                    auxMaintOrder.Machine = inputMachine;
                    auxMaintOrder.Urgency = inputUrgency;
                    auxMaintOrder.Description = inputDescription;
                    auxMaintOrder.CreationDate = inputCreationDate;
                    auxMaintOrder.Completed = inputCompleted;
                    auxMaintOrder.EndDate = inputEndDate;
                    maintOrders.Add(auxMaintOrder);
                }
                importedDbFlag = true;
                return maintOrders;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Create(string activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription)
        {
            MaintenanceOrder auxMaintOrder = new MaintenanceOrder(activeUser, inputSection, inputMachine, inputUrgency, inputDescription);
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO MAINTORDER (ACTIVE, MAKER, SECTION, MACHINE, URGENCY, DESCR, CREATION_DATE, COMPLETED, END_DATE) " +
                                                      $"VALUES (@active, @maker, @section, @machine, @urgency, @descr, @creaionDate, @completed, @endDate)";
                command.Parameters.AddWithValue("@active", auxMaintOrder.Active);
                command.Parameters.AddWithValue("@maker", auxMaintOrder.Username);
                command.Parameters.AddWithValue("@section", auxMaintOrder.Section.ToString());
                command.Parameters.AddWithValue("@machine", auxMaintOrder.Machine.ToString());
                command.Parameters.AddWithValue("@urgency", auxMaintOrder.Urgency.ToString());
                command.Parameters.AddWithValue("@descr", auxMaintOrder.Description);
                command.Parameters.AddWithValue("@creaionDate", auxMaintOrder.CreationDate);
                command.Parameters.AddWithValue("@completed", auxMaintOrder.Completed);
                command.Parameters.AddWithValue("@endDate", auxMaintOrder.EndDate);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static MaintenanceOrder Read(int inputId)
        {
            MaintenanceOrder auxMaintOrder = new MaintenanceOrder();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT * FROM MAINTORDER WHERE ID = @id";
                command.Parameters.AddWithValue("@id", inputId);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int.TryParse(dataReader["ID"].ToString(), out int inputIdMO);
                    bool.TryParse(dataReader["ACTIVE"].ToString(), out bool inputActive);
                    string inputUser = dataReader["MAKER"].ToString();
                    Enum.TryParse(dataReader["SECTION"].ToString(), out Section inputSection);
                    Enum.TryParse(dataReader["MACHINE"].ToString(), out Machine inputMachine);
                    Enum.TryParse(dataReader["URGENCY"].ToString(), out Urgency inputUrgency);
                    string inputDescription = dataReader["DESCR"].ToString();
                    DateTime.TryParse(dataReader["CREATION_DATE"].ToString(), out DateTime inputCreationDate);
                    bool.TryParse(dataReader["COMPLETED"].ToString(), out bool inputCompleted);
                    DateTime.TryParse(dataReader["END_DATE"].ToString(), out DateTime inputEndDate);
                    auxMaintOrder.Id = inputIdMO;
                    auxMaintOrder.Active = inputActive;
                    auxMaintOrder.Username = inputUser;
                    auxMaintOrder.Section = inputSection;
                    auxMaintOrder.Machine = inputMachine;
                    auxMaintOrder.Urgency = inputUrgency;
                    auxMaintOrder.Description = inputDescription;
                    auxMaintOrder.CreationDate = inputCreationDate;
                    auxMaintOrder.Completed = inputCompleted;
                    auxMaintOrder.EndDate = inputEndDate;
                }
                return auxMaintOrder;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool Update(int inputId, Section inputSection, Machine inputMachine, Urgency inputUrgency, string inputDescription, bool inputStatus)
        {
            bool rtn = false;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE MAINTORDER SET SECTION = @section, MACHINE = @machine, URGENCY = @urgency, DESCR = @descr, COMPLETED = @completed, END_DATE = @endDate WHERE ID = @id";
                command.Parameters.AddWithValue("@id", inputId);
                command.Parameters.AddWithValue("@section", inputSection.ToString());
                command.Parameters.AddWithValue("@machine", inputMachine.ToString());
                command.Parameters.AddWithValue("@urgency", inputUrgency.ToString());
                command.Parameters.AddWithValue("@descr", inputDescription);
                command.Parameters.AddWithValue("@completed", inputStatus);
                if (inputStatus)
                {
                    command.Parameters.AddWithValue("@endDate", DateTime.Now.Date);
                }
                else
                {
                    command.Parameters.AddWithValue("@endDate", new DateTime(1753, 1, 1));
                }
                command.ExecuteNonQuery();
                rtn = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return rtn;
        }
        public static bool Delete(int inputId)
        {
            bool rtn = false;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE MAINTORDER SET ACTIVE = @active WHERE ID = @id";
                command.Parameters.AddWithValue("@id", inputId);
                command.Parameters.AddWithValue("@active", 0);
                command.ExecuteNonQuery();
                rtn = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return rtn;
        }
        public static int GetLastId()
        {
            int rtn = -1;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "SELECT TOP 1 ID FROM MAINTORDER ORDER BY ID DESC";
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int.TryParse(dataReader["ID"].ToString(), out int idAdded);
                    return idAdded;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return rtn;
        }
        public static int Count(string inputCriteria)
        {
            int counter = 0;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                switch (inputCriteria)
                {
                    case "COMPLETED":
                        command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 1";
                        break;
                    case "UNCOMPLETED":
                        command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 0";
                        break;
                    default:
                        command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1";
                        break;
                }
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    counter++;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return counter;
        }
        public static string PrintParameter(int inputId, string inputParameter)
        {
            string rtn = string.Empty;
            try
            {
                MaintenanceOrder auxMaintOrder = Read(inputId);
                switch (inputParameter)
                {
                    case "ID":
                        rtn =  auxMaintOrder.Id.ToString();
                        break;
                    case "USERNAME":
                        rtn = auxMaintOrder.Username.ToString();
                        break;
                    case "SECTION":
                        rtn = auxMaintOrder.Section.ToString();
                        break;
                    case "MACHINE":
                        rtn = auxMaintOrder.Machine.ToString();
                        break;
                    case "URGENCY":
                        rtn = auxMaintOrder.Urgency.ToString();
                        break;
                    case "ANTIQUITY":
                        rtn = auxMaintOrder.Antiquity.ToString();
                        break;
                    case "DESCRIPTION":
                        rtn = auxMaintOrder.Description.ToString();
                        break;
                    case "STATUS":
                        rtn = auxMaintOrder.Completed.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return rtn;
        }
        public static List<MaintenanceOrder> Sort(string inputOrder)
        {
            List<MaintenanceOrder> maintOrders = new List<MaintenanceOrder>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                switch (inputOrder)
                {
                    case "DATE":
                        command.CommandText = $"SELECT * FROM MAINTORDER WHERE ACTIVE = 1 ORDER BY CREATION_DATE DESC;";
                        break;
                    case "SECTION":
                        command.CommandText = $"SELECT * FROM MAINTORDER WHERE ACTIVE = 1 ORDER BY SECTION DESC;";
                        break;
                    case "MACHINE":
                        command.CommandText = $"SELECT * FROM MAINTORDER WHERE ACTIVE = 1 ORDER BY MACHINE DESC;";
                        break;
                    case "URGENCY":
                        command.CommandText = $"SELECT * FROM MAINTORDER WHERE ACTIVE = 1 ORDER BY URGENCY DESC;";
                        break;
                    default:
                        break;
                }
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MaintenanceOrder auxMaintOrder = new MaintenanceOrder();

                    int.TryParse(dataReader["ID"].ToString(), out int inputId);
                    bool.TryParse(dataReader["ACTIVE"].ToString(), out bool inputActive);
                    string inputUser = dataReader["MAKER"].ToString();
                    Enum.TryParse(dataReader["SECTION"].ToString(), out Section inputSection);
                    Enum.TryParse(dataReader["MACHINE"].ToString(), out Machine inputMachine);
                    Enum.TryParse(dataReader["URGENCY"].ToString(), out Urgency inputUrgency);
                    string inputDescription = dataReader["DESCR"].ToString();
                    DateTime.TryParse(dataReader["CREATION_DATE"].ToString(), out DateTime inputCreationDate);
                    bool.TryParse(dataReader["COMPLETED"].ToString(), out bool inputCompleted);
                    DateTime.TryParse(dataReader["END_DATE"].ToString(), out DateTime inputEndDate);

                    auxMaintOrder.Id = inputId;
                    auxMaintOrder.Active = inputActive;
                    auxMaintOrder.Username = inputUser;
                    auxMaintOrder.Section = inputSection;
                    auxMaintOrder.Machine = inputMachine;
                    auxMaintOrder.Urgency = inputUrgency;
                    auxMaintOrder.Description = inputDescription;
                    auxMaintOrder.CreationDate = inputCreationDate;
                    auxMaintOrder.Completed = inputCompleted;
                    auxMaintOrder.EndDate = inputEndDate;
                    maintOrders.Add(auxMaintOrder);
                }
                importedDbFlag = true;
                return maintOrders;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

