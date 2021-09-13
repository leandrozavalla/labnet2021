using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2021.TP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.TP2.Tests
{
    [TestClass()]
    public class ClaseParaUTTests
    {
        [TestMethod()]
        public void MultiplicacionTest()
        {
            // Arrange
            int numero = 100;
            int resultadoEsperado = 500;

            // Act
            numero = numero.Multiplicacion(5);

            // Assert
            Assert.AreEqual(resultadoEsperado, numero);
        }
    }
}