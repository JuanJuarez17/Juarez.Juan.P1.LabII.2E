using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DATABASE_APP
{
    public class Database
    {
        #region ATTRIBUTES
        private bool maintOrderDbLoaded = false;
        private List<MaintenanceOrder> maintOrdersDb;
        private List<User> usersDb;
        #endregion

        #region READONLY PROPERTIES

        // UserDb Properties
        public List<User> UserDb { get { return this.usersDb; } }

        // MaintOrderDb Properties
        public bool MaintOrderDbLoaded { get { return this.maintOrderDbLoaded; } }
        public List<MaintenanceOrder> MaintOrderDb { get { return this.maintOrdersDb; } }
        public List<MaintenanceOrder> ActiveMaintOrders
        {
            get
            {
                List<MaintenanceOrder> activeMaintOrders = new List<MaintenanceOrder>();

                foreach (MaintenanceOrder item in this.MaintOrderDb)
                {
                    if (item.Active)
                    {
                        activeMaintOrders.Add(item);
                    }
                }
                return activeMaintOrders;
            }
        }
        public List<MaintenanceOrder> CompletedMaintOrders
        {
            get
            {
                List<MaintenanceOrder> completedMaintOrders = new List<MaintenanceOrder>();

                foreach (MaintenanceOrder item in this.ActiveMaintOrders)
                {
                    if (item.Completed)
                    {
                        completedMaintOrders.Add(item);
                    }
                }
                return completedMaintOrders;
            }
        }
        public List<MaintenanceOrder> UncompletedMaintOrders
        {
            get
            {
                List<MaintenanceOrder> uncompletedMaintOrders = new List<MaintenanceOrder>();

                foreach (MaintenanceOrder item in this.ActiveMaintOrders)
                {
                    if (!item.Completed)
                    {
                        uncompletedMaintOrders.Add(item);
                    }
                }
                return uncompletedMaintOrders;
            }
        }
        public int NumberCompletedOrders
        {
            get
            {
                int count = 0;
                foreach (MaintenanceOrder item in this.ActiveMaintOrders)
                {
                    if (item.Completed == true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int NumberUncompletedOrders
        {
            get
            {
                int count = 0;
                foreach (MaintenanceOrder item in this.ActiveMaintOrders)
                {
                    if (item.Completed == false)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        #endregion

        #region CONSTRUCTOR
        public Database()
        {
            this.usersDb = new List<User>();
            this.maintOrdersDb = new List<MaintenanceOrder>();
            User_LoadGenericUsers();
        }
        #endregion

        #region USER DB METHODS
        // Aplication Run
        private void User_LoadGenericUsers()
        {
            this.usersDb.Add(new Operator(001, "Operario", "oper123"));
            this.usersDb.Add(new Supervisor(002, "Supervisor", "super456"));
        }

        // UserDb Methods
        public int User_CheckExist(string inputUsername, string inputPassword)
        {
            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                return -1;
            }
            else
            {
                foreach (User item in this.UserDb)
                {
                    if (item.CheckUsername(inputUsername) && item.Active == true)
                    {
                        if (item.CheckPassword(inputPassword))
                        {
                            return 1;
                        }
                    }
                }
                return 0;
            }
        } // Usado en Login
        public bool User_CheckFileNumberAvailable(int inputFileNumber)
        {
            bool rtn = true;
            if (inputFileNumber >= 100 && inputFileNumber <= 999)
            {
                foreach (User item in this.UserDb)
                {
                    if (item.FileNumber == inputFileNumber)
                    {
                        return false;
                    }
                }
            }
            return rtn;
        }
        public bool User_FindInDb(int inputFileNumber, out int findedIndex)
        {
            bool rtn = false;
            findedIndex = -1;
            if (this.UserDb != null && this.UserDb.Count > 0)
            {
                foreach (User item in this.UserDb)
                {
                    if (item.FileNumber == inputFileNumber && item.Active == true)
                    {
                        findedIndex = this.UserDb.IndexOf(item);
                        return true;
                    }
                }
            }
            return rtn;
        }
        public bool User_FindInDb(string inputUsername, out int findedIndex)
        {
            bool rtn = false;
            findedIndex = -1;
            if (this.UserDb != null && this.UserDb.Count > 0)
            {
                foreach (User item in this.UserDb)
                {
                    if (item.Username == inputUsername && item.Active == true)
                    {
                        findedIndex = this.UserDb.IndexOf(item);
                        return true;
                    }
                }
            }
            return rtn;
        }
        public User User_Return(string inputUsername) // Usado en Login y Hardcodeo
        {
            foreach (User item in this.UserDb)
            {
                if (item.CheckUsername(inputUsername))
                {
                    return item;
                }
            }
            return null;
        }
        public User User_Return(int inputIndex) // Usado en Gestion de usuario dentro del soft
        {
            return this.UserDb[inputIndex];
        }
        public bool User_Add(int inputFileNumber, string inputUsername, string inputPassword, bool isAdmin)
        {
            bool rtn = false;
            if (this.UserDb.Count <= 100)
            {
                if (isAdmin)
                {
                    Supervisor auxUser = new Supervisor(inputFileNumber, inputUsername, inputPassword);
                    this.UserDb.Add(auxUser);
                    rtn = true;
                }
                else
                {
                    Operator auxUser = new Operator(inputFileNumber, inputUsername, inputPassword);
                    this.UserDb.Add(auxUser);
                    rtn = true;
                }
            }
            return rtn;
        }
        public List<string> User_GetActiveUsernameList()
        {
            List<string> usernamesList = new List<string>();
            if (this.UserDb != null && this.UserDb.Count > 0)
            {
                foreach (User item in this.UserDb)
                {
                    if (item is Operator && item.Active == true && item.Username != "Operario")
                    {
                        usernamesList.Add(item.Username);
                    }
                }
                usernamesList.Sort();
            }
            return usernamesList;
        }

        // Write & Read Db
        public bool User_ReadDbFromText(string inputFile)
        {
            bool rtn = false;
            if (!string.IsNullOrEmpty(inputFile))
            {
                string[] line = inputFile.Split(Environment.NewLine);
                foreach (string item in line)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        this.UserDb.Add(User.ReadFromText(item));
                        rtn = true;
                    }
                }
            }
            return rtn;
        }
        public bool User_WriteDbAsText(out string text)
        {
            bool rtn = false;
            StringBuilder sb = new StringBuilder();
            if (this.UserDb != null && this.UserDb.Count > 0)
            {
                sb.AppendLine("active,fileNumber,username,password,admin,name,surname,age,entryDate,divison,shift,category");
                foreach (User item in this.UserDb)
                {
                    if (item.Username != "Operario" && item.Username != "Supervisor")
                    {
                        if (item is Operator auxOperator)
                        {
                            sb.AppendLine(auxOperator.WriteAsText());
                            rtn = true;
                        }
                        else
                        {
                            sb.AppendLine(item.WriteAsText());
                            rtn = true;
                        }
                    }
                }
            }
            text = sb.ToString();
            return rtn;
        }
        public bool User_LoadDbFromText()
        {
            bool rtn = false;
            //string route = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test", "OperatorDb.txt");
            string route = Path.GetFullPath(".\\..\\..\\..\\..\\FILES\\UserDb.txt");
            if (File.Exists(route))
            {
                StringBuilder sb = new StringBuilder();
                string[] readFile = File.ReadAllLines(route);
                for (int i = 0; i < readFile.Length; i++)
                {
                    if (i != 0)
                    {
                        sb.AppendLine(readFile[i]);
                    }
                }
                rtn = User_ReadDbFromText(sb.ToString());
            }
            else
            {
                throw new Exception("Error al cargar la base de datos.");
            }
            return rtn;
        }
        public bool User_SaveDbAsText()
        {
            bool rtn = false;
            /*
            string route = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test");
            if (!Directory.Exists(route))
            {
                Directory.CreateDirectory(route);
            }
            route = Path.Combine(route, "OperatorDb.txt");
            */
            string route = Path.GetFullPath(".\\..\\..\\..\\..\\FILES\\UserDb.txt");
            if (File.Exists(route))
            {
                File.Delete(route);
            }
            if (User_WriteDbAsText(out string text))
            {
                File.WriteAllText(route, text);
                rtn = true;
            }
            return rtn;
        }
        #endregion

        #region MAINT ORDER DB METHODS

        // Generic Method
        public static bool MaintOrder_ValidateEntries(string inputDescription)
        {
            // MaintOrder_Parse es static pues no necesita de una instancia de clase Database para ejecutar su logica
            bool rtn = false;
            if (MaintenanceOrder.ValidateEntries(inputDescription)
          /* && MaintenanceOrder.SetDateTIme --> Por ejemplo */)
            {
                rtn = true;
            }
            return rtn;
        }
        #endregion

    }
}
