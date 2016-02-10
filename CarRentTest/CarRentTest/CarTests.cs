using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarRentTest
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void SportCarTest_Theo()
        {


            SportCar sportcar = new SportCar();
            sportcar.setExtraInsurance(150);
            Assert.IsTrue(sportcar.getExtraInsurance());


        }
    }
}
