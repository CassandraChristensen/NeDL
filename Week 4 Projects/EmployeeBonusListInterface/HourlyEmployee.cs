using System;

namespace MyApplication
{
  class HourlyEmployee : Employee, IGetBonus, IRate
  {
    //Create my properties
    public double HourlyRate
    { get; set; }

    //Create my default constructor 
    public HourlyEmployee ()
    {
        HourlyRate = 0.0;
    }

    //Create my constructor with parameters
    public HourlyEmployee (string newLastName, string newFirstName, string newEmploymentType, double newHourlyRate) : base(newLastName, newFirstName, newEmploymentType)
    {
        HourlyRate = newHourlyRate;
    }

    public double GetBonus()  //interface method
    {
        return HourlyRate * 80;
    }

    public override void SetRate(double newRate)
    {
      HourlyRate = newRate;
    }

    //Create my tostring
    public override string ToString ()
    {
        return base.ToString() + " | Hourly rate: $" + HourlyRate + " | Bonus: $" + GetBonus();
    }
  }
}