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
            rent.StartDate = DateTime.Parse("2016, 02, 11");           
            Assert.AreEqual(DateTime.Today, rent.StartDate);
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
