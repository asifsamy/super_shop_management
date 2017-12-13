using Supershop;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Supershop.Tests
{
    [TestClass]
    public class UserInsertTests
    {
        [TestMethod]
        public void validateInUserDataTest1()
        {
            var userInController = new UserInsertController();
            var name = "samy123";
            var type = "admin";
            var password = "1233jkdf";

            var isValid = userInController.validateInsertedUser(name, type, password);
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void validateInUserDataTest2()
        {
            var userInController = new UserInsertController();
            var name = "";
            var type = "";
            var password = "";

            var isValid = userInController.validateInsertedUser(name, type, password);
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void validateInUserDataTest3()
        {
            var userInController = new UserInsertController();
            var name = "anything";
            var type = "123";
            var password = "a843hhkjd";

            var isValid = userInController.validateInsertedUser(name, type, password);
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void validateInUserDataTest4()
        {
            var userInController = new UserInsertController();
            var name = "anything";
            var type = "admin123";
            var password = "a84";

            var isValid = userInController.validateInsertedUser(name, type, password);
            Assert.AreEqual(false, isValid);
        }
    }
}
