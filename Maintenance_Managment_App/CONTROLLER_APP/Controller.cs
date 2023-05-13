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

        #region READONLY PROPERTIES
        public static List<MaintenanceOrder> MaintOrderDb
        {
            get { return appDb.MaintOrderDb; }
        }
        public static List<MaintenanceOrder> ActiveMaintOrders
        {
            get { return appDb.ActiveMaintOrders; }
        }
        public static List<User> UserDb
        {
            get { return appDb.UserDb; }
        }
        #endregion

        #region CONSTRUCTOR
        static Controller()
        {
            appDb = new Database();
        }
        #endregion

        #region USER METHODS
        public static int User_Check(string inputUsername, string inputPassword)
        {
            return appDb.User_Check(inputUsername, inputPassword);
        }
        // TODO: Se puede agregar una sobrecarga de ReturnUser que reciba un int legajo operario (Se puede hacer tambien con nombre y apellido)
        public static User User_Return(string inputUsername)
        {
            return appDb.User_Return(inputUsername);
        }
        #endregion

        #region MO METHODS
        public static bool MaintOrder_HardcodeDb()
        {
            return appDb.MaintOrder_HardcodeDb();
        }
        public static bool MaintOrder_LoadActiveOrders()
        {
            return appDb.MaintOrder_LoadActiveOrders();
        }

        public static bool MaintOrder_Parse(string inputDescription)
        {
            return Database.MaintOrder_Parse(inputDescription);
        }
        public static bool MaintOrder_Add(User activeUser, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, out int idAdded)
        {
            return appDb.MaintOrder_Add(activeUser, inputMachine, inputSection, inputUrgency, inputDescription, out idAdded);
        }
        public static bool MaintOrder_Edit(int id, Machine inputMachine, Section inputSection, Urgency inputUrgency, string inputDescription, bool inputStatus)
        {
            return appDb.MaintOrder_Edit(id, inputMachine, inputSection, inputUrgency, inputDescription, inputStatus);
        }
        public static bool MaintOrder_Remove(int id)
        {
            return appDb.MaintOrder_Remove(id);
        }
        public static bool MaintOrder_PrintStatus(int inputId)
        {
            return appDb.MaintOrder_PrintStatus(inputId);
        }
        public static string MaintOrder_PrintId(int inputId)
        {
            return appDb.MaintOrder_PrintId(inputId);
        }
        public static string MaintOrder_PrintUsername(int inputId)
        {
            return appDb.MaintOrder_PrintUsername(inputId);
        }
        public static string MaintOrder_PrintSection(int inputId)
        {
            return appDb.MaintOrder_PrintSection(inputId);
        }
        public static string MaintOrder_PrintMachine(int inputId)
        {
            return appDb.MaintOrder_PrintMachine(inputId);
        }
        public static string MaintOrder_PrintUrgency(int inputId)
        {
            return appDb.MaintOrder_PrintUrgency(inputId);
        }
        public static string MaintOrder_PrintAntiquity(int inputId)
        {
            return appDb.MaintOrder_PrintAntiquity(inputId);
        }
        public static string MaintOrder_PrintDescription(int inputId)
        {
            return appDb.MaintOrder_PrintDescription(inputId);
        }
        #endregion
    }
}