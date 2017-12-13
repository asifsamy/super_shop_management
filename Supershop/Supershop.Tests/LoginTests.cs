using Supershop;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Supershop.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void validateLoginDataTest1()
        {
            var loginController = new LoginController();
            var username = "samy";
            var password = "1234";
            var type     = "emp";

            var isValid = loginController.validateLoginData(username, password, type);
            Assert.AreEqual(true, isValid);

            var isMatched = loginController.loginIntoSystem(username, password, type);
            Assert.AreEqual(1, isMatched);
        }

        [TestMethod]
        public void validateLoginDataTest2()
        {
            var loginController = new LoginController();
            var username = "samy";
            var password = "1234sdfsd";
            var type = "emp";

            var isValid = loginController.validateLoginData(username, password, type);
            Assert.AreEqual(true, isValid);

            var isMatched = loginController.loginIntoSystem(username, password, type);
            Assert.AreEqual(0, isMatched);
        }

        [TestMethod]
        public void validateLoginDataTest3()
        {
            var loginController = new LoginController();
            var username = "";
            var password = "";
            var type = "";

            var isValid = loginController.validateLoginData(username, password, type);

            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void validateLoginDataTest4()
        {
            var loginController = new LoginController();
            var username = "samy";
            var password = "1234";
            var type = "123";

            var isValid = loginController.validateLoginData(username, password, type);

            Assert.AreEqual(false, isValid);
        }
    }
}
