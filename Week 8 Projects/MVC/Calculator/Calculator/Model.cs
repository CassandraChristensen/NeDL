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

        //default constructor
        public Model()
        {
            Number1 = 0;
            Number2 = 0;
            Operation = "";
        }

        //overloaded constructor
        public Model(double newNumber1, double newNumber2, string newOperation)
        {
            Number1 = newNumber1;
            Number2 = newNumber2;
            Operation = newOperation;
        }


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



        



        public double DoOperation()
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (Operation)
            {
                case "a":
                    result = Number1 + Number2;
                    break;
                case "s":
                    result = Number1 - Number2;
                    break;
                case "m":
                    result = Number1 * Number2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (Number2 != 0)
                    {
                        result = Number1 / Number2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        } //End of Do Operation

    } //end of class
    } //end of namespace
 
