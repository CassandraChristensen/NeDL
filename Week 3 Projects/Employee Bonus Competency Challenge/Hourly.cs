using System;

namespace MyApplication
{
  class Hourly : Employee // derived(child) : base(parent)
  {
      
      //Create my private fields and my properties using short hand. Because I am using shorthand, I do not need to find the field of the property.
      public float HourlyPay
      { get; set; }
 

      //Create my default constructor
      public Hourly ()
      {
          HourlyPay = 0.0f;
      }
      
      //Create my constructor that passes values
      public Hourly (float aHourlyPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          HourlyPay = aHourlyPay;
      }
      
      //Calculate the bonus 
        public int HourlyBonusMethod ()
        {
            double doubleHourlyPay = (double) HourlyPay;
            double doubleHourlyBonus = doubleHourlyPay * 80;
            int intHourlyBonus = (int) doubleHourlyBonus;

            return intHourlyBonus;
        }

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return FirstName + " " + getEmployeeLastName() + " is an " + EmployeeType + " employee. Their bonus will be: " + HourlyBonusMethod() + ".";
      }

    
  } //Employee class
} //Namespace
