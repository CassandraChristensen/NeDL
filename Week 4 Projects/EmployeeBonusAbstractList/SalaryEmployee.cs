using System;

namespace MyApplication
{
  class SalaryEmployee : Employee //(derived : base)
  {
    //Create my property 
    public double SalaryAnnual
    { get; set; }

    //Create my default constructor 
    public SalaryEmployee ()
    {
        SalaryAnnual = 0.0;
    }

    //Create my constructor that passes parameters
    public SalaryEmployee (string newLastName, string newFirstName, string newEmployeeType, double newSalaryAnnual) : base(newLastName, newFirstName, newEmployeeType)
    {
        SalaryAnnual = newSalaryAnnual;
    }

    //Create my GetBonus() 
    public override double GetBonus()
    {
        return SalaryAnnual * .10;
    }

    //Create my ToString
    public override string ToString()
    {
        return base.ToString() + " | Annual Salary: $" + SalaryAnnual + " | Bonus: $" + GetBonus();
    }
  } //class
} //namespace
