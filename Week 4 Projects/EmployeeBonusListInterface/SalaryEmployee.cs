using System;

namespace MyApplication
{
  class SalaryEmployee : Employee, IGetBonus, IRate, IGetMoney
  {
    //Create my properties
    public double SalaryRate
    { get; set; }

    //Create my default constructor 
    public SalaryEmployee ()
    {
        SalaryRate = 0.0;
    }

    //Create my constructor with parameters
    public SalaryEmployee (string newLastName, string newFirstName, string newEmploymentType, double newSalaryRate) : base(newLastName, newFirstName, newEmploymentType)
    {
        SalaryRate = newSalaryRate;
    }

    public double GetBonus()  //interface method
    {
        return SalaryRate * .10;
    }

    public override void SetRate(double newRate)
    {
      SalaryRate = newRate;
    }

   public override void SetWage (double newWage)
   {
     SalaryRate = newWage;
   }

    //Create my GetBonus Method
    public override string ToString ()
    {
        return base.ToString() + " | Salary Rate: $" + SalaryRate + " | Bonus: $" + GetBonus();
    }
  }
}