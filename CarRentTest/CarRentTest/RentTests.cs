using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    /// <summary>
    /// Summary description for CarRentTest
    /// </summary>
    [TestClass]
    public class RentTests
    {
        [TestMethod]
        public void TestChooseCar_Fredrik()
        {
            // assert is true för om bilen är tillgänglig + om man har valt biltyp

            var car = new Car();

            SportCar sportCar = car.ChooseCar("sportcar");
            Assert.AreEqual(sportCar.IsRented, false);

            FamilyCar familyCar = car.ChooseCar("familycar");
            Assert.AreEqual(familyCar.IsRented, false);

            /*
            Enklare version:
            var familyCar = new FamilyCar();
            Assert.AreEqual(familyCar.IsRented, false);

            var sportCar = new SportCar();
            Assert.AreEqual(sportCar.IsRented, false);
            */
        }
    }
}
