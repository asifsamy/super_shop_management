using Supershop;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Supershop.Tests
{
    [TestClass]
    public class ProductSaleTests
    {
        [TestMethod]
        public void validatePdSaleDataTest1()
        {
            var pdSaleController = new ProductSaleController();
            var available = 3;

            var isValid = pdSaleController.checkAvailability(available);
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void validatePdSaleDataTest2()
        {
            var pdSaleController = new ProductSaleController();
            var available = 0;

            var isValid = pdSaleController.checkAvailability(available);
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void validatePdSaleDataTest3()
        {
            var pdSaleController = new ProductSaleController();
            var available = -2;

            var isValid = pdSaleController.checkAvailability(available);
            Assert.AreEqual(false, isValid);
        }
    }
}
