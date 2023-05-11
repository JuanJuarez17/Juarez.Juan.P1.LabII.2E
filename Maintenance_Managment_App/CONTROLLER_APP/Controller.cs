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
        public static bool ParseMaintOrder(string inputDescription)
        {
            return Database.ParseMaintOrder(inputDescription);
        }
        public static bool AddMaintOrder(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
        {
            return appDb.AddMaintOrder(activeUser, inputMachine, inputSection, inputUrgency, inputDescription, out idAdded);
        }
        public static bool RemoveMaintOrder(int id)
        {
            return appDb.RemoveMaintOrder(id);
        }
        public static string PrintMaintOrder(int inputId)
        {
            return appDb.PrintMaintOrder(inputId);
        }
        public static string PrintMaintOrderId(int inputId)
        {
            return appDb.PrintMaintOrderId(inputId);
        }
        public static string PrintMaintOrderUsername(int inputId)
        {
            return appDb.PrintMaintOrderUsername(inputId);
        }
        public static string PrintMaintOrderSection(int inputId)
        {
            return appDb.PrintMaintOrderSection(inputId);
        }
        public static string PrintMaintOrderMachine(int inputId)
        {
            return appDb.PrintMaintOrderMachine(inputId);
        }
        public static string PrintMaintOrderUrgency(int inputId)
        {
            return appDb.PrintMaintOrderUrgency(inputId);
        }
        public static string PrintMaintOrderAnquity(int inputId)
        {
            return appDb.PrintMaintOrderAntiquity(inputId);
        }
        public static string PrintMaintOrderDescription(int inputId)
        {
            return appDb.PrintMaintOrderDescription(inputId);
        }
        #endregion
    }
}