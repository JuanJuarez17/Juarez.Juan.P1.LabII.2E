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
        private List<User> usersDb;
        #endregion

        #region READONLY PROPERTIES
        public List<User> UserDb { get { return this.usersDb; } }
        public List<MaintenanceOrder> MaintOrderDb { get { return this.maintOrdersDb; } }
        #endregion

        #region CONSTRUCTOR
        public Database()
        {
            this.usersDb = new List<User>();
            this.maintOrdersDb = new List<MaintenanceOrder>();
            LoadUsers();
        }
        #endregion

        #region HARDCODE METHODS
        // Es private ya que por defecto se cargara la db de user, no se podra taer de otro lado
        private void LoadUsers()
        {
            this.usersDb.Add(new Operator("JPerez", "qwe123"));
            this.usersDb.Add(new Operator("ETolosa", "asd456"));
            this.usersDb.Add(new Operator("PRodriguez", "zxc789"));
            this.usersDb.Add(new Operator("Operario", "oper123"));
            this.usersDb.Add(new Supervisor("JJuarez", "rty000"));
            this.usersDb.Add(new Supervisor("Supervisor", "super456"));
        }
        // Es public pues voy a dar la opcion de hardcodear la db, en un futuro habra otro metodo que reciba una db
        public bool LoadMaintOrders()
        {
            bool rtn = false;
            if (this.maintOrdersDb.Count <= 100)
            {
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Normal, null, new DateTime(2022, 09, 13)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Machine.Torno, Section.Matriceria, Urgency.Urgente, null, new DateTime(2022, 11, 27)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("PRodriguez"), Machine.Fresadora, Section.Matriceria, Urgency.Normal, null, new DateTime(2022, 12, 03)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("ETolosa"), Machine.Autoelevador02, Section.Almacen, Urgency.Programable, null, new DateTime(2022, 09, 23)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JPerez"), Machine.Brochadora, Section.Mecanizado, Urgency.Programable, null, new DateTime(2022, 10, 30)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Urgente, null, new DateTime(2023, 01, 13)));
                this.maintOrdersDb.Add(new MaintenanceOrder(User_Return("JJuarez"), Machine.GrabadoraLaser, Section.Ensamble, Urgency.Programable, null, new DateTime(2023, 02, 24)));
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
        // ParseMaintOrder es static pues no necesita de una instancia de clase Database para ejecutar su logica
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
        // AddMaintOrder no es static pues necesita de una instancia de clase Database para ejecutar su logica
        public bool MaintOrder_Add(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
        {
            bool rtn = false;
            idAdded = 0;
            if (this.maintOrdersDb.Count <= 100)
            {
                MaintenanceOrder auxMaintOrder = new MaintenanceOrder(activeUser, inputMachine, inputSection, inputUrgency, inputDescription);
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
                return true;
            }
            return rtn;
        }
        public bool MaintOrder_Remove(int inputId)
        {
            bool rtn = false;
            if (MaintOrder_FindById(inputId, out int findedIndex))
            {
                this.maintOrdersDb.Remove(this.maintOrdersDb[findedIndex]);
                return true;
            }
            return rtn;
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
