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
            // Välj familjebil och kolla att den är ledig
            var familyCar = rent.ChooseCar("familycar");
            Assert.IsFalse(familyCar.IsRented);

            // Välj sportbil och kolla att den är ledig
            var sportCar = rent.ChooseCar("sportcar");
            Assert.IsFalse(sportCar.IsRented);
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
