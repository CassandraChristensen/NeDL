using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {   
        //Declare variables 
          bool userChoice;
          string userChoiceString;
          string [] nameArray = new string [10];  //Creating memory space to hold 10 strings

     //Repeat main loop 
        do
        {
         
          //To Do: Get a valid input 
            do
            {
                //Initial variable 
                userChoice = false;
                //To Do: Provide the user a menu of options 

                Console.WriteLine("What's your pleasure?");
                Console.WriteLine("L: Load the data file into an array.");
                Console.WriteLine("S: Save the array to the data file.");
                Console.WriteLine("C: Add a name to the array.");
                Console.WriteLine("R: Read a name from the array.");
                Console.WriteLine("U: Update a name in the array.");
                Console.WriteLine("D: Delete a name from the array.");
                Console.WriteLine("Q: Quit the program.");
            //To Do: Get a valid user option (valid = it's on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                                userChoiceString=="S" || userChoiceString=="s" ||
                                userChoiceString=="C" || userChoiceString=="c" ||
                                userChoiceString=="R" || userChoiceString=="r" ||
                                userChoiceString=="U" || userChoiceString=="u" ||
                                userChoiceString=="D" || userChoiceString=="d" ||
                                userChoiceString=="Q" || userChoiceString=="q");

                if(!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                } 

            } while (!userChoice);

         //To Do: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")   //Alec did this one in class, must stay the same
            {
                Console.WriteLine("In the L/l area");
                int index = 0; // index for my array 
                using (StreamReader sr = File.OpenText("names.txt"))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file names.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        nameArray[index] = s;
                        index = index + 1;
                    }
                }
            }

         //To Do: Else if the option is an S or s then store the array of strings into the text file 
            
            else if (userChoiceString=="S" || userChoiceString=="s")  
            {
                Console.WriteLine("In the S/s area");

                //Using StreamWriter to write text to my text file
                StreamWriter SW = new StreamWriter(@"names.txt");
                //For loop to write each line of my array
                for (int index =0; index < nameArray.Length; index++)
                {
                    SW.WriteLine(nameArray[index]);
                }
                SW.Close(); 
                Console.WriteLine("This has been saved.");
            }

         //To Do: Else if the options is a C or c then add a name to the array of strings (if there's room)
            
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");

                //Prompt user to enter the name they wish to add
                Console.WriteLine("Please enter the name you wish to add.");
                string addName = Console.ReadLine();

                bool found = false;
                for (int index = 0; index < nameArray.Length; index++)
               {
                    if ((nameArray[index] == " " || nameArray[index] == null) && found == false)
                    {
                        Console.WriteLine("There is space, name will be added.");
                        nameArray[index] = addName;
                        found = true;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("Array is full. Name will not be added.");
                }
            }

         //To Do: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")   //Alec did this one in class, must stay the same.
            {
                Console.WriteLine("In the R/r area");
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(nameArray[index]);
                }
            }

         //To Do: Else if the option is a U or u then update a name in the array (if it's there)
            
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
                
                //Prompt the user for a name they wish to update
                Console.WriteLine("Please enter the name you wish to update.");
                string update = Console.ReadLine();
                bool contains = false;

                //Create a for loop to see if the name user enter was found in nameAarray
                for (int index = 0; index < nameArray.Length; index++)
                {
                    if (nameArray[index] == update)
                    {
                        contains = true;
                        Console.WriteLine("What do you wish to update the name to");
                        string newName = Console.ReadLine();
                        nameArray[index] = newName;
                    }
                }
                if (contains == true)
                    {
                        Console.WriteLine("This name has been updated for you.");
                    }
                    else
                    {
                        Console.WriteLine("The name you entered was not found, and therefore will not be updated.");
                    }
            }

         //To Do: Else if the option is a D or d then delete the name in the array (if it's there)  Get from the user a name, if it's there, change to a blank, then go and read it but without the name, then make sure save and read still have name removed.

            else if (userChoiceString=="D" || userChoiceString=="d")
            {   
                Console.WriteLine("In the D/d area");
                
                //Prompt the user to enter a name they wish to delete
                Console.WriteLine("Pleae enter a name you wish to delete.");
                string delete = Console.ReadLine();

                bool? contains = null;
                
                //Create a for loop to see if the name the user entered is found in nameArray
                for (int index = 0; index < nameArray.Length; index++)
                {   
                    
                    //Console.WriteLine(nameArray[index]);
                    if  (nameArray[index] == delete)  //If Found
                    {
                        contains = true;
                        nameArray[index] = " ";
                    }
                }
                if (contains == true) //output this to confirm it was found
                {
                    Console.WriteLine("Valid name, this will be deleted.");
                        
                }
                else //output this to confirm it was not found
                {
                    Console.WriteLine("The name entered was not found and will not be deleted.");
                }
            }

         //To Do: Else if the option is a Q or q then quit the program 
            else 
            {
                Console.WriteLine("Goodbye");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString =="q"));

    } //end mainMethod bracket
  } //end program bracket
}  //end namespace bracket


//Load *should* be working already 
//Print (R) to the console. 
//Delete a name. Prompt user for name, go through array with for loop, anywhere i see it, change it to be a blank. 
//Then use the R option to print out the array 
//Then do the S to save it back to the disc
//Get a new name from user, everywhere you see that name in the loop, update it. 


//Load File
//Delete from file
//Update file
//Must Save to update the data file 
//Stop then run again, file should be same as last save