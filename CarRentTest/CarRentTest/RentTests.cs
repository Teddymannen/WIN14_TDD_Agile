﻿using System;
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
            SportCar sportCar = new SportCar();
            Assert.AreEqual(sportCar.IsRented, false);

            FamilyCar familyCar = new FamilyCar();
            Assert.AreEqual(familyCar.IsRented, false);
        }

        [TestMethod]
        public void TestPaymentAccepted_Simon()
        {
            var rent = new Rent();

            rent.PaymentAccepted = true;
            Assert.IsTrue(rent.PaymentAccepted);
        }
        [TestMethod]
        public void TestTotalRentCostSportCar_Marita()
        {
            var rent = new Rent();

            var total = rent.CalcTotal(2, 10, "SportCar");
            Assert.AreEqual(10, total);

        }
        [TestMethod]
        public void TestTotalRentCostFamilyCar_Marita()
        {
            var rent = new Rent();

            var total = rent.CalcTotal(3, 20, "FamilyCar");
            Assert.AreEqual(60, total);

        }
    }
}
