using ENTITIES_APP;
using DATABASE_APP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

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
        public static List<MaintenanceOrder> CompletedMaintOrders
        {
            get { return appDb.CompletedMaintOrders; }
        }
        public static List<MaintenanceOrder> UncompletedMaintOrders
        {
            get { return appDb.UncompletedMaintOrders; }
        }
        public static List<User> UserDb
        {
            get { return appDb.UserDb; }
        }
        public static bool MaintOrderDbLoaded
        {
            get {  return appDb.MaintOrderDbLoaded; }
        }
        #endregion

        #region CONSTRUCTOR
        static Controller()
        {
            appDb = new Database();
        }
        #endregion

        #region USER METHODS
        public static int User_CheckExist(string inputUsername, string inputPassword)
        {
            return appDb.User_CheckExist(inputUsername, inputPassword);
        }
        // TODO: Se puede agregar una sobrecarga de ReturnUser que reciba un int legajo operario (Se puede hacer tambien con nombre y apellido)
        
        public static bool User_CheckFileNumberAvailable(int inputFileNumber)
        {
            return appDb.User_CheckFileNumberAvailable(inputFileNumber);
        }
        
        public static User User_Return(string inputUsername)
        {
            return appDb.User_Return(inputUsername);
        }
        public static User User_Return(int inputIndex)
        {
            return appDb.User_Return(inputIndex);
        }
        public static bool User_FindInDb(int inputFileNumber, out int findedIndex)
        {
            return appDb.User_FindInDb(inputFileNumber, out findedIndex);
        }
        public static bool User_FindInDb(string inputUsername, out int findedIndex)
        {
            return appDb.User_FindInDb(inputUsername, out findedIndex);
        }
        public static List<string> User_LoadUsernameList()
        {
            return appDb.User_GetActiveUsernameList();
        }
        public static bool User_Add(int inputFileNumber, string inputUsername, string inputPassword, bool isAdmin)
        {
            return appDb.User_Add(inputFileNumber, inputUsername, inputPassword, isAdmin);
        }
        public static bool User_LoadDbFromText()
        {
            return appDb.User_LoadDbFromText();
        }
        public static bool User_SaveDbAsText()
        {
            return appDb.User_SaveDbAsText();
        }
        #endregion

        #region MAINT ORDER METHODS
        public static bool MaintOrder_Parse(string inputDescription)
        {
            return Database.MaintOrder_ValidateEntries(inputDescription);
        }
        #endregion

    }
}