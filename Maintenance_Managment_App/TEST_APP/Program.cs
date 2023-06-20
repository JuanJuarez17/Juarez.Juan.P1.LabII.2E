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
            try
            {
                List<MaintenanceOrder> list = new List<MaintenanceOrder>();
                DbMaintOrder db = new DbMaintOrder();
                list = db.Import();
                foreach (MaintenanceOrder item in list)
                {
                    Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
                }

                //MaintenanceOrder auxMaintOrder = db.Read(124);
                //Console.WriteLine($"ID: {auxMaintOrder.Id} ACTIVE : {auxMaintOrder.Active} GENERO {auxMaintOrder.Username}");

                //db.Delete(143);
                //MaintenanceOrder auxMaintOrder2 = db.Read(151);
                //Console.WriteLine($"ID: {auxMaintOrder2.Id} ACTIVE : {auxMaintOrder2.Active} GENERO {auxMaintOrder2.Username}");
                //Console.WriteLine("Cantidad de filas: " + db.Count());
                //Console.WriteLine("Ultimo ID: " + db.GetLast("ID"));

                //Console.WriteLine("DESCRIPCION MO 139: " + db.PrintParameter(139, "ID"));

                //Console.WriteLine("LISTA ORDENADA");
                //List<MaintenanceOrder> listSort = db.Sort("MAKER", "ASC");
                //foreach (MaintenanceOrder item in listSort)
                //{
                //    Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
                //}



                // PRUEBA CREATE
                MaintenanceOrder maintOrd2 = new MaintenanceOrder("ETolosa", Section.Otro, Machine.Autoelevador, Urgency.Programable, "testing");
                db.Create(maintOrd2);
                List<MaintenanceOrder> listAdd = db.Import();
                foreach (MaintenanceOrder item in listAdd)
                {
                    Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
                }

                Console.WriteLine($" TEST ID: {(db.Read(126)).Id} ACTIVE : {(db.Read(126)).Active}  GENERO {(db.Read(126)).Username}");



                // PRUEBA UPDATE
                //MaintenanceOrder maintOrd2 = new MaintenanceOrder("ETolosa", Section.Mecanizado, Machine.Autoelevador, Urgency.Urgente, null);
                //db.Update(160, maintOrd2);
                //List<MaintenanceOrder> listUpd = db.ImportDb();
                //foreach (MaintenanceOrder item in listUpd)
                //{
                //    Console.WriteLine($"ID: {item.Id} ACTIVE : {item.Active}  GENERO {item.Username}");
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
