using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void setup()
        {

        }

        [TestMethod]
        public void TestSetDate(DateTime d)
        {
            if (d > DateTime.Now)
            {
                Assert.AreEqual(DateTime.Now.GetDateTimeFormats(), d);
            }
        }

    }

}
