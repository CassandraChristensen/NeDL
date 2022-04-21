using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

        //Declare my variables
        bool userChoice;
        string userChoiceString;
        Employee [] employeeArray = new Employee[25];

        /* Employee [] employeeArray = new Employee [25];

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
        employeeArray[1] = testEmployee;
        employeeArray[2] = testHourly;
        employeeArray[3] = testSalary;
        employeeArray[4] = new Salary( 55000, "Zac", "Champoux", 'S');
        employeeArray[0] = new Hourly( 15.50F, "Trace", "Jensen", 'H');

        for (int index = 0; index < employeeArray.Length; index++)
        {
        Console.WriteLine(employeeArray[index]);
        } */

        //Repeat main loop while the users choice does not equal Q or q
        do 
        {

          //TODO: Get a valid input
          do
          {

            //initialize my bool variable
            userChoice = false;

            //TODO: Provide the user a menu of options:
            Console.WriteLine("How many I help you today?");
            Console.WriteLine("L: Load the employee data file into an array.");
            Console.WriteLine("S: Save the array to the employee data file.");
            Console.WriteLine("C: Add an employee to the array.");
            Console.WriteLine("R: Read employee information from the array.");
            Console.WriteLine("U: Update employee information in the array.");
            Console.WriteLine("D: Delete an employee from the array.");
            Console.WriteLine("Q: Quit the program.");

            //TODO: Get a user option (valid means it's on the menu)

            userChoiceString = Console.ReadLine();

            userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
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

          }while (!userChoice);


          //ToDo: If the option is L or l then load the employee text file (employee.txt) into the array of strings (employeeArray)
          if (userChoiceString == "L" || userChoiceString == "l")
          {
            Console.WriteLine("In the L/l area");
          }

          //ToDo: Else if the option is S or s then store the employeeArray into the employee.txt file.
          else if (userChoiceString == "S" || userChoiceString == "s")
          {
            Console.WriteLine("In the S/s area");
          }

          //ToDo: Else if the option is C or c then add an employee to the array (if there's room)
          else if (userChoiceString == "C" || userChoiceString == "c")
          {
            Console.WriteLine("in the C/c area.");
            string addFirstName = "";
            string addLastName = "";
            char addEmployeeStatus = '\u0000';
            float addHourlyPay = 0.00F;
            int addSalaryPay = 0;

            //Prompt the user for the employees First Name
            do 
            {
              Console.WriteLine("Please enter the employees First Name.");
              addFirstName = Console.ReadLine();
              if (addFirstName == "")
              {
                Console.WriteLine("Entry was not valid, please enter the employees first name.");
              }  
            } while (addFirstName == "");


            //Prompt the user to enter an employee last name 
            do
            {
              Console.WriteLine("Please enter the employee's Last Name.");
              addLastName = Console.ReadLine();
              if (addLastName == "")
              {
                Console.WriteLine("Entry was not valid, please enter the employee's last name.");
              } 
            } while (addLastName == "");


            //Prompt the user for the employees employment status
            do
            {
              Console.WriteLine("Please enter in an H if the employee is Hourly and an S if the employee is salary.");
              addEmployeeStatus = Convert.ToChar(Console.ReadLine());
              if (addEmployeeStatus != 'H' && addEmployeeStatus != 'S')
              {
                Console.WriteLine("Entry was not valid, please enter the employee's employment status.");
              }
            } while (addEmployeeStatus != 'H' && addEmployeeStatus != 'S');

            
            //Prompt the user for the employee's wage
            if (addEmployeeStatus == 'H' || addEmployeeStatus == 'h')
            {
              do
              {

                Console.WriteLine("Please enter the hourly pay for the employee.");
                addHourlyPay = float.Parse(Console.ReadLine());
                Console.WriteLine(addHourlyPay);
                if (addHourlyPay < -1F || addHourlyPay > 1000F)
                {
                  Console.WriteLine("Entry was not valid, please enter the employee's hourly pay.");
                }

              }while (addHourlyPay < -1F || addHourlyPay > 1000F);
  
            }

            else 
            {
              do
              {
                Console.WriteLine("Please enter the salary pay for the employee.");
                addSalaryPay = Convert.ToInt32(Console.ReadLine());
                if (addSalaryPay < -1 || addSalaryPay > 10000000)
                {
                  Console.WriteLine("Entry was not valid, please enter the employee's hourly pay.");
                }
              } while (addSalaryPay < -1 || addSalaryPay > 10000000);
            }
            
            
            if (addEmployeeStatus == 'H')
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < employeeArray.Length; index++)
              {
                if ((employeeArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  employeeArray[index] = new Hourly (addHourlyPay, addFirstName, addLastName, addEmployeeStatus);
                  //employeeArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee array is full. Employee information will not be added.");
              } 
            }
            else 
            {
              bool employeeSpaceFound = false;
              for (int index = 0; index < employeeArray.Length; index++)
              {
                if ((employeeArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  employeeArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  employeeSpaceFound = true;

                }
              }
              if (employeeSpaceFound == false)
              {
                Console.WriteLine("Employee array is full. Employee information will not be added.");
              } 
            }






          }

          //ToDo: Else if the option is an R or r then print a list of all of the employees including their calculated bonus.

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                for (int index = 0; index < employeeArray.Length; index++)
                {
                  if (!(employeeArray[index]==null))
                  Console.WriteLine(employeeArray[index]);
                }

            }
        //  ToDo: Else if the option is a U or u then update information for an employee in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            }
        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Goodbye");
            }



        } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));


        
      
        
        

        


        } //main
  } // program class
} //namespace

