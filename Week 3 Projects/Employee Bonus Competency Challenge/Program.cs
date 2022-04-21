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
        testEmployee.EmployeeType = 'H';
        

        //Test the toString 
        Console.WriteLine(testEmployee);


    }
  }
}

