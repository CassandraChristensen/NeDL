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
        private double result;

        //constructor
        public View()
        {
            Num1 = 0;
            Num2 = 0;
            Op = "";
            Result = 0;
            GetValues();
            

        }


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

        public double Result
        {
            get { return result; }
            set { result = value; }
        }






        //method for getting input (private)
        //Called in constructor
        private void GetValues()
        {

            //bool endApp = false;

          //  while (!endApp)
          //  {
                // Ask the user to type the first number.
                Console.WriteLine("Type a number, and then press enter");
                Num1 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                Num2 = Convert.ToDouble(Console.ReadLine());


                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                Op = Console.ReadLine();

                

                //Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
              //if (Console.ReadLine() == "n") endApp = true;
           // }
        } //end of GetValues method


        //public method for showing output
        //public so i can access it from the controller.
        public void ShowResult()
        {
            
            Console.WriteLine("Number 1: " + Num1);
            Console.WriteLine("Number 2: " + Num2);
            Console.WriteLine("Operation: " + Op);
            Console.WriteLine("Result: " + Result);
            Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            Op = Console.ReadLine();
            //Console.ReadKey();
        }

        



    }
}
