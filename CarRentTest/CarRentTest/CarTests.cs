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
            Assert.AreEqual(150, sportcar.ExtraInsurance);
            sportcar.ExtraInsurance = 350;
            Assert.IsTrue(sportcar.ExtraInsurance > 150);
            sportcar.ExtraInsurance = 20;
            Assert.AreEqual(150, sportcar.ExtraInsurance);
        }
        [TestMethod]
        public void TestCarMilesIsAboveZero_Teddy()
        {
            // Sport car tests
            sportcar.MilesDriven = 50;
            Assert.IsTrue(sportcar.MilesDriven > 0); 
            sportcar.MilesDriven = -50;
            Assert.IsFalse(sportcar.MilesDriven > 0);

            // Family car tests
            familycar.MilesDriven = 500 + familycar.TotalMilesDriven;
            Assert.IsTrue(familycar.MilesDriven > familycar.TotalMilesDriven);

            familycar.MilesDriven = 20;
            Assert.IsTrue(familycar.MilesDriven > 0);
            familycar.MilesDriven = 0;
            Assert.IsFalse(familycar.MilesDriven > 0);
        }
    }
}
