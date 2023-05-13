using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATABASE_APP
{
    public class Database
    {
        #region ATTRIBUTES
        private List<MaintenanceOrder> maintOrdersDb;
        private List<MaintenanceOrder> activeMaintOrders;
        private List<User> usersDb;
        #endregion

        #region READONLY PROPERTIES
        public List<User> UserDb { get { return this.usersDb; } }
        public List<MaintenanceOrder> MaintOrderDb { get { return this.maintOrdersDb; } }
        public List<MaintenanceOrder> ActiveMaintOrders { get { return this.activeMaintOrders; } }
        #endregion

        #region CONSTRUCTOR
        public Database()
        {
            this.usersDb = new List<User>();
            this.maintOrdersDb = new List<MaintenanceOrder>();
            this.activeMaintOrders = new List<MaintenanceOrder>();
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
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Section.Otro, Machine.Agujereadora, Urgency.Normal, null, true, new DateTime(2022, 09, 13), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Mecanizado, Machine.Autoelevador, Urgency.Programable, null, false, new DateTime(2023, 03, 22), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Ensamble, Machine.Otro, Urgency.Urgente, null, true, new DateTime(2022, 10, 09), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Otro, Machine.GrabadoraLaser, Urgency.Normal, null, true, new DateTime(2023, 01, 18), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Section.Ensamble, Machine.CentroCNC, Urgency.Programable, null, false, new DateTime(2022, 11, 30), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Matriceria, Machine.CentroCNC, Urgency.Normal, null, true, new DateTime(2022, 10, 29), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Section.Almacen, Machine.Brochadora, Urgency.Urgente, null, false, new DateTime(2022, 09, 03), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Section.Mecanizado, Machine.Otro, Urgency.Programable, null, true, new DateTime(2022, 09, 15), false));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Section.Almacen, Machine.CentroCNC, Urgency.Normal, null, true, new DateTime(2023, 02, 20), true));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Section.Ensamble, Machine.Otro, Urgency.Urgente, null, true, new DateTime(2023, 04, 10), false));
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
        public bool MaintOrder_LoadActiveOrders()
        {
            bool rtn = false;
            if (this.maintOrdersDb.Count > 0)
            {
                this.activeMaintOrders.Clear();
                foreach (MaintenanceOrder item in this.maintOrdersDb)
                {
                    if (item.Active)
                    {
                        this.activeMaintOrders.Add(item);
                        rtn = true;
                    }
                }
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
        public bool MaintOrder_PrintStatus(int inputId) 
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Completed;
        }
        public string MaintOrder_PrintId(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Id.ToString();
        }
        public string MaintOrder_PrintUsername(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Username.ToString();
        }
        public string MaintOrder_PrintSection(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Section.ToString();
        }
        public string MaintOrder_PrintMachine(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Machine.ToString();
        }
        public string MaintOrder_PrintUrgency(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Urgency.ToString();
        }
        public string MaintOrder_PrintAntiquity(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Antiquity.ToString();
        }
        public string MaintOrder_PrintDescription(int inputId)
        {
            MaintOrder_FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Description.ToString();
        }
        #endregion
    }
}
