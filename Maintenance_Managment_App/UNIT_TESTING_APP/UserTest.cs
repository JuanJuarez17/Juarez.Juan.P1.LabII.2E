using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENTITIES_APP;

namespace UNIT_TESTING_APP
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ValidateEntries_CuandoIngresoNombreConNumeros_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "Juan27";
            string inputSurname = "Juarez1";
            string inputAge = "28";
            string inputDate = "22/10/2021";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoNombreConUnCaracter_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "a";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/2021";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoNombreConVeinteCaracteres_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "JuanGabrielJuarez";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/2021";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoNombreVacio_DeberiaRetornarTrue()
        {
            // Arrange
            string inputName = "";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/2021";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ValidateEntries_CuandoIngresoEdadConLetras_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "Juan";
            string inputSurname = "Juarez";
            string inputAge = "2Ocho";
            string inputDate = "22/10/2021";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoFechaSinFormato_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "Juan";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "lunes 2 de abril";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoFechaMenor1950_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "Juan";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/1948";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoFechaMayorActual_DeberiaRetornarFalse()
        {
            // Arrange
            string inputName = "Juan";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/2025";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void ValidateEntries_CuandoIngresoCamposCorrectos_DeberiaRetornarTrue()
        {
            // Arrange
            string inputName = "Juan";
            string inputSurname = "Juarez";
            string inputAge = "28";
            string inputDate = "22/10/2019";
            // Act
            bool actual = User.ValidateEntries(inputName, inputSurname, inputAge, inputDate);
            // Assert
            Assert.IsTrue(actual);
        }
    }
}
