using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio.Controllers;
using System.Web.Mvc;

namespace Desafio.Tests.Controllers
{
    /// <summary>
    /// Summary description for CristalDaTerra
    /// </summary>
    [TestClass]
    public class CristalDaTerraTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CristalDaTerraController controller = new CristalDaTerraController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EvenRandomNumber()
        {
            // Arrange
            Random number = new Random();

            // Act
            Boolean result = (number.Next(0, 2) % 2 == 0);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
