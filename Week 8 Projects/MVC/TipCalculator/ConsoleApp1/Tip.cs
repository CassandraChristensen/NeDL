using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSample
{
    internal class Tip
    {
        /* This class does a very simple tip calculation.
         * It has two fields: Amount and Tip Percent. 
         * We are ignoring tax and wherther we tip before or after tax. 
         * The point is the MVC Model. This is the model part of MVC. 
         * It does the calculations and handles the data. 
         * It is totally unaware of the Display class or the controller. */

        //private fields
        private double amount;
        private double tipPercent;

        //default constructor
        public Tip()
        {
            Amount = 0;
            TipPercent = 0;
        }

        //overload constructor 
        public Tip(double amt, double percent)
        {
            Amount = amt;
            TipPercent = percent;
        }

        //public properties
        public double Amount
        {
            get { return amount; }
            set { amount = value; } 
        }

        public double TipPercent
        {
            get { return tipPercent; }  
            set { 
                    //here we check to see if they entered the percent as a decimal or a whole number
                    //If it is a whole number, larger than 1 we divide it by 100, so the highest possible tip is 100%
                    if (value > 1)
                    {
                        value /= 100;
                    }
                    tipPercent = value; 
                }
        }

        public double CalculateTip()
        {
            //very simplistic tip calculation
            return Amount * TipPercent;
        }

        public double CalculateTotal()
        {
            //simple total calculation
            return CalculateTip() + Amount;
        }

    }
}
