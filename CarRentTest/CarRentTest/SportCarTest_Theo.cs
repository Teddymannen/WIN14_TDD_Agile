using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class SportCarTest_Theo
    {
        [TestMethod]
        public void TestMethod1()
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
