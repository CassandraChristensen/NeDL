using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Controller
    {
        //The Controller brings together the View and the Model classes. 
        //Use the constructor to instatiate the Display
        //Instatiating the Display calls it's constructor, which calls the input method
        //Once the input is entered, i can instatiate the Model class and pass the values from the View class. 

        private Model model;

        private View view;

        public Controller()
        {
            do
            {
                view = new View();
                model = new Model(view.Num1, view.Num2, view.Op);
                view.Result = model.DoOperation();
                view.ShowResult();
            } while (view.Op != "n");
           
        }
           

    }
}
