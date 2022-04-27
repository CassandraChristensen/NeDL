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
      List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();
      
      //One List
      List<Employee> employeeList = new List<Employee>();



      //Instantiate object and put data into it.
      employeeList.Add(new Employee("Christensen", "Austin", "S"));
      hourlyEmployeeList.Add(new HourlyEmployee("Jensen", "Trace", "H", 18.96));
      salaryEmployeeList.Add(new SalaryEmployee("Galloway", "Bry", "S", 65000));

      //One List, instantiate the objects and put data into them
      employeeList.Add(new Employee("Christensen", "Austin", "H"));
      employeeList.Add(new HourlyEmployee("Jensen", "Trace", "H", 18.96));
      employeeList.Add(new SalaryEmployee("Galloway", "Bry", "S", 65000));


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
      } */


      /* //Experimenting with finding an employee name
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
      } */

        // Declare variables
        bool userChoice;
        string userChoiceString;
        List<Employee> employeeList = new List<Employee>();

      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What's your pleasure? ");
                Console.WriteLine("L: Load the data file into an array.");
                Console.WriteLine("S: Save the array to the data file.");
                Console.WriteLine("C: Add a name to the array.");
                Console.WriteLine("R: Read a name from the array.");
                Console.WriteLine("U: Update a name in the array.");
                Console.WriteLine("D: Delete a name from the array.");
                Console.WriteLine("Q: Quit the program.");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "S" || userChoiceString == "s" ||
                            userChoiceString == "C" || userChoiceString == "c" ||
                            userChoiceString == "R" || userChoiceString == "r" ||
                            userChoiceString == "U" || userChoiceString == "u" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
                string readLastName;
                string readFirstName;
                string readEmploymentType;
                double readSalaryPay;
                double readHourlyPay;

                int index = 0;

                using (StreamReader sr = new StreamReader ("employee.txt"))
                {
                   while ((readLastName = sr.ReadLine()) != null)
                   {
                    readFirstName = sr.ReadLine();
                    readEmploymentType = sr.ReadLine();
                    if (readEmploymentType == "S")
                    {
                      readSalaryPay = Convert.ToDouble(sr.ReadLine());
                      employeeList.Add(new SalaryEmployee(readLastName, readFirstName, readEmploymentType, readSalaryPay));
                      //index = index + 1;

                    }
                    else 
                    {
                      readHourlyPay = Convert.ToDouble(sr.ReadLine());
                      employeeList.Add(new HourlyEmployee(readLastName, readFirstName, readEmploymentType, readHourlyPay));
                      //index = index + 1;
                    }
                   }  
                  

                } //stream reader
                foreach (Employee anEmployee in employeeList)
                {
                  Console.WriteLine(anEmployee);
                }
            }

        //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");
                using (StreamWriter sw = new StreamWriter ("employee.txt"))
                {
                  for (int index = 0; index < employeeList.Count; index++)
                  {
                    if (employeeList[index].EmploymentType == "S")
                    {
                    sw.WriteLine(employeeList[index].LastName);
                    sw.WriteLine(employeeList[index].FirstName);
                    sw.WriteLine(employeeList[index].EmploymentType);
                    sw.WriteLine(employeeList[index].SalaryRate);
                    }
                    else 
                    {
                      sw.WriteLine(employeeList[index].LastName);
                      sw.WriteLine(employeeList[index].FirstName);
                      sw.WriteLine(employeeList[index].EmploymentType);
                      sw.WriteLine(employeeList[index].SetRate());
                    }
                  }
                }
            }

        //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
                
                //Prompt for employee last name 
                Console.WriteLine("Please enter the employee's last name.");
                string addLastName = Console.ReadLine();
                
                //Prompt for employee first name
                Console.WriteLine("Please enter the employee's first name.");
                string addFirstName = Console.ReadLine();

                Console.WriteLine("Please enter the employment type for the employee you are adding. S for Salary and H for Hourly.");
                string addEmploymentType = Console.ReadLine();

                if (addEmploymentType == "S")
                {
                  //Prompt for salary wage
                  Console.WriteLine("Please enter the employee's annual Salary wage.");
                  double addSalaryWage = Convert.ToDouble(Console.ReadLine());

                  //Create new Salary Employee object and add to list.
                  employeeList.Add(new SalaryEmployee(addLastName, addFirstName, addEmploymentType, addSalaryWage));
                }
                else 
                {
                  //Prompt for hourly wage
                  Console.WriteLine("Please enter the employee's hourly wage.");
                  double addHourlyWage = Convert.ToDouble(Console.ReadLine());
                  employeeList.Add(new HourlyEmployee(addLastName, addFirstName, addEmploymentType, addHourlyWage));
                }

                Console.WriteLine("The employee has been added to the list.");
                

            }

        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                foreach (Employee anEmployee in employeeList)
                {
                  Console.WriteLine(anEmployee);
                }
            }

        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");

                //This will need to include validation but currently does not
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
      /* foreach (Employee anEmployee in employeeList)
        {
          Console.WriteLine(anEmployee);
        } */
        Console.WriteLine("This employee's info has been updated.");
            }

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");

                //Prompt user to delete an employee from the list 
                Console.WriteLine("Please enter the last name of the employee you want to delete.");
                string deleteLastName = Console.ReadLine();

                Console.WriteLine("Please enter the first name of the employee you want to delete.");
                string deleteFirstName = Console.ReadLine();

                bool employeeFound = false;
                
                for (int index = 0; index < employeeList.Count; index++)
                {
                  if ((employeeList[index].LastName == deleteLastName) && (employeeList[index].FirstName == deleteFirstName))
                  {
                    Console.WriteLine("Are you sure you want to delete this employee from the list? Enter Y for Yes and N for No");
                    string deleteConfirmation = Console.ReadLine();
                    if (deleteConfirmation == "Y")
                    {
                    employeeList.RemoveAt(index);
                    employeeFound = true; // this is important so i can tell them that i found the employee and deleted them.
                    }
                    else 
                    {
                      Console.WriteLine("Employee will not be deleted.");
                    }
                  }
                }
                if (employeeFound == true)
                {
                  Console.WriteLine("Employee was found and deleted from the list.");
                }
                else
                {
                  Console.WriteLine("Employee was not found. No one was deleted.");
                }
            }
        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    }  // end main
  }  // end program
}  // end namespace