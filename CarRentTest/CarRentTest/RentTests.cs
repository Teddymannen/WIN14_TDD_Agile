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
        Rent rent;

        [TestInitialize]
        public void Setup()
        {
            rent = new Rent();
        } 

        [TestMethod]
        public void TestChooseCar_Fredrik()
        {
            // Välj familjebil och kolla att den är ledig
            var familyCar = rent.ChooseCar("familycar");
            Assert.IsFalse(familyCar.IsRented);

            // Välj sportbil och kolla att den är ledig
            var sportCar = rent.ChooseCar("sportcar");
            Assert.IsFalse(sportCar.IsRented);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TestChooseCarWithNullArgument_Fredrik()
        {
            // Testa null exception
            var car = rent.ChooseCar(null);
        }

        [TestMethod]
        public void TestChooseCarWithUnknownCarType_Fredrik()
        {
            try
            {
                // Testa välja bil med okänd biltyp
                var car = rent.ChooseCar("Trabant");
            }
            catch(ArgumentException e)
            {
                // Fånga upp och kolla att felmeddelandet är korrekt
                Assert.AreEqual("Trabant är ingen giltig biltyp", e.Message);
            }
        }

        [TestMethod]
        public void TestPaymentAccepted_Simon()
        {
            rent.PaymentAccepted = true;
            Assert.IsTrue(rent.PaymentAccepted);

            rent.PaymentAccepted = false;
            Assert.IsFalse(rent.PaymentAccepted);
        }
        
        [TestMethod]
        public void TestSetDate_Ayaz()
        {
            //TestSetDate(testa datum för tidigt t.ex, assert is equal)
            rent.StartDate = DateTime.Parse("2016, 02, 11");
            Assert.AreEqual(DateTime.Today, rent.StartDate);

            var format1 = DateTime.Parse("2016 02 11");
            var format2 = DateTime.Parse("2016/02/11");

            Assert.AreEqual(format1, rent.StartDate);
            Assert.AreEqual(format2, rent.StartDate);
            
            //var format3 = DateTime.Parse("11/02/2016");
            //var format4 = DateTime.Parse("11.02.2016");

            //Assert.AreEqual(format3, rent.StartDate);
            //Assert.AreEqual(format4, rent.StartDate);
            
        }

        [TestMethod]
        public void TestTotalRentCostSportCar_Marita()
        {

            var total = rent.CalcTotal(10, 2, "SportCar");
            Assert.AreEqual(370, total);
        }
        [TestMethod]
        public void TestTotalRentCostFamilyCar_Marita()
        {
            var total = rent.CalcTotal(20, 3, "FamilyCar");
            Assert.AreEqual(340, total);
        }
    }
}
