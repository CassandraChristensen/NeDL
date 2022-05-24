using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    internal class TipCalculatorController
    {
        /* This TipCalculatorController class brigns together the display and the tip or model classes. 
         * I use the constructor to instantiate the Display. 
         * Instantiating the Display calls it's construtor, which calls the Get input method. 
         * Once the input is entered, I can instatiate the Tip class and pass the values from the Display class. 
         * Notice the dot notations and observe how the two classes interact. */

        private Tip tip;
        private Display display;

        public TipCalculatorController()
        {
            display = new Display();   //View (user interface basically)
            tip = new Tip(display.Amt, display.Percentage);  //Model (data storage, constructions/operations.
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipandTotal();
        }
    }
}
