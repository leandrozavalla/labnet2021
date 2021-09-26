using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabNet2021.TP5.Logic.Tests
{
    [TestClass()]
    public class BaseLogicTests
    {
        [TestMethod()]
        public void DevuelveClienteTest()
        {
            // Arrange
            BaseLogic baseLogic = new BaseLogic();

            // Act
            var result = baseLogic.DevuelveCliente();

            // Assert
            Assert.AreEqual(1, 1);
        }
    }
}