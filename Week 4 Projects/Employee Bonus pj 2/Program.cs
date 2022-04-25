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

        //create my array and instantiate each object in the array
        Hourly [] hourlyArray = new Hourly [25];
        for (int index = 0; index < hourlyArray.Length; index++)
        {
          hourlyArray[index] = new Hourly();
        }

        Salary [] salaryArray = new Salary [25];
        for (int index = 0; index < salaryArray.Length; index++)
        {
          salaryArray[index] = new Salary();
        }

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

                      //Now you can load into the arrays
                      hourlyArray[hourlyIndex].FirstName = firstName;
                      hourlyArray[hourlyIndex].setEmployeeLastName(lastName);
                      hourlyArray[hourlyIndex].EmployeeType = employeeType;
                      hourlyArray[hourlyIndex].HourlyPay = hourlyPay;

                      hourlyIndex = hourlyIndex + 1;
                    }
                    else
                    {
                      salaryPay = Convert.ToInt32(sr.ReadLine());
                      

                      //Now load inito the the array
                      salaryArray[salaryIndex].FirstName = firstName;
                      salaryArray[salaryIndex].setEmployeeLastName(lastName);
                      salaryArray[salaryIndex].EmployeeType = employeeType;
                      salaryArray[salaryIndex].SalaryPay = salaryPay;

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
                if (!(((hourlyArray[index]).getEmployeeLastName())==null))
                {
                  sw.WriteLine(hourlyArray[index].FirstName);
                  sw.WriteLine(hourlyArray[index].getEmployeeLastName());
                  sw.WriteLine(hourlyArray[index].EmployeeType);
                  sw.WriteLine(hourlyArray[index].HourlyPay);
                }

                if (!(((salaryArray[index]).getEmployeeLastName())==null))
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
                if ((hourlyArray[index].getEmployeeLastName() == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  //hourlyArray[index] = new Hourly (addHourlyPay, addFirstName, addLastName, addEmployeeStatus);
                  hourlyArray[index].FirstName = addFirstName;
                  hourlyArray[index].setEmployeeLastName(addLastName);
                  hourlyArray[index].EmployeeType = addEmployeeStatus;
                  hourlyArray[index].HourlyPay = addHourlyPay;
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
                if ((salaryArray[index].getEmployeeLastName() == null) && employeeSpaceFound == false)
                {
                  Console.WriteLine("There is space. The employee will be added.");
                  //salaryArray[index] = new Salary (addSalaryPay, addFirstName, addLastName, addEmployeeStatus);
                  salaryArray[index].FirstName = addFirstName;
                  salaryArray[index].setEmployeeLastName(addLastName);
                  salaryArray[index].EmployeeType = addEmployeeStatus;
                  salaryArray[index].SalaryPay = addSalaryPay;
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
                  if (!(((salaryArray[index]).getEmployeeLastName())==null))
                    Console.WriteLine(salaryArray[index]);
                }

                for (int index = 0; index < hourlyArray.Length; index++)
                {
                  if (!(((hourlyArray[index]).getEmployeeLastName())==null))
                    Console.WriteLine(hourlyArray[index]);
                }
                Console.WriteLine("");
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
