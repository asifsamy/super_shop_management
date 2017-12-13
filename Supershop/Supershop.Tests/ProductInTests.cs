using Supershop;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Supershop.Tests
{
    [TestClass]
    public class ProductInTests
    {
        [TestMethod]
        public void validateInsertedPdDataTest1()
        {
            var pdInController = new ProductInsertController();
            var name = "Potato";
            var price = "10.00";
            var available = "50";

            var isValid = pdInController.validateInsertedPd(name, price, available);
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void validateInsertedPdDataTest2()
        {
            var pdInController = new ProductInsertController();
            var name = "";
            var price = "";
            var available = "";

            var isValid = pdInController.validateInsertedPd(name, price, available);
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void validateInsertedPdDataTest3()
        {
            var pdInController = new ProductInsertController();
            var name = "Chocolate";
            var price = "as";
            var available = "a";

            var isValid = pdInController.validateInsertedPd(name, price, available);
            Assert.AreEqual(false, isValid);
        }

    }
}
