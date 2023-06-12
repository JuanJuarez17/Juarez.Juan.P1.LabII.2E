using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ENTITIES_APP;

namespace DATABASE_APP
{
    public static class SqlServerConnection
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;
        private static bool importedDbFlag = false;

        public static bool ImportedDbFlag
        {
            get { return importedDbFlag; }
        }

        static SqlServerConnection()
        {
            connectionString = @"Data Source=localhost;Initial Catalog=MAINTMANAG_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
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
                if (inputCriteria == "ACTIVE")
                {
                    command.CommandText = "SELECT * FROM MAINTORDER WHERE ACTIVE = 1";
                }
                if (inputCriteria == "COMPLETED")
                {
                    command.CommandText = "SELECT * FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 1";
                }
                if (inputCriteria == "UNCOMPLETED")
                {
                    command.CommandText = "SELECT * FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 0";
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
                if (inputCriteria == "ACTIVE")
                {
                    command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1";
                }
                if (inputCriteria == "COMPLETED")
                {
                    command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 1";
                }
                if (inputCriteria == "UNCOMPLETED")
                {
                    command.CommandText = $"SELECT ID FROM MAINTORDER WHERE ACTIVE = 1 AND COMPLETED = 0";
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
                        return auxMaintOrder.Id.ToString();
                    case "USERNAME":
                        return auxMaintOrder.Username.ToString();
                    case "SECTION":
                        return auxMaintOrder.Section.ToString();
                    case "MACHINE":
                        return auxMaintOrder.Machine.ToString();
                    case "URGENCY":
                        return auxMaintOrder.Urgency.ToString();
                    case "ANTIQUITY":
                        return auxMaintOrder.Antiquity.ToString();
                    case "DESCRIPTION":
                        return auxMaintOrder.Description.ToString();
                    case "STATUS":
                        return auxMaintOrder.Completed.ToString();
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

        public static List<MaintenanceOrder> Sort()
        {
            List<MaintenanceOrder> maintOrders = new List<MaintenanceOrder>();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM MAINTORDER ORDER BY ID DESC;";
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
