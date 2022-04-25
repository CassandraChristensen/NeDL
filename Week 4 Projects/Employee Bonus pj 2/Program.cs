using System;

namespace MyApplication
{
  class Program
  {
      public static int search (string[] arr, string x)
      {
          int n = arr.Length;
          for (int i = 0; i < n; i++)
          {
              if (arr[i] == x)
              return i;
          }
          return -1;
      }
    static void Main(string[] args)
    {

        //Declare my variables
        bool userChoice;
        string userChoiceString;

        //create my array and instantiate each object in the array
        Hourly [] hourlyArray = new Hourly [25];
        /* for (int index = 0; index < hourlyArray.Length; index++)
        {
          hourlyArray[index] = new Hourly();
        } */

        Salary [] salaryArray = new Salary [25];
        /* for (int index = 0; index < salaryArray.Length; index++)
        {
          salaryArray[index] = new Salary();
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
          
            //Create a streamreader so that info may be read from the text file
            using (StreamReader sr = File.OpenText("employee.txt"))
            {
                
                //Since there are two different arrays that i'm cycling through, created two separate indexes to put the objects into the array
                int salaryIndex = 0;
                int hourlyIndex = 0;

                
                string firstName;
                string lastName;
                char employeeType;
                float hourlyPay;
                int salaryPay;
				
                while ((firstName = sr.ReadLine()) != null)  //this ensures that i'm not reading any blank lines. Reading text file into variable which i will then put into object and array
                {
                    
                    lastName = sr.ReadLine();
                    employeeType = Convert.ToChar(sr.ReadLine());


                    if (employeeType == 'H')
                    {
                      hourlyPay = Convert.ToSingle(sr.ReadLine());
                      hourlyArray[hourlyIndex] = new Hourly (hourlyPay, firstName, lastName, employeeType);

                      //Now you can load into the arrays
                      /* hourlyArray[hourlyIndex].FirstName = firstName;
                      hourlyArray[hourlyIndex].setEmployeeLastName(lastName);
                      hourlyArray[hourlyIndex].EmployeeType = employeeType;
                      hourlyArray[hourlyIndex].HourlyPay = hourlyPay; */


                      hourlyIndex = hourlyIndex + 1;
                    }
                    else
                    {
                      salaryPay = Convert.ToInt32(sr.ReadLine());
                      
                      salaryArray[salaryIndex] = new Salary (salaryPay, firstName, lastName, employeeType);
                      //Now load inito the the array
                      /* salaryArray[salaryIndex].FirstName = firstName;
                      salaryArray[salaryIndex].setEmployeeLastName(lastName);
                      salaryArray[salaryIndex].EmployeeType = employeeType;
                      salaryArray[salaryIndex].SalaryPay = salaryPay; */

                      salaryIndex = salaryIndex + 1;
                    }
                    

                    /* salaryArray[index].FirstName = s;
                    salaryArray[index].setEmployeeLastName(s);
                    salaryArray[index].EmployeeType = Convert.ToChar('\u0000');
                    salaryArray[index].SalaryPay = Convert.ToInt32(i); 
                    hourlyArray[index].FirstName = s;
                    hourlyArray[index].setEmployeeLastName(s);
                    hourlyArray[index].EmployeeType = Convert.ToChar(c);
                    hourlyArray[index].HourlyPay = Convert.ToSingle(f);  */ 
                    
                    //index = index + 1;
                }
                    Console.WriteLine(" Here is the content of the file employee.txt : ");
                    Console.WriteLine("");
                    for (int index = 0; index <25; index ++)
                    {
                    Console.WriteLine(hourlyArray[index]);
                    Console.WriteLine(salaryArray[index]);
                    
                    }
                    Console.WriteLine("");

            }

            
            

          }

          //ToDo: Else if the option is S or s then store the employeeArray into the employee.txt file.
          else if (userChoiceString == "S" || userChoiceString == "s")
          {
            Console.WriteLine("In the S/s area");
            using (StreamWriter sw = File.CreateText("employee.txt"))
            {
              //For loop to loop through each line of arrays
              
              for (int index = 0; index < hourlyArray.Length; index++)
              {
                if (!(hourlyArray[index] == null))
                {
                  sw.WriteLine(hourlyArray[index].FirstName);
                  sw.WriteLine(hourlyArray[index].getEmployeeLastName());
                  sw.WriteLine(hourlyArray[index].EmployeeType);
                  sw.WriteLine(hourlyArray[index].HourlyPay);
                }

                if (!(salaryArray[index]==null))
                {
                  sw.WriteLine(salaryArray[index].FirstName);
                  sw.WriteLine(salaryArray[index].getEmployeeLastName());
                  sw.WriteLine(salaryArray[index].EmployeeType);
                  sw.WriteLine(salaryArray[index].SalaryPay);
                }
              }
              


            }
          }

          //ToDo: Else if the option is C or c then add an employee to the array (if there's room)
          else if (userChoiceString == "C" || userChoiceString == "c")
          {
            Console.WriteLine("in the C/c area.");
            string addFirstName = "";
            string addLastName = "";
            char addEmployeeStatus = '\0';
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
              for (int index = 0; index < hourlyArray.Length; index++)
              {
                if ((hourlyArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  hourlyArray[index] = new Hourly (addHourlyPay, addFirstName, addLastName, addEmployeeStatus);
                  //hourlyArray[index].FirstName = addFirstName;
                  //hourlyArray[index].setEmployeeLastName(addLastName);
                  //hourlyArray[index].EmployeeType = addEmployeeStatus;
                  //hourlyArray[index].HourlyPay = addHourlyPay;
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
              for (int index = 0; index < salaryArray.Length; index++)
              {
                if ((salaryArray[index] == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  salaryArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  //salaryArray[index].FirstName = addFirstName;
                  //salaryArray[index].setEmployeeLastName(addLastName);
                  //salaryArray[index].EmployeeType = addEmployeeStatus;
                  //salaryArray[index].SalaryPay = addSalaryPay;
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
                Console.WriteLine("");

                for (int index = 0; index < salaryArray.Length; index++)
                {
                  if (!(salaryArray[index]==null))  //since each space in the ray does not have an object instantiated in it, i'm checking to see if the index of the array is null
                    Console.WriteLine(salaryArray[index]);  //not checking to see if the variable/field of the object etc is null.
                    
                }

                for (int index = 0; index < hourlyArray.Length; index++)
                {
                  if (!(hourlyArray[index]==null))
                    Console.WriteLine(hourlyArray[index]);
                }
                Console.WriteLine("");
            }
        //  ToDo: Else if the option is a U or u then update information for an employee in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");

                
                

                //Prompt the user for the employee they wish to update
                Console.WriteLine("Please enter the last name of the employee that you would like to update information for. ");
                string updateEmployeeLastName = Console.ReadLine();

                bool lastNameFound = false;

                Console.WriteLine("Please enter the first name of the employee that you would like to update information for. ");
                string updateEmployeeFirstName = Console.ReadLine();

                bool employeeFound = false; 

                //Create a for loop to see if the employee is found in the array 
                int[] arr = { 2, 3, 4, 10, 40 };
                int x = 10;
 
                // Function call
                int result = search(arr, x);
                if (result == -1)
                 Console.WriteLine(
                "Element is not present in array");
                else
                 Console.WriteLine("Element is present at index " + result);

                for (int index = 0; index < 25; index++)
                {
                    if (salaryArray[index].FirstName == updateEmployeeLastName)
                    {
                        employeeFound = true;
                        
                        Console.WriteLine("Please enter the number for what you wish to update: 1: First Name, 2: Last Name, 3: Employment Status, 4: Hourly Pay or 5: Salary Pay ");
                        int updateOption = Convert.ToInt32(Console.ReadLine());

                        switch (updateOption)
                        {
                            case 1: 
                                Console.WriteLine("What do you wish to update the employee's first name to? ");
                                string updateFirstName = Console.ReadLine();
                                break;
                            case 2: 
                                Console.WriteLine("What do you wish to update the employee's last name to?");
                                string updateLastName = Console.ReadLine();
                                break;
                            case 3: 
                                Console.WriteLine("What do you wish to update the employee's employment status to? H for Hourly and S for Salary");
                                char updateEmploymentStatus = Convert.ToChar(Console.ReadLine());
                                if (updateEmploymentStatus == 'H')
                                {
                                    Console.WriteLine("What is the employee's Hourly Pay?");
                                    float updateHourlyPay = Convert.ToSingle(Console.ReadLine());
                                }
                                else 
                                {
                                    Console.WriteLine("What is the employee's Salary Pay?");
                                    int updateSalaryPay = Convert.ToInt32(Console.ReadLine());
                                }

                                break;

                            case 4: 
                                Console.WriteLine("What would you like to update the employee's Hourly Pay to?");
                                float updateHourlyPay2 = Convert.ToSingle(Console.ReadLine());
                                break;
                            
                            case 5:
                                Console.WriteLine("What is the employee's Salary Pay?");
                                int updateSalaryPay2 = Convert.ToInt32(Console.ReadLine());
                                break;

                        } //switch
                    } //if
                    else if ((hourlyArray[index].getEmployeeLastName() == updateEmployeeLastName) && employeeFound == false)
                    {
                        employeeFound = true;
                        Console.WriteLine("Please enter the number for what you wish to update: 1: First Name, 2: Last Name, 3: Employment Status, 4: Hourly Pay or 5: Salary Pay ");
                        int updateOption = Convert.ToInt32(Console.ReadLine());

                        switch (updateOption)
                        {
                            case 1: 
                                Console.WriteLine("What do you wish to update the employee's first name to? ");
                                string updateFirstName = Console.ReadLine();
                                break;
                            case 2: 
                                Console.WriteLine("What do you wish to update the employee's last name to?");
                                string updateLastName = Console.ReadLine();
                                break;
                            case 3: 
                                Console.WriteLine("What do you wish to update the employee's employment status to? H for Hourly and S for Salary");
                                char updateEmploymentStatus = Convert.ToChar(Console.ReadLine());
                                if (updateEmploymentStatus == 'H')
                                {
                                    Console.WriteLine("What is the employee's Hourly Pay?");
                                    float updateHourlyPay = Convert.ToSingle(Console.ReadLine());
                                }
                                else 
                                {
                                    Console.WriteLine("What is the employee's Salary Pay?");
                                    int updateSalaryPay = Convert.ToInt32(Console.ReadLine());
                                }

                                break;

                            case 4: 
                                Console.WriteLine("What would you like to update the employee's Hourly Pay to?");
                                float updateHourlyPay2 = Convert.ToSingle(Console.ReadLine());
                                break;
                            
                            case 5:
                                Console.WriteLine("What is the employee's Salary Pay?");
                                int updateSalaryPay2 = Convert.ToInt32(Console.ReadLine());
                                break;
                        } //switch
                    } //else if
            }// for
                if (employeeFound == true)
                {
                    Console.WriteLine("This information has been updated for you.");
                }
                else
                {
                    Console.WriteLine("Employee was not found."); 
                }
            }// else if

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
