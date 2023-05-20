﻿using ENTITIES_APP;
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
        public static int User_Check(string inputUsername, string inputPassword)
        {
            return appDb.User_Check(inputUsername, inputPassword);
        }
        // TODO: Se puede agregar una sobrecarga de ReturnUser que reciba un int legajo operario (Se puede hacer tambien con nombre y apellido)
        public static User User_Return(string inputUsername)
        {
            return appDb.User_Return(inputUsername);
        }
        public static User User_Return(int inputFileNumber)
        {
            return appDb.User_Return(inputFileNumber);
        }
        public static bool User_FindInDb(int inputFileNumber, out int findedIndex)
        {
            return appDb.User_FindInDb(inputFileNumber, out findedIndex);
        }
        #endregion

        #region MAINT ORDER METHODS
        public static int MaintOrder_ReturnFinished()
        {
            return appDb.FinishedOrders;
        }
        public static int MaintOrder_ReturnUnfinished()
        {
            return appDb.UnfinishedOrders;
        }
        public static bool MaintOrder_HardcodeDb()
        {
            return appDb.MaintOrder_HardcodeDb();
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
        public static bool MaintOrder_GetStatus(int inputId)
        {
            return appDb.MaintOrder_GetStatus(inputId);
        }
        public static string MaintOrder_PrintParameter(string inputParameter, int inputId)
        {
            return appDb.MaintOrder_PrintParameter(inputParameter, inputId);
        }
        public static void MaintOrder_Sort(string parameter, int inputOrder)
        {
            appDb.MaintOrder_Sort(parameter, inputOrder);
        }
        #endregion
    }
}