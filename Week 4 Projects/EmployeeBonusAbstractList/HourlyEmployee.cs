using System;

namespace MyApplication
{
  // Abstract class
  class HourlyEmployee : Employee  //derived : base
  {
      //Create my properties 
      public double HourlyRate
      { get; set; }

      //Create my default constructor 
      public HourlyEmployee() : base()
      {
          HourlyRate = 0.0;
      }

      //Create my constructor with parameters
      public HourlyEmployee(string newLastName, string newFirstName, string newEmployeeType, double newHourlyRate) : base(newLastName, newFirstName, newEmployeeType)
      {
          HourlyRate = newHourlyRate;
      }

      //Use my abstract Method for GetBonus()
      public override double GetBonus()
      {
          return HourlyRate * 80;
      }

      //Use my ToString polymorph
      public override string ToString()
      {
          return base.ToString() + " | Hourly rate: $" + HourlyRate + " | Bonus: $" + GetBonus();
      }


  }//Class  
}//namespace