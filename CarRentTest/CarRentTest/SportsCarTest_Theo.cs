using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class SportsCarTest_Theo
    {
        [TestMethod]
        public void SportCarTest()
        {
            SportCar sportcar = new SportCar();
            sportcar.setExtraInsurance(150);
            Assert.IsTrue(sportcar.getExtraInsurance());


        }
    }
}
