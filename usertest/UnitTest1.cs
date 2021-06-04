using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using User;

namespace usertest
{
    [TestClass]
    public class UnitTest1
    {
        User.User obj = new User.User();
        [TestMethod]
        public void TestMethod1()
        {
            bool actual = obj.login("Admin", "admin123");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
