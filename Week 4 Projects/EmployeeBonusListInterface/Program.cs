using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    
    static void MyReadMethod()
    {
      List<Employee> employeeList = new List<Employee>();
      foreach (Employee anEmployee in employeeList)
      {
        Console.WriteLine(anEmployee);
      }
    }
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


      //Try UPDATE crud
      Console.WriteLine("Please enter the last name of the employee you want to update.");
      string employeeLastName = Console.ReadLine();
      Console.WriteLine("Please enter the first name of the employee you want to update.");
      string employeeFirstName = Console.ReadLine();
      bool employeeFound = false;
      
      foreach (Employee anEmployee in employeeList)
      {
        if ((anEmployee.LastName == employeeLastName) && (anEmployee.FirstName == employeeFirstName))
        {
          Console.WriteLine("Please enter the number for what you wish to update: (1) Last Name, (2) First Name, (3) Employment Status, (4) Hourly Pay or (5) Salary Pay");
          int updateOption = Convert.ToInt32(Console.ReadLine());
          employeeFound = true;

          switch (updateOption)
          {
            case 1: 
              Console.WriteLine("What do you wish to update the employee's last name to? ");
              string updateLastName = Console.ReadLine();
              anEmployee.LastName = updateLastName;
              break;

            case 2: 
              Console.WriteLine("What do you wish to update the employee's first name to?");
              string updateFirstName = Console.ReadLine();
              anEmployee.FirstName = updateFirstName;
              break;

            case 3: 
              Console.WriteLine("What do you wish to update the employee's employment status to? H for Hourly and S for Salary");
              string updateEmploymentStatus = Console.ReadLine();
              anEmployee.EmploymentType = updateEmploymentStatus;
              if (updateEmploymentStatus == "H")
                {
                  Console.WriteLine("What is the employee's Hourly Pay?");
                  double updateHourlyPay = Convert.ToDouble(Console.ReadLine());
                  anEmployee.SetRate(updateHourlyPay);
                }
              else 
              {
                Console.WriteLine("What is the employee's Salary Pay?");
                double updateSalaryPay = Convert.ToDouble(Console.ReadLine());
                anEmployee.SetRate(updateSalaryPay);
              }
              break;

            case 4: 
                Console.WriteLine("What would you like to update the employee's Hourly Pay to?");
                double updateHourlyPay2 = Convert.ToDouble(Console.ReadLine());
                anEmployee.SetRate(updateHourlyPay2);
                break;
            
            case 5:
                Console.WriteLine("What is the employee's Salary Pay?");
                double updateSalaryPay2 = Convert.ToDouble(Console.ReadLine());
                anEmployee.SetRate(updateSalaryPay2);
                break;
          }
          
        }
        
      }
      foreach (Employee anEmployee in employeeList)
        {
          Console.WriteLine(anEmployee);
        }
        
    }
  }
}
