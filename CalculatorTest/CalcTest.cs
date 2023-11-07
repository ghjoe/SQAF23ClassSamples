using Calculator;
using System.ComponentModel;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void CalcTestAddMethod_OnePlusOneEqualsTwo()
        {
            // Arrange
            MyCalculator calc = new MyCalculator();

            // Act
            int result = calc.Add(1, 1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalcTestMultiplyMethod_OneTimesOneEqualsOne()
        {
            // Arrange
            MyCalculator calc = new MyCalculator();

            // Act
            int result = calc.Multiply(1, 1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalcTestDivideMethod_OneDividedByOne()
        {
            // Arrange
            MyCalculator calculator = new MyCalculator();

            // Act
            int result = calculator.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(100, 10, 10)]
        [DataRow(10000, 100, 100)]
        public void CalcTestDivideMethod_DataDrivenDivisions(int dividend, int divisor, int expectedResult)
        {
            // Arrange
            MyCalculator calc = new MyCalculator();

            // Act
            int result = calc.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        //[TestMethod]
        //public void CalcTestDivideMethod_HundredDividedByTenEqualsTen()
        //{
        //    // Arrange
        //    MyCalculator calc = new MyCalculator();

        //    // Act
        //    int result = calc.Divide(100, 10);

        //    // Assert
        //    Assert.AreEqual(10, result);
        //}

        //[TestMethod]
        //public void CalcTestDivideMethod_TenThousandDividedByHundredEqualsHundred()
        //{
        //    // Arrange
        //    MyCalculator calc = new MyCalculator();

        //    // Act
        //    int result = calc.Divide(10000, 100);

        //    // Assert
        //    Assert.AreEqual(100, result);
        //}

        [TestMethod]
        public void CalcTestDivideMethod_OneDividedByZeroThrowsException()
        {
            // Arrange
            MyCalculator calc = new MyCalculator();

            // Act
            //int result = calc.Divide(1, 0);

            // Assert
            Assert.ThrowsException<ArgumentException>(() => calc.Divide(1, 0));
        }
    }
}