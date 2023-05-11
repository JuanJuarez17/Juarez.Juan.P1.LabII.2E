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

        #region CONSTRUCTOR
        public Database()
        {
            this.usersDb = new List<User>();
            this.maintOrdersDb = new List<MaintenanceOrder>();
            LoadUsers();
            LoadMaintOrders();
        }
        #endregion

        #region READONLY PROPERTIES
        public List<User> UserDb { get { return this.usersDb; } }
        public List<MaintenanceOrder> MaintOrderDb { get { return this.maintOrdersDb; } }
        #endregion

        #region HARDCODE METHODS
        private void LoadUsers()
        {
            this.usersDb.Add(new Operator("JPerez", "qwe123"));
            this.usersDb.Add(new Operator("ETolosa", "asd456"));
            this.usersDb.Add(new Operator("PRodriguez", "zxc789"));
            this.usersDb.Add(new Supervisor("JJuarez", "rty000"));
            this.usersDb.Add(new Supervisor("Admin", "asd123"));
        }
        private void LoadMaintOrders()
        {
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("PRodriguez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Normal, new DateTime(2022, 09, 13)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("ETolosa"), Machine.Torno, Section.Matriceria, Urgency.Urgente, new DateTime(2022, 11, 27)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("PRodriguez"), Machine.Fresadora, Section.Matriceria, Urgency.Normal, new DateTime(2022, 12, 03)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("ETolosa"), Machine.Autoelevador02, Section.Almacen, Urgency.Programable, new DateTime(2022, 09, 23)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("JPerez"), Machine.Brochadora, Section.Mecanizado, Urgency.Programable, new DateTime(2022, 10, 30)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("JJuarez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Urgente, new DateTime(2023, 01, 13)));
            this.maintOrdersDb.Add(new MaintenanceOrder(ReturnUser("JJuarez"), Machine.GrabadoraLaser, Section.Ensamble, Urgency.Programable, new DateTime(2023, 02, 24)));
        }
        #endregion

        #region USER DB METHODS
        public User ReturnUser(string inputUsername)
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
        public int CheckUser(string inputUsername, string inputPassword)
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
        public static bool ParseMaintOrder(string inputDescription)
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
        public bool AddMaintOrder(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
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
        public bool FindById(int inputId, out int findedIndex)
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
        public bool RemoveMaintOrder(int inputId)
        {
            bool rtn = false;
            if (FindById(inputId, out int findedIndex))
            {
                this.maintOrdersDb.Remove(this.maintOrdersDb[findedIndex]);
                return true;
            }
            return rtn;
        }
        public string PrintMaintOrder(int inputId)
        {
            if (FindById(inputId, out int findedIndex))
            {
                return this.maintOrdersDb[findedIndex].MaintenanceOrder_print();
            }
            return string.Empty;
        }
        public string PrintMaintOrderId(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Id.ToString();
        }
        public string PrintMaintOrderUsername(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Username.ToString();
        }
        public string PrintMaintOrderSection(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Section.ToString();
        }
        public string PrintMaintOrderMachine(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Machine.ToString();
        }
        public string PrintMaintOrderUrgency(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Urgency.ToString();
        }
        public string PrintMaintOrderAntiquity(int inputId)
        {
            FindById(inputId, out int findedIndex);
            return this.maintOrdersDb[findedIndex].Antiquity.ToString();
        }
        public string PrintMaintOrderDescription(int inputId)
        {
            FindById(inputId, out int findedIndex);
            string rtn = this.maintOrdersDb[findedIndex].Description.ToString();
            if (rtn == null)
            {
                rtn = "No se agrego descripcion.";
            }
            return rtn;
        }
        #endregion
    }
}
