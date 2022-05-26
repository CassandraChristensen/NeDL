using System;

namespace CalculatorNS
{

    public class Calculator
    {
        public double Total { get; set; }
        public double Num1 { get; set; }

        public double Num2 { get; set; }
        public Calculator() { }

        public Calculator(double newNum1, double newNum2)
        {
            Num1 = newNum1;
            Num2 = newNum2;
        }

        public void addOperation(double Num1, double Num2)
        {
            Total = Num1 + Num2;
        }

        public void subtractOperation(double Num1, double Num2)
        {
            Total = Num1 - Num2;
        }

        public void multiplyOperation(double Num1, double Num2)
        {
            Total = Num1 * Num2;
        }

        public void divisionOperation(double Num1, double Num2)
        {
            if (Num2 == 0)
            {
                throw new ArgumentOutOfRangeException("Number 2 out of range.");
            }
            else
            {
                Total = Num1 / Num2;
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(10, 15);
            calculator.addOperation(10, 15);


        }
    }
    }
