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
        Rent rent;

        [TestInitialize]
        public void Setup()
        {
            rent = new Rent();
        } 

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
            rent.PaymentAccepted = true;
            Assert.IsTrue(rent.PaymentAccepted);
        }
        
        [TestMethod]
        public void TestSetDate_Ayaz()
        {
            //TestSetDate(testa datum för tidigt t.ex, assert is equal)
            //TestSetData(t.ex: IsNotNull, Olika format, store an idag datum)
            rent.StartDate = DateTime.Parse("2016, 02, 11"); 

            var format1 = DateTime.Parse("11/02/2016");
            var format2 = DateTime.Parse("11.02.2016");
            var format3 = DateTime.Parse("11-02-2016");

            Assert.AreEqual(DateTime.Today, rent.StartDate);
            Assert.AreNotEqual(format1, rent.StartDate);
            Assert.AreNotEqual(format2, rent.StartDate);
            Assert.AreNotEqual(format3, rent.StartDate);
       
        }
        [TestMethod]
        public void TestTotalRentCostSportCar_Marita()
        {
            var total = rent.CalcTotal(2, 10, "SportCar");
            Assert.AreEqual(10, total);
        }
        [TestMethod]
        public void TestTotalRentCostFamilyCar_Marita()
        {
            var total = rent.CalcTotal(3, 20, "FamilyCar");
            Assert.AreEqual(60, total);
        }
    }
}
