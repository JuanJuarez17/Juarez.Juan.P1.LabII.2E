using ENTITIES_APP;
using DATABASE_APP;
using System;
using System.Collections.Generic;
using System.Text;

namespace CONTROLLER_APP
{
    public static class Controller
    {
        #region ATTRIBUTES
        private static Database appDb;
        #endregion

        #region CONSTRUCTOR
        static Controller()
        {
            appDb = new Database();
        }
        #endregion

        #region READONLY PROPERTIES
        public static List<MaintenanceOrder> MaintOrderDb
        {
            get { return appDb.MaintOrderDb; }
        }
        public static List<User> UserDb
        {
            get { return appDb.UserDb; }
        } 
        #endregion

        #region USER METHODS
        public static int CheckUser(string inputUsername, string inputPassword)
        {
            return appDb.CheckUser(inputUsername, inputPassword);
        }

        // TODO: Se puede agregar una sobrecarga de ReturnUser que reciba un int legajo operario (Se puede hacer tambien con nombre y apellido)
        public static User ReturnUser(string inputUsername)
        {
            return appDb.ReturnUser(inputUsername);
        }
        #endregion

        #region MO METHODS
        public static bool ParseMaintenanceOrder(string inputDescription)
        {
            return Database.ParseMaintenanceOrder(inputDescription);
        }
        public static MaintenanceOrder CreateMaintenanceOrder(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription)
        {
            return Database.CreateMaintenanceOrder(activeUser, inputMachine, inputSection, inputUrgency, inputDescription);
        }
        public static bool AddMaintenanceOrder(MaintenanceOrder inputMaintenanceOrder, out int idAdded)
        {
            bool rtn = appDb.AddMaintenanceOrder(inputMaintenanceOrder, out idAdded);
            return rtn;
        }
        public static bool ListMaintenanceOrderDB(out string message)
        {
            bool rtn = appDb.ListMaintenanceOrderDB(out message);
            return rtn;

        }
        #endregion
    }
}
