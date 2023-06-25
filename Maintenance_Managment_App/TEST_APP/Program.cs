using DATABASE_APP;
using ENTITIES_APP;
using System;
using System.Collections.Generic;

namespace TEST_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<MaintenanceOrder> list = new List<MaintenanceOrder>();
            try
            {
                DbEntityMaintOrder db = new DbEntityMaintOrder();
                list = db.Import();
            }
            catch (Exception)
            {
                Console.WriteLine("Error en DB");
                Environment.Exit(1);
            }
            foreach (MaintenanceOrder item in list)
            {
                Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
            }

            list = list.Filtrar(MaintenanceOrder.CompareUsername, "JJuarez");




            foreach (MaintenanceOrder item in list)
            {
                Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
            }

        }
    }
}
