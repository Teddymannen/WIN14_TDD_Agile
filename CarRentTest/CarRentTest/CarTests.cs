using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{

    [TestClass]
    public class CarTests
    {
        SportCar sportcar;
        FamilyCar familycar;

        [TestInitialize]
        public void Setup()
        {
            sportcar = new SportCar();
            familycar = new FamilyCar();
        }
        [TestMethod]
        public void SportCarTest_Theo()
        {
            sportcar.ExtraInsurance = 150;
            Assert.IsTrue(sportcar.ExtraInsurance > 0);
        }
        [TestMethod]
        public void TestCarMilesIsAboveZero_Teddy()
        {
            sportcar.MilesDriven = 50;
            Assert.IsTrue(sportcar.MilesDriven > 0); 
            sportcar.MilesDriven = -50;
            Assert.IsFalse(sportcar.MilesDriven > 0);

            familycar.MilesDriven = 20;
            Assert.IsTrue(familycar.MilesDriven > 0);
            familycar.MilesDriven = 0;
            Assert.IsFalse(familycar.MilesDriven > 0);
            
        }
    }
}
