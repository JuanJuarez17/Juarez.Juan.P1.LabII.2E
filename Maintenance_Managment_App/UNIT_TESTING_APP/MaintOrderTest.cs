using ENTITIES_APP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIT_TESTING_APP
{
    [TestClass]
    public class MaintOrderTest
    {
        [TestMethod]
        public void ListExtension_CuandoParametroBuscadoTieneDosOcurrencias_DeberiaRetornarDos()
        {
            // Arrange
            int expected = 2;
            List<MaintenanceOrder> list = new List<MaintenanceOrder>()
            {
                new MaintenanceOrder("JJuarez", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("ETolosa", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("PRodriguez", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("JJuarez", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
            };
            // Act
            List<MaintenanceOrder> listFiltered = list.Filtrar(MaintenanceOrder.CompareUsername, "JJuarez");
            int actual = listFiltered.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ListExtension_CuandoParametroBuscadoTieneCeroOcurrencias_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            List<MaintenanceOrder> list = new List<MaintenanceOrder>()
            {
                new MaintenanceOrder("ETolosa", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("ETolosa", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("PRodriguez", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
                new MaintenanceOrder("JPerez", Section.Almacen, Machine.Agujereadora, Urgency.Normal, null),
            };
            // Act
            List<MaintenanceOrder> listFiltered = list.Filtrar(MaintenanceOrder.CompareUsername, "JJuarez");
            int actual = listFiltered.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ListExtension_CuandoListaVacia_DeberiaRetornarCero()
        {
            // Arrange
            int expected = 0;
            List<MaintenanceOrder> list = new List<MaintenanceOrder>();
            // Act
            List<MaintenanceOrder> listFiltered = list.Filtrar(MaintenanceOrder.CompareUsername, "JJuarez");
            int actual = listFiltered.Count;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
