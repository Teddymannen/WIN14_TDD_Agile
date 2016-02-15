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
        public void TestCalcNumDays_Teddy()
        {
            rent.StartDate = DateTime.Parse("2016-02-11");
            rent.EndDate = DateTime.Parse("2016-02-20");

            rent.TotalDaysRent = (rent.EndDate - rent.StartDate).TotalDays;
            Assert.AreEqual(rent.TotalDaysRent, 9);
        }

        [TestMethod]
        public void TestChooseFamilyCar_Fredrik()
        {
            // Test to choose Family car
            rent.ChooseCar("familycar");

            // Make sure a car has been selected
            Assert.IsNotNull(rent.SelectedCar);

            // Make sure selected car is a family car
            Assert.IsTrue(rent.SelectedCar is FamilyCar);

            // Make sure selected car is available to rent
            Assert.IsFalse(rent.SelectedCar.IsRented);
        }

        [TestMethod]
        public void TestChooseSportCar_Fredrik()
        {
            // Test to choose Sport car
            rent.ChooseCar("sportcar");

            // Make sure a car has been selected
            Assert.IsNotNull(rent.SelectedCar);

            // Make sure selected car is a sport car
            Assert.IsTrue(rent.SelectedCar is SportCar);

            // Make sure selected car is available to rent
            Assert.IsFalse(rent.SelectedCar.IsRented);
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
            catch (ArgumentException e)
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
            //TestSetDate(Testing Formats...)
            rent.StartDate = DateTime.Parse("2016, 02, 15");
            Assert.AreEqual(DateTime.Today, rent.StartDate);

            var format1 = DateTime.Parse("2016 02 15");
            var format2 = DateTime.Parse("2016/02/15");

            Assert.AreEqual(format1, rent.StartDate);
            Assert.AreEqual(format2, rent.StartDate);
            
            
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestSetStartDateBeforeToday_Ayaz()
        {
            // Testing Past Date
            rent.StartDate = DateTime.Parse("2016, 02, 11");
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestSetEndDateBeforeStartDate_Ayaz()
        {
            //Testing EndDate
            rent.StartDate = DateTime.Today;
            rent.EndDate = DateTime.Parse("2016, 02, 11");
        }

        [TestMethod]
        public void TestSetDate_EndDate_Ayaz()
        {
            //TestSetDate(Checking StartDate and EndDate)
            var todayDate = DateTime.Today.Date;
            var enddate = rent.EndDate;

            Assert.AreEqual(rent.StartDate, todayDate);
            Assert.AreEqual(rent.EndDate, enddate);

        }

        [TestMethod]
        public void TestCheckBookingIsValidCorrect_Ayaz()
        {
            //Test Checking if Booking is Valid

            rent.StartDate = DateTime.Parse("2016, 02, 15");
            rent.EndDate = DateTime.Parse("2016, 02, 15");
            rent.ChooseCar("sportcar");
            rent.ValidatingInputValue();

            Assert.IsTrue(rent.IsBookingValid);

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
        public void TestTotalRentCostFamilyCarZeroValue_Marita()
        {
            var total = rent.CalcTotal(0, 3, "FamilyCar");
            Assert.IsNotNull(true);

        }

        [TestMethod]
        public void TestTotalRentCostSportsCarZeroValue_Marita()
        {
            var total = rent.CalcTotal(0, 3, "SportCar");
            Assert.IsNotNull(true);
        }

        [TestMethod]
        public void TestPenaltyForLateReturn_Fredrik()
        {
            // Hyrtiden
            rent.StartDate = DateTime.Parse("2016, 06, 01");
            rent.EndDate = DateTime.Parse("2016, 06, 05");

            var costWithoutPenalty = rent.CalcTotal(50, 4, "FamilyCar");

            // Återlämningsdatum som gått över tiden med 25 dagar
            rent.CalculatePenaltyOrDiscount(DateTime.Parse("2016, 06, 30"));

            var costWithPenalty = rent.CalcTotal(50, 29, "FamilyCar");

            Assert.AreEqual(500, costWithoutPenalty);
            // Penalty ska vara 100 x 25 extra (25 dagar á 100)
            Assert.AreEqual(3000 + 25 * 100, costWithPenalty);

        }

        [TestMethod]
        public void TestEarlyReturn_Fredrik()
        {
            // Förvald hyrtid
            rent.StartDate = DateTime.Parse("2016, 06, 01");
            rent.EndDate = DateTime.Parse("2016, 06, 05");

            var costWithoutDiscount = rent.CalcTotal(50, 4, "FamilyCar");

            // Återlämningsdatum 1 dag tidigare
            rent.CalculatePenaltyOrDiscount(DateTime.Parse("2016, 06, 04"));

            var costWithDiscount = rent.CalcTotal(50, 4, "FamilyCar");

            Assert.AreEqual(500, costWithoutDiscount);
            // Rabatten ska vara 1 dag á 100
            Assert.AreEqual(500 - 1*100, costWithDiscount);

        }

    }
}
