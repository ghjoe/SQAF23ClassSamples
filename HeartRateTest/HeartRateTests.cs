using HeartRate;
using System;

namespace HeartRateTest
{
    [TestClass]
    public class HeartRateTests
    {
// Pairwise Testing Output for the 4 factors of gender, age, active and exercise from our Decision Table
//Female Over40  Active Exercise
    //True True    False Regular
//False False   False Minimal
//True True    True Minimal
//False False   True High
//False False   True Regular
    //False True    True Sporadic
//True False   False Sporadic
//True True    False High
//True True    True Sedentary
//False False   False Sedentary

        [TestMethod]
        public void FemaleOver40NotActiveRegular()
        {
            // Arrange
            Customer myCustomer = new Customer();
            myCustomer.IsFemale = true;
            myCustomer.Age = 50;
            myCustomer.Active = false;
            myCustomer.ActivityLevel = ActivityLevel.REGULAR;

            // Act
            myCustomer.CalculateOutputs();

            // Assert
            Assert.AreEqual("Gulati", myCustomer.FormulaType);
            Assert.AreEqual(162, myCustomer.MHR);
            Assert.AreEqual(147, myCustomer.TargetMax);
            Assert.AreEqual(129, myCustomer.TargetMin);
        }

        //False True    True Sporadic
        [TestMethod]
        public void MaleOver40ActiveSporadic()
        {
            // Arrange
            Customer myCustomer = new Customer();
            myCustomer.IsFemale = false;
            myCustomer.Age = 60;
            myCustomer.Active = true;
            myCustomer.ActivityLevel = ActivityLevel.SPORADIC;

            // Act
            myCustomer.CalculateOutputs();

            // Assert
            Assert.AreEqual("Hunt", myCustomer.FormulaType);
            Assert.AreEqual(172, myCustomer.MHR);
            Assert.AreEqual(144, myCustomer.TargetMax);
            Assert.AreEqual(127, myCustomer.TargetMin);
        }
    }
}