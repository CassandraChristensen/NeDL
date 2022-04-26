using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Instantiate my list 3 separate lists
      /* List<Employee> employeeList = new List<Employee>();  
      List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();
      List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>(); */
      
      //One List
      List<Employee> employeeList = new List<Employee>();



      /* //Instantiate object and put data into it.
      employeeList.Add(new Employee("Christensen", "Austin", "S"));
      hourlyEmployeeList.Add(new HourlyEmployee("Jensen", "Trace", "H", 18.96));
      salaryEmployeeList.Add(new SalaryEmployee("Galloway", "Bry", "S", 65000)); */

      //One List, instantiate the objects and put data into them
      employeeList.Add(new Employee("Christensen", "Austin", "H"));
      employeeList.Add(new HourlyEmployee("Jensen", "Trace", "H", 18.96));
      employeeList.Add(new SalaryEmployee("Galloway", "Bry", "S", 65000));


      //Output data to console
      foreach (Employee anEmployee in employeeList)
      {
          Console.WriteLine(anEmployee);
      }

      /* foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
      {
          Console.WriteLine(anEmployee);
      }

      foreach (SalaryEmployee anEmployee in salaryEmployeeList)
      {
          Console.WriteLine(anEmployee);
      } */


      //Experimenting with finding an employee name
      Console.WriteLine("Please enter the last name of the employee you want to find.");
      string findName = Console.ReadLine();
      bool found = false;

      foreach (Employee anEmployee in employeeList)
      {
          if (anEmployee.LastName == findName)
          {
              Console.WriteLine(anEmployee);
              found = true;
          }
      }
      if (!(found))
      {
          Console.WriteLine("Name was not found.");
      }

    }
  }
}
