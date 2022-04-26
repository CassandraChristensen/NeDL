using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Instantiate my list
      List<Employee> employeeList = new List<Employee>();  
      List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();
      List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();



      //Instantiate object and put data into it.
      employeeList.Add(new Employee("Christensen", "Austin", "S"));
      hourlyEmployeeList.Add(new HourlyEmployee("Jensen", "Trace", "H", 18.96));
      salaryEmployeeList.Add(new SalaryEmployee("Galloway", "Bry", "S", 65000));


      //Output data to console
      foreach (Employee anEmployee in employeeList)
      {
          Console.WriteLine(anEmployee);
      }

      foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
      {
          Console.WriteLine(anEmployee);
      }

      foreach (SalaryEmployee anEmployee in salaryEmployeeList)
      {
          Console.WriteLine(anEmployee);
      }
    }
  }
}
