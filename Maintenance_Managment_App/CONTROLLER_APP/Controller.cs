using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Text;

namespace CONTROLLER_APP
{
    public static class Controller
    {
        private static List<User> usersDataBase;
        private static List<MaintenanceOrder> maintOrderDb;

        static Controller()
        {
            usersDataBase = new List<User>();
            maintOrderDb = new List<MaintenanceOrder>();
            LoadUsers();
            LoadMaintOrders();
        }

        private static void LoadUsers()
        {
            usersDataBase.Add(new Operator("JPerez", "qwe123"));
            usersDataBase.Add(new Operator("ETolosa", "asd456"));
            usersDataBase.Add(new Operator("PRodriguez", "zxc789"));
            usersDataBase.Add(new Supervisor("JJuarez", "rty000"));
            usersDataBase.Add(new Supervisor("Admin", "asd123"));
        }

        private static void LoadMaintOrders()
        {
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("PRodriguez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Normal, new DateTime(2022, 09, 13)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("ETolosa"), Machine.Torno, Section.Matriceria, Urgency.Normal, new DateTime(2022, 11, 27)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("PRodriguez"), Machine.Fresadora, Section.Matriceria, Urgency.Normal, new DateTime(2022, 12, 03)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("ETolosa"), Machine.Autoelevador02, Section.Almacen, Urgency.Normal, new DateTime(2022, 09, 23)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("JPerez"), Machine.Brochadora, Section.Mecanizado, Urgency.Normal, new DateTime(2022, 10, 30)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("JJuarez"), Machine.CentroCNC, Section.Mecanizado, Urgency.Normal, new DateTime(2023, 01, 13)));
            maintOrderDb.Add(new MaintenanceOrder(ReturnUser("JJuarez"), Machine.GrabadoraLaser, Section.Ensamble, Urgency.Normal, new DateTime(2023, 02, 24)));
        }

        public static int CheckUser(string inputUsername, string inputPassword)
        {
            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                return -1;
            }
            else
            {
                foreach (User item in usersDataBase)
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

        // TODO: Se puede agregar una sobrecarga de ReturnUser que reciba un int legajo operario (Se puede hacer tambien con nombre y apellido)
        public static User ReturnUser(string inputUsername)
        {
            foreach (User item in usersDataBase)
            {
                if (item.CheckUsername(inputUsername))
                {
                    return item;
                }
            }
            // TODO: Revisar este retorno
            return null;
        }

        public static string ShowMaintOrderList() // Otra posibilidad es declararla como propiedad
                                                  // Pero lo ideal seria que una propiedad reciba y devuelva el mismo tipo de variable
                                                  // Que el atributo al que hace referencia
                                                  // En este caso si se habla de la lista MO deberia ser public static List<MaintenanceOrder> ShowMain...
        {

            StringBuilder sb = new StringBuilder();
            foreach (MaintenanceOrder item in maintOrderDb)
            {
                sb.AppendLine(item.ShowMaintenanceOrder());
            }
            return sb.ToString();

        }

    }
}
