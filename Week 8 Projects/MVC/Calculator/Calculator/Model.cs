using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Model
    {
        //This is the Model. 
        //It will handle: Data, Constructors, operations. 

        //private fields: 
        private double number1;
        private double number2;
        private string operation;

        //properties
        public double Number1
        { get { return number1; } 
          set { number1 = value; } 
        }

        public double Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        //Constructors. 

        //default constructor
        public Model ()
        {
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        //overloaded constructor
        public Model(double newNumber1, double newNumber2, string newOperation)
        {
            number1 = newNumber1;
            number2 = newNumber2;
            operation = newOperation;
        }

        public double DoOperation(double Number1, double Number2, string Operation)
        {
            double result = double.NaN;

            switch (Operation)
            {
                case "a":
                    result = Number1 + Number2;
                    break;
                case "b":
                    result = Number1 - Number2;
                    break;
                case "c":
                    result = Number1 * Number2;
                    break;
                case "d": 
                    if (number2 != 0)
                    {
                        result = Number1 / Number2;
                    }
                    break;
                default: break;
            }
            return result;

        }
    }
}
