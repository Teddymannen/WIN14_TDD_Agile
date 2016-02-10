using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void SportCarTest_Theo()
        {
            SportCar sportcar = new SportCar();
            sportcar.setExtraInsurance(150);
            Assert.IsTrue(sportcar.getExtraInsurance());
        }
        [TestMethod]
        public void TestCarMilesIsNegativeOrZero_Teddy()
        {
            var carMiles = 50;
            Assert.IsFalse(carMiles >= 0);
        }
    }
}
