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
            SportCar sportCar = new SportCar();
            Assert.AreEqual(sportCar.getIsRented(), false);

            FamilyCar familyCar = new FamilyCar();
            Assert.AreEqual(familyCar.getIsRented(), false);
        }

        [TestMethod]
        public void TestPaymentAccepted_Simon()
        {
            var rent = new Rent();

            rent.PaymentAccepted = true;
            Assert.IsTrue(rent.PaymentAccepted);
        }

        [TestMethod]
        public void TestSetDate_Ayaz(DateTime d)
        {
            //TestSetDate(testa datum för tidigt t.ex, assert is equal)
            if (d > DateTime.Now || d == DateTime.Now.AddYears(2016))
            {
                Assert.AreEqual(DateTime.Now.GetDateTimeFormats(), d);
            }
            
        }
    }
}
