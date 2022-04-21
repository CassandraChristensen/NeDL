using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
        //Create a test object for Employee 
        Employee testEmployee = new Employee();   ///This is creating my object, and calling the default constructor to give default values to the fields.
        testEmployee.setEmployeeLastName("Christensen");
        testEmployee.FirstName = "Austin";
        testEmployee.EmployeeType = 'E';

        //Create a test object for Hourly 
        Hourly testHourly = new Hourly ();
        testHourly.setEmployeeLastName("Weisser");
        testHourly.FirstName = "Lauren";
        testHourly.EmployeeType = 'H';
        testHourly.HourlyPay = 18.96F;

        //Create a test object for Salary
        Salary testSalary = new Salary (); 
        testSalary.setEmployeeLastName("Crandall");
        testSalary.FirstName = "Stephanie";
        testSalary.EmployeeType = 'S';
        testSalary.SalaryPay = 65000;
        
        //Create an array for employee
        Employee [] employeeArray = new Employee[5];
        employeeArray[1] = testEmployee;
        employeeArray[2] = testHourly;
        employeeArray[3] = testSalary;
        employeeArray[4] = new Salary( 55000, "Zac", "Champoux", 'S');
        employeeArray[0] = new Hourly( 15.50F, "Trace", "Jensen", 'H');
        

        for (int index = 0; index < employeeArray.Length; index++)
        {
            if (!(employeeArray[index]==null))
                Console.WriteLine(employeeArray[index]);
        }



            /* //Test the toString 
            Console.WriteLine(testEmployee);

            //Test the toString 
            Console.WriteLine(testHourly);

            //Test the toString
            Console.Write(testSalary); */

        }
  }
}

