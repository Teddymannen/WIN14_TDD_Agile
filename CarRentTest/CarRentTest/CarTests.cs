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
            sportcar.ExtraInsurance = 150;
            Assert.IsTrue(sportcar.ExtraInsurance > 0);
        }
        [TestMethod]
        public void TestCarMilesIsNegativeOrZero_Teddy()
        {
            SportCar sportcar = new SportCar();
            sportcar.MilesDriven = 50;
            
            Assert.IsFalse(sportcar.MilesDriven >= 0);
        }
    }
}
