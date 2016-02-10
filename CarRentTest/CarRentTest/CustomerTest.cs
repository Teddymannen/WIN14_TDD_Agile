using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestInitialize]
        public void Setup()
        {
            var customer = new Customer();
        }
        [TestMethod]
        public void TestCustomerIsBlacklisted_Viktor()
        {
            var blacklisted = customer.isBlacklisted();
            Assert.AreEqual(true, blacklisted);
        }
    }
}
