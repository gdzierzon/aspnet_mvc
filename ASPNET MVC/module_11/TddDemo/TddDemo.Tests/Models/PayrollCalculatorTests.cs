using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddDemo.Models;

namespace TddDemo.Tests.Models
{
    [TestClass]
    public class PayrollCalculatorTests
    {
        [TestMethod]
        public void Should_NotPayOvertime_WithLessThan40Hours()
        {
            //arrange
            PayrollCalculator calculator = new PayrollCalculator();
            double hours = 5.0;
            decimal rate = 8.25m;
            decimal expectedResult = 41.25m;

            //act
            decimal actualResult = calculator.CalulateGrossPay(hours, rate);

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Should_PayOvertime_WithOver40Hours()
        {
            //arrange
            PayrollCalculator calculator = new PayrollCalculator();
            double hours = 42.5;
            decimal rate = 10m;
            decimal expectedResult = 437.50m;

            //act
            decimal actualResult = calculator.CalulateGrossPay(hours, rate);

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}