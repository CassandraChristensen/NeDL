using CalculatorNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void DoOperationTest()
        {
            //Arrange
            double number1 = 10;
            double number2 = 5;
            string operation = "a";
            Calculator calculator = new Calculator();

            //Act
            Calculator.DoOperation(number1, number2, operation);
            //Assert

        }
    }
}
