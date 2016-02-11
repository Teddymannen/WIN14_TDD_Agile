using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class CustomerTest
    {
        Customer cust1;
        Customer cust2;
        [TestInitialize]
        public void Setup()
        {
            cust1 = new Customer("Klas", true);
            cust2 = new Customer("Göran", false);
        }
        [TestMethod]
        public void TestCustomerIsBlacklisted_Viktor()
        {
            var blacklisted = cust1.IsBlacklisted();
            Assert.AreEqual(true, blacklisted);

            var b = cust2.IsBlacklisted();
            Assert.AreEqual(false, b);
        }
        
    }
}

