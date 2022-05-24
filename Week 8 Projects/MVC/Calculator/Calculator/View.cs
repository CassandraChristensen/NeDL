using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class View
    {

        //This is the View class. It's purpose is to gather the input and display the output. 
        //Variables will be class level fields, so the Controller can have access to the fields through properties. 

        //private fields
        private double num1;
        private double num2;
        private string op;

        //properties
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public string Op
        {
            get { return op; }  
            set { op = value; } 
        }


        //constructor
        public View()
        {
            num1 = 0;
            num2 = 0;
            op = "";
        }

        //me

        

    }
}
