using System;

namespace MyApplication
{
  class Program
  {
    static int GetValidIntMethod (int lowRange, int highRange)
    {
        int value;
        do
        {
            Console.WriteLine("Please enter a number between " + lowRange + " and " + highRange);
            value = Convert.ToInt16(Console.ReadLine());
        }
        while (value < lowRange || value > highRange);
        return value;
    }
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
                
                //Create streamwriter. Since "using" do not need to open/close, "using" does that for you.
                using (StreamWriter SW = File.CreateText("restaurant.txt"))
                {
                    //For loop to loop through each line of arrays
                    for (int index = 0; index < 25; index++)
                    {
                        //If statement to make sure not saving any blank lines
                        if (!string.IsNullOrEmpty(restaurantName[index]))
                        {
                            SW.WriteLine(restaurantName[index]);
                        }

                        //If statement to make sure not saving any blank lines
                        if (restaurantRating[index] != 0)
                        {
                            SW.WriteLine(restaurantRating[index]);
                        }
                    }
                }
                //Output message to user notifying them that the file has been saved.
                Console.WriteLine("The File has been saved.");
            }

         //To Do: Else if the options is a C or c then add a name to the array of strings (if there's room)
            
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                string addRestaurant = "";
                int addRating = 0;
                
                    Console.WriteLine("In the C/c area");
                    //Prompt the user to add a Restaurant 
                    //Validate that they are entering a restaurant

                    do
                    {
                        Console.WriteLine("Please enter a restaurant name.");
                        addRestaurant = Console.ReadLine();
                        if (addRestaurant == "")
                            {
                              Console.WriteLine("Entry was not valid, please enter a restaurant name.");
                            }
                    }
                    while (addRestaurant == "");
            
                    
                    

                    bool spaceFound = false;
                    for (int index = 0; index < 25; index++)
                    {
                        if ((restaurantName[index] == "" || restaurantName[index] == null) && spaceFound == false)
                        {
                            Console.WriteLine("There is space, name will be added.");
                            restaurantName[index] = addRestaurant;
                            spaceFound = true;
                        }
                    }
                    if (spaceFound == false)
                    {
                        Console.WriteLine("Array is full. The Restaraunt Name will not be added. ");
                    }
                    //Prompt the user to add a Rating 
                    //Validate that they are entering a rating and that the rating is between 1-5. Use GetValidIntMethod
                    
                        Console.WriteLine("Please enter a rating for the restaurant you just entered.");
                        addRating = GetValidIntMethod(1,5);
                    

                    bool spaceFound2 = false;
                    for (int index = 0; index < 25; index++)
                    {
                        if ((restaurantRating[index] == 0) && spaceFound2 == false)
                        {
                            Console.WriteLine("Rating will be added.");
                            restaurantRating[index] = addRating;
                            spaceFound2 = true;
                        }
                    }
               // } while (addRestaurant != aString || addRating != integer);
            }

         //To Do: Else if the option is an R or r then read a name from the array (if it's there)

            else if (userChoiceString=="R" || userChoiceString=="r")   //Alec did this one in class, must stay the same.
            {
                int index= 0;
                Console.WriteLine("In the R/r area");

                //Print a list of the restaurants and their ratings. 
                //NO BLANK LINES IN THE LIST (or zero's... for the integer array)
                for (index = 0; index < 25; index ++)
                {
                    //if statement to make sure that blank lines aren't printing for the restaurant name
                    if (!string.IsNullOrEmpty(restaurantName[index]))  
                    {
                        Console.WriteLine(restaurantName[index]);
                    }
                    //if statement to make sure that 0 lines aren't printing for the restaurant rating 
                    if (restaurantRating[index] != 0)
                    {
                        Console.WriteLine(restaurantRating[index]);
                    }
                }
            }

         //To Do: Else if the option is a U or u then update a name in the array (if it's there)
            
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");

                //Prompt the user for which restaurant they want to update the rating for 
                Console.WriteLine("Please enter the name of the restaurant that you wish to update the rating for.");
                string updateRestaurant = Console.ReadLine();

                bool restaurantFound = false;

                //Create a for loop to see if the restaurants name is found in the array 
                for (int index = 0; index < restaurantName.Length; index++)
                {
                    if (restaurantName[index] == updateRestaurant)
                    {   
                        restaurantFound = true;  //Restaurant was Found, raise flag for bool. 
                        Console.WriteLine("What do you wish to update the rating to");  //Prompt for new rating
                        int updateRating = Convert.ToInt32(Console.ReadLine());
                        restaurantRating[index] = updateRating;
                    }
                }
                if (restaurantFound == true) //output message acknowledging restaurant was found and rating updated
                {
                    Console.WriteLine("This rating has been updated for you.");
                }
                else //outputting error message
                {
                    Console.WriteLine("The name you entered was not found, and therefore will not be updated.");
                }
            }

         //To Do: Else if the option is a D or d then delete the name in the array (if it's there)  Get from the user a name, if it's there, change to a blank, then go and read it but without the name, then make sure save and read still have name removed.

            else if (userChoiceString=="D" || userChoiceString=="d")
            {   
                Console.WriteLine("In the D/d area");

                //Prompt the user to enter the name they wish to delete
                Console.WriteLine("Please enter the restaurant you wish to delete.");
                string deleteRestaurant = Console.ReadLine();

                bool restaurantFound = false;
                //Create a for loop to make sure that the restaurant is found.
                for (int index = 0; index < restaurantName.Length; index++)
                {
                    if (restaurantName[index] == deleteRestaurant)
                    {
                        restaurantFound = true;
                        restaurantName[index] = "";
                        restaurantRating[index] = 0;
                    }
                }
                if (restaurantFound == true)
                {
                    Console.WriteLine("This restaurant will be deleted.");
                }
                else 
                {
                    Console.WriteLine("The restaruant name that was entered was not found and therefore will not be deleted.");
                }

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