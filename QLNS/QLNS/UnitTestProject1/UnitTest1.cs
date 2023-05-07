using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace LoginTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
                var loginService = new LoginService();
                var username = "Admin";
                var password = "1234";

            // Act
            var result = loginService.Login(username, password);

            // Assert
            Assert.IsTrue(result);

        }
    }
    public class LoginService
    {
        public bool Login(string username, string password)
        {
            
            if (username == "Admin" && password == "1234")
            {
                return true;
            }

            return false;
        }
    }
}
