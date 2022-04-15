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
          string [] restaurantName = new string [25];  //Creating memory space to hold 25 strings for the restaurant names
          int [] restaurantRating = new int [25];      //create memory space to hold 25 ints for the ratings 

     //Repeat main loop 
        do
        {
         
          //To Do: Get a valid input 
            do
            {
                //Initial variable 
                userChoice = false;
                //To Do: Provide the user a menu of options 

                Console.WriteLine("How can I assist you today?");
                Console.WriteLine("L: Load the data file into arrays.");
                Console.WriteLine("S: Save the arrays to the data file.");
                Console.WriteLine("C: Add a restaurant name and rating to the arrays.");
                Console.WriteLine("R: Read a restaurant name and rating from the arrays.");
                Console.WriteLine("U: Update a restaurant name and rating in the arrays.");
                Console.WriteLine("D: Delete a restaurant name and rating from the arrays.");
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

                //Create streamreader so that info may be read from the txt file
                StreamReader sr = new StreamReader(@"restaurant.txt");
                
                //Load the data into the arrays from the text file
                for (int i = 0; i < restaurantName.Length; i++)
                {
                    restaurantName[i] = sr.ReadLine();  //Loading Restaurant names into it string array
                    restaurantRating[i] = Convert.ToInt32(sr.ReadLine());  //Loading Ratings into integer array
                }
                sr.Close();
                
                Console.WriteLine("Restaurant Names and their Ratings");  //This outputs the info to the console, just verifying that the info was loaded into the individual arrays
                for (int i = 0; i < restaurantName.Length; i++)
                {   
                    Console.WriteLine(restaurantName[i]);
                    Console.WriteLine(restaurantRating[i]);
                }
                sr.Close();
            }

         //To Do: Else if the option is an S or s then store the array of strings into the text file 
            
            else if (userChoiceString=="S" || userChoiceString=="s")  
            {
                Console.WriteLine("In the S/s area");
            }

         //To Do: Else if the options is a C or c then add a name to the array of strings (if there's room)
            
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
            }

         //To Do: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")   //Alec did this one in class, must stay the same.
            {
                int index= 0;
                string myRating = Convert.ToString(restaurantRating[index]);
                Console.WriteLine("In the R/r area");
                //Print a list of the restaurants and their ratings. 
                //NO BLANK LINES IN THE LIST (or zero's... for the integer array)
                for (index = 0; index < restaurantName.Length; index ++)
                {
                    string myIndex = Convert.ToString(index);
                    if (!string.IsNullOrEmpty(restaurantName[index]))  
                    {
                    Console.WriteLine(restaurantName[index]);
                    }
                    if (!string.IsNullOrEmpty(myRating[index]))
                    {
                        Console.WriteLine(restaurantRating[index]);
                    }
                }

            }

         //To Do: Else if the option is a U or u then update a name in the array (if it's there)
            
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

         //To Do: Else if the option is a D or d then delete the name in the array (if it's there)  Get from the user a name, if it's there, change to a blank, then go and read it but without the name, then make sure save and read still have name removed.

            else if (userChoiceString=="D" || userChoiceString=="d")
            {   
                Console.WriteLine("In the D/d area");
            }

         //To Do: Else if the option is a Q or q then quit the program 
            else 
            {
                Console.WriteLine("Goodbye!");
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
//this is a test