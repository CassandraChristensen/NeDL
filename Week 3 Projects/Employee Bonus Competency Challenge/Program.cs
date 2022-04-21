using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
        //Create a test object for Employee 
        Employee testEmployee = new Employee();   ///This is creating my object, and calling the default constructor to give default values to the fields.
        testEmployee.LastName = "Christensen";
        testEmployee.FirstName = "Austin";
        testEmployee.EmployeeType = 'E';

        //Create a test object for Hourly 
        Hourly testHourly = new Hourly ();
        testHourly.LastName = "Weisser";
        testHourly.FirstName = "Lauren";
        testHourly.EmployeeType = 'H';
        testHourly.HourlyPay = 18.96F;

        //Create a test object for Salary
        Salary testSalary = new Salary (); 
        testSalary.LastName = "Crandall";
        testSalary.FirstName = "Stephanie";
        testSalary.EmployeeType = 'S';
        testSalary.SalaryPay = 65000;
        

        //Test the toString 
        Console.WriteLine(testEmployee);

        //Test the toString 
        Console.WriteLine(testHourly);

        //Test the toString
        Console.Write(testSalary);

    }
  }
}

