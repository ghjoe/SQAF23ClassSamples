using Calculator;

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
        public void CalcTestDivideMethod_OneDividedByOneEqualsOne()
        {
            // Arrange
            MyCalculator calc = new MyCalculator();

            // Act
            int result = calc.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}