using CalculatorNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void CalculatorAddMethodTest()
        {
            //Arrange
            double Num1 = 10;
            double Num2 = 5;
            double expected = 15;
            Calculator calculator = new Calculator();

            //Act
            calculator.addOperation(Num1, Num2);

            //Assert
            double actual = calculator.Total;
            Assert.AreEqual(expected, actual, 0.001, "Numbers were not added correctly.");
        }

        [TestMethod]

        public void CalculatorSubtractMethodTest()
        {
            //Arrange 
            double Num1 = 20;
            double Num2 = 2;
            double expected = 18;
            Calculator calculator = new Calculator();

            //Act 
            calculator.subtractOperation(Num1, Num2);

            //Assert 
            double actual = calculator.Total;
            Assert.AreEqual(expected, actual, 0.001, "Number 2 was not subtracted correctly from number 1.");

        }

        [TestMethod]
        public void CalculatorMultiplyMethodTest()
        {
            //Arrange 
            double Num1 = 2;
            double Num2 = 3;
            double expected = 6;
            Calculator calculator = new Calculator();

            //Act
            calculator.multiplyOperation(Num1, Num2);

            //Assert 
            double actual = calculator.Total;
            Assert.AreEqual(expected, actual, 0.001, "Numbers were not multiplied correctly.");
        }

        [TestMethod]
        public void CalculatorDivisionMethodWhenArgumentIsOutOfRangeTest()
        {
            //Arrange
            double Num1 = 10;
            double Num2 = 0;
            ;
            Calculator calculator = new Calculator();

            //Act 
            try
            {
                calculator.divisionOperation(Num1, Num2);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert 
                StringAssert.Contains(e.Message, "Number 2 out of range.");
                return;
            }
            //Assert
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]

        public void CalculatorDivisionMethodTest()
        {
            //Arrange
            double Num1 = 10;
            double Num2 = 2;
            double expected = 5;
            Calculator calculator = new Calculator();

            //Act
            calculator.divisionOperation(Num1,Num2);

            //Assert
            double actual = calculator.Total;
            Assert.AreEqual(expected, actual, 0.001, "Numbers were not divided correctly.");

        }

    }
    
}
