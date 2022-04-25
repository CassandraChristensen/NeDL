using System;
using System.Collections.Generic; //needed for lists

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create a list of Salary employees 
      List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();

      //Create a list of Hourly employees
      List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();

      //Input info and create new objects to test
      hourlyEmployeeList.Add(new HourlyEmployee ("Christensen", "Cassie", "Hourly", 18.96));
      salaryEmployeeList.Add(new SalaryEmployee("Weisser", "Lauren", "Salary", 55000));

      //Print the info to screen use a foreach anEmployee in HourlyEmployee
      foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
      {
          Console.WriteLine("");
          Console.WriteLine(anEmployee);
          Console.WriteLine("");

      }

      //Print the info to screen use a foreach anEmployee in SalaryEmployee
      foreach (SalaryEmployee anEmployee in salaryEmployeeList)
      {
          Console.WriteLine(anEmployee);
          Console.WriteLine("");
      }


    } // main
  }  //class program
} //namespace

