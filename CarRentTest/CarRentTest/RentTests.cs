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

            var total = rent.CalcTotal(10, 2, "SportCar");
            Assert.AreEqual(370, total);
        }
        [TestMethod]
        public void TestTotalRentCostFamilyCar_Marita()
        {
            var total = rent.CalcTotal(20, 3, "FamilyCar");
            Assert.AreEqual(340, total);
        }

        [TestMethod]
        public void TestPenaltyForLateReturn_Fredrik()
        {
            rent.StartDate = DateTime.Parse("2016, 06, 01");
            rent.Days = 4;
            var costWithoutPenalty = rent.CalcTotal(50, 4, "FamilyCar");
            var costWithPenalty = rent.ReturnCar(50, "FamilyCar", DateTime.Parse("2016, 06, 30"));

            Assert.AreEqual(costWithoutPenalty * 2, costWithPenalty);
        }
    }
}
