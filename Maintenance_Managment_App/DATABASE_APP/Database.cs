using ENTITIES_APP;
using System;
using System.Collections.Generic;
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
        public List<User> UserDb { get { return this.usersDb; } }
        public List<MaintenanceOrder> MaintOrderDb { get { return this.maintOrdersDb; } }
        public bool MaintOrderDbLoaded { get { return this.maintOrderDbLoaded; } }
        public List<MaintenanceOrder> ActiveMaintOrders 
        { 
            get 
            {
                List<MaintenanceOrder> activeMaintOrders = new List<MaintenanceOrder>();

                foreach (MaintenanceOrder item in this.maintOrdersDb)
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
        public int FinishedOrders
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
        public int UnfinishedOrders
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
            User_LoadDb();
        }
        #endregion

        #region HARDCODE METHODS
        // Es private ya que por defecto se cargara la db de user, no se podra taer de otro lado
        private void User_LoadDb()
        {
            this.usersDb.Add(new Operator("JPerez", "qwe123"));
            this.usersDb.Add(new Operator("ETolosa", "asd456"));
            this.usersDb.Add(new Operator("PRodriguez", "zxc789"));
            this.usersDb.Add(new Supervisor("JJuarez", "rty000"));
            this.usersDb.Add(new Operator("Operario", "oper123"));
            this.usersDb.Add(new Supervisor("Supervisor", "super456"));
        }
        // Es public pues voy a dar la opcion de hardcodear la db, en un futuro habra otro metodo que reciba una db
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
        public User User_Return(string inputUsername)
        {
            foreach (User item in usersDb)
            {
                if (item.CheckUsername(inputUsername))
                {
                    return item;
                }
            }
            // TODO: Revisar este retorno
            return null;
        }
        public int User_Check(string inputUsername, string inputPassword)
        {
            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                return -1;
            }
            else
            {
                foreach (User item in this.usersDb)
                {
                    if (item.CheckUsername(inputUsername))
                    {
                        if (item.CheckPassword(inputPassword))
                        {
                            return 1;
                        }
                    }
                }
                return 0;
            }
        }
        #endregion

        #region MAINT ORDER DB METHODS
        // MaintOrder_Parse es static pues no necesita de una instancia de clase Database para ejecutar su logica
        public static bool MaintOrder_Parse(string inputDescription)
        {
            bool rtn = false;
            if (MaintenanceOrder.SetDescription(inputDescription)
          /* && MaintenanceOrder.SetDateTIme --> Por ejemplo */)
            {
                rtn = true;
            }
            return rtn;
        }
        // MaintOrder_Add no es static pues necesita de una instancia de clase Database para ejecutar su logica
        public bool MaintOrder_Add(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
        {
            bool rtn = false;
            idAdded = 0;
            if (this.maintOrdersDb.Count <= 100)
            {
                MaintenanceOrder auxMaintOrder = new MaintenanceOrder(activeUser, inputSection, inputMachine, inputUrgency, inputDescription);
                this.maintOrdersDb.Add(auxMaintOrder);
                idAdded = auxMaintOrder.Id;
                rtn = true;
            }
            return rtn;
        }
        public bool MaintOrder_FindById(int inputId, out int findedIndex)
        {
            bool rtn = false;
            findedIndex = -1;
            if (this.maintOrdersDb != null && this.maintOrdersDb.Count > 0)
            {
                foreach (MaintenanceOrder item in this.maintOrdersDb)
                {
                    if (item.Id == inputId)
                    {
                        findedIndex = this.maintOrdersDb.IndexOf(item);
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
                this.maintOrdersDb[findedIndex].Section = inputSection;
                this.maintOrdersDb[findedIndex].Machine = inputMachine;
                this.maintOrdersDb[findedIndex].Urgency = inputUrgency;
                this.maintOrdersDb[findedIndex].Description = inputDescription;
                this.maintOrdersDb[findedIndex].Completed = inputStatus;
                if (this.maintOrdersDb[findedIndex].Completed)
                {
                    this.maintOrdersDb[findedIndex].EndDate = DateTime.Now.Date;
                }
                else
                {
                    this.maintOrdersDb[findedIndex].EndDate = new DateTime();
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
                this.maintOrdersDb[findedIndex].Active = false;
                return true;
            }
            return rtn;
        }
        public bool MaintOrder_GetStatus(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Completed;
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
        public void MaintOrder_Sort(string parameter, int inputOrder)
        {
            switch (parameter)
            {
                case "ID":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(IdDecreasing); }
                    else { this.maintOrdersDb.Sort(IdCreasing); }
                    break;
                case "DATE":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(CreationDateDecreasing); }
                    else { this.maintOrdersDb.Sort(CreationDateCreasing); }
                    break;
                case "SECTION":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(SectionDecreasing); }
                    else { this.maintOrdersDb.Sort(SectionCreasing); }
                    break;
                case "MACHINE":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(MachineDecreasing); }
                    else { this.maintOrdersDb.Sort(MachineCreasing); }
                    break;
                case "PRIORITY":
                    if (inputOrder == 0) { this.maintOrdersDb.Sort(PriorityDecreasing); }
                    else { this.maintOrdersDb.Sort(PriorityCreasing); }
                    break;
                default:
                    break;
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
