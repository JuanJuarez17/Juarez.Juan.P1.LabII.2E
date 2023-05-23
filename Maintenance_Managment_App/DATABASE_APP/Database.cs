﻿using ENTITIES_APP;
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

        #region HARDCODE METHODS
        public bool MaintOrder_HardcodeDb()
        {
            bool rtn = false;
            if (this.maintOrdersDb.Count <= 100)
            {
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Section.Otro, Machine.Agujereadora, Urgency.Normal, null, true, new DateTime(2022, 08, 13), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Mecanizado, Machine.Autoelevador, Urgency.Programable, null, false, new DateTime(2022, 08, 22), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Ensamble, Machine.Otro, Urgency.Urgente, null, true, new DateTime(2022, 09, 09), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Otro, Machine.GrabadoraLaser, Urgency.Normal, null, true, new DateTime(2022, 10, 18), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Ensamble, Machine.CentroCNC, Urgency.Programable, null, false, new DateTime(2022, 10, 30), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Matriceria, Machine.CentroCNC, Urgency.Normal, null, true, new DateTime(2022, 11, 09), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Section.Almacen, Machine.Brochadora, Urgency.Urgente, null, false, new DateTime(2022, 11, 20), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Mecanizado, Machine.Otro, Urgency.Programable, null, true, new DateTime(2022, 11, 25), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Section.Almacen, Machine.CentroCNC, Urgency.Normal, null, true, new DateTime(2023, 01, 13), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Section.Ensamble, Machine.Otro, Urgency.Urgente, null, true, new DateTime(2023, 01, 17), false));
                this.maintOrderDbLoaded = true;
                rtn = true;
            }
            return rtn;
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
            string route = Path.Combine(Path.GetFullPath("."), "OperatorDb.txt");
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
            string route = Path.Combine(Path.GetFullPath("."), "OperatorDb.txt");
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
        // MaintOrderDb Methods
        public bool MaintOrder_Add(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
        {
            // MaintOrder_Add no es static pues necesita de una instancia de clase Database para ejecutar su logica
            bool rtn = false;
            idAdded = 0;
            if (this.MaintOrderDb.Count <= 100)
            {
                MaintenanceOrder auxMaintOrder = new MaintenanceOrder(activeUser, inputSection, inputMachine, inputUrgency, inputDescription);
                this.MaintOrderDb.Add(auxMaintOrder);
                idAdded = auxMaintOrder.Id;
                rtn = true;
            }
            return rtn;
        }
        public bool MaintOrder_FindById(int inputId, out int findedIndex)
        {
            bool rtn = false;
            findedIndex = -1;
            if (this.MaintOrderDb != null && this.MaintOrderDb.Count > 0)
            {
                foreach (MaintenanceOrder item in this.MaintOrderDb)
                {
                    if (item.Id == inputId)
                    {
                        findedIndex = this.MaintOrderDb.IndexOf(item);
                        return true;
                    }
                }
            }
            return rtn;
        }
        public bool MaintOrder_Edit(int inputId, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, bool inputStatus)
        {
            bool rtn = false;
            if (MaintOrder_FindById(inputId, out int findedIndex))
            {
                this.MaintOrderDb[findedIndex].Section = inputSection;
                this.MaintOrderDb[findedIndex].Machine = inputMachine;
                this.MaintOrderDb[findedIndex].Urgency = inputUrgency;
                this.MaintOrderDb[findedIndex].Description = inputDescription;
                this.MaintOrderDb[findedIndex].Completed = inputStatus;
                if (this.MaintOrderDb[findedIndex].Completed)
                {
                    this.MaintOrderDb[findedIndex].EndDate = DateTime.Now.Date;
                }
                else
                {
                    this.MaintOrderDb[findedIndex].EndDate = new DateTime();
                }
                return true;
            }
            return rtn;
        }
        public bool MaintOrder_Remove(int inputId)
        {
            bool rtn = false;
            if (MaintOrder_FindById(inputId, out int findedIndex))
            {
                this.MaintOrderDb[findedIndex].Active = false;
                return true;
            }
            return rtn;
        }
        public void MaintOrder_Sort(string parameter, int inputOrder)
        {
            switch (parameter)
            {
                case "ID":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(IdDecreasing); }
                    else { this.MaintOrderDb.Sort(IdCreasing); }
                    break;
                case "DATE":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(CreationDateDecreasing); }
                    else { this.MaintOrderDb.Sort(CreationDateCreasing); }
                    break;
                case "SECTION":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(SectionDecreasing); }
                    else { this.MaintOrderDb.Sort(SectionCreasing); }
                    break;
                case "MACHINE":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(MachineDecreasing); }
                    else { this.MaintOrderDb.Sort(MachineCreasing); }
                    break;
                case "PRIORITY":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(PriorityDecreasing); }
                    else { this.MaintOrderDb.Sort(PriorityCreasing); }
                    break;
                default:
                    break;
            }
        }
        
        // Generic Method
        public static bool MaintOrder_Parse(string inputDescription)
        {
            // MaintOrder_Parse es static pues no necesita de una instancia de clase Database para ejecutar su logica
            bool rtn = false;
            if (MaintenanceOrder.SetDescription(inputDescription)
          /* && MaintenanceOrder.SetDateTIme --> Por ejemplo */)
            {
                rtn = true;
            }
            return rtn;
        }
        public bool MaintOrder_GetStatus(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.MaintOrderDb[findedIndex].Completed;
        }
        public string MaintOrder_PrintParameter(string inputParameter, int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            switch (inputParameter)
            {
                case "ID":
                    return this.maintOrdersDb[findedIndex].Id.ToString();
                case "USERNAME":
                    return this.maintOrdersDb[findedIndex].Username.ToString();
                case "SECTION":
                    return this.maintOrdersDb[findedIndex].Section.ToString();
                case "MACHINE":
                    return this.maintOrdersDb[findedIndex].Machine.ToString();
                case "URGENCY":
                    return this.maintOrdersDb[findedIndex].Urgency.ToString();
                case "ANTIQUITY":
                    return this.maintOrdersDb[findedIndex].Antiquity.ToString();
                case "DESCRIPTION":
                    return this.maintOrdersDb[findedIndex].Description.ToString();
                default:
                    return string.Empty;
            }
        }
        #endregion

        #region MAINT ORDER SORT METHODS
        public static int IdDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return input2.Id - input1.Id;
        }
        public static int IdCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -IdDecreasing(input1, input2);
        }
        public static int CreationDateDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return input2.Antiquity - input1.Antiquity;
        }
        public static int CreationDateCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -CreationDateDecreasing(input1, input2);
        }
        public static int SectionDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Section.ToString(), input1.Section.ToString());
        }
        public static int SectionCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -SectionDecreasing(input1, input2);
        }
        public static int MachineDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Machine.ToString(), input1.Machine.ToString());
        }
        public static int MachineCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -MachineDecreasing(input1, input2);
        }
        public static int PriorityDecreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return string.Compare(input2.Urgency.ToString(), input1.Urgency.ToString());
        }
        public static int PriorityCreasing(MaintenanceOrder input1, MaintenanceOrder input2)
        {
            return -PriorityDecreasing(input1, input2);
        }
        #endregion
    }
}
