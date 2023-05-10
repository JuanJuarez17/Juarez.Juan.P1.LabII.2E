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

        // CreateMaintOrder es static pues no necesita de una instancia de clase Database para ejecutar su logica
        public static MaintenanceOrder CreateMaintOrder(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription)
        {
            MaintenanceOrder auxMO = new MaintenanceOrder(activeUser, inputMachine, inputSection, inputUrgency, inputDescription);
            return auxMO;
        }

        // AddMaintOrder no es static pues necesita de una instancia de clase Database para ejecutar su logica
        public bool AddMaintOrder(MaintenanceOrder inputMaintenanceOrder, out int idAdded)
        {
            bool rtn = false;
            idAdded = 0;
            if (this.maintOrdersDb.Count <= 100)
            {
                this.maintOrdersDb.Add(inputMaintenanceOrder);
                idAdded = inputMaintenanceOrder.Id;
                rtn = true;
            }
            return rtn;
        }

        public bool ListMaintOrderDB(out string message)
        {
            bool rtn = false;
            StringBuilder sb = new StringBuilder();
            if (this.maintOrdersDb != null && this.maintOrdersDb.Count > 0) // Revisar si ambas condiciones son necesarias
            {
                foreach (MaintenanceOrder item in this.maintOrdersDb)
                {
                    if (item is not null) // Valido que un objeto de la lista no sea nulo
                    {
                        sb.AppendLine(item.MaintenanceOrder_print()); // Aqui no puedo ercibir objeto null sino hay excepcion

                    }
                    else
                    {
                        sb.AppendLine("ERROR! Null Exception.\n");
                    }
                }
                rtn = true;
            }
            message = sb.ToString();
            return rtn;
        }

        public MaintenanceOrder FindById(int inputId)
        {
            if (this.maintOrdersDb != null && this.maintOrdersDb.Count > 0)
            {
                foreach (MaintenanceOrder item in this.maintOrdersDb)
                {
                    if (item.Id == inputId)
                    {
                        return item;
                    }                    
                }
            }
            return null;
        }
        public bool RemoveMaintOrder(int inputId)
        {
            bool rtn = false;
            if (this.maintOrdersDb != null && this.maintOrdersDb.Count > 0)
            {
                foreach (MaintenanceOrder item in this.maintOrdersDb)
                {
                    if (item.Id == inputId)
                    {
                        this.maintOrdersDb.Remove(item);
                        return true;
                    }
                }
            }
            return rtn;
        }

        #endregion
    }
}
