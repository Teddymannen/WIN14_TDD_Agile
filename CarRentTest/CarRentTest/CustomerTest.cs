using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer;
        [TestInitialize]
        public void Setup()
        {
            customer = new Customer();
        }
        [TestMethod]
        public void TestCustomerIsBlacklisted_Viktor()
        {
            var blacklisted = customer.getIsBlacklisted();
            Assert.AreEqual(true, blacklisted);
        }
    }
}
