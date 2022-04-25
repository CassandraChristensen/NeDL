using System;

namespace MyApplication
{
  class Salary : Employee // derived(child) : base(parent)
  {
      
      //Create my private fields and my properties using short hand. Because I am using shorthand, I do not need to find the field of the property.
      public int SalaryPay
      { get; set; }
 

      //Create my default constructor
      public Salary ()
      {
          SalaryPay = -1;
      }
      
      //Create my constructor that passes values
      public Salary (int aSalaryPay, string aFirstName, string aLastName, char aEmployeeType): base(aFirstName, aLastName, aEmployeeType)
      {
          SalaryPay = aSalaryPay;
      }
      
      //Calculate the bonus 
        public int SalaryBonusMethod ()
        {
            double doubleSalaryPay = (double) SalaryPay;
            double doubleSalaryBonus = doubleSalaryPay * .1;
            int intSalaryBonus = (int) doubleSalaryBonus;

            return intSalaryBonus;
        }

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return FirstName + " " + getEmployeeLastName() + " is an " + EmployeeType + " employee. Their bonus will be: " + SalaryBonusMethod() + ".";
      }

    
  } //Employee class
} //Namespace