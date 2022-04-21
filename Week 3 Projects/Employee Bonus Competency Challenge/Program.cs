using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
        //Create a test object for Employee 
        Employee testEmployee = new Employee();
        testEmployee.LastName = "Christensen";
        testEmployee.FirstName = "Austin";
        testEmployee.EmployeeType = 'E';

        //Create a test object for Hourly 
        Hourly testHourly = new Hourly ();
        testHourly.LastName = "Weisser";
        testHourly.FirstName = "Lauren";
        testHourly.EmployeeType = 'H';
        testHourly.HourlyPay = 18.96F;
        

        //Test the toString 
        Console.WriteLine(testEmployee);

        //Test the toString 
        Console.WriteLine(testHourly);

    }
  }
}

