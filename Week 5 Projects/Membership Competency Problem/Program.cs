using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
     
    
    static void Main(string[] args)
    {
        //Create my list 
        List<BaseMembership> membershipList = new List<BaseMembership>();

        //Hardcode data in
        membershipList.Add(new RegularMembership(5263, "janedoe@gmail.com", "Regular Membership", 79.99, 1200, .01));
        membershipList.Add(new ExecutiveMembership(6587, "johndoe@gmail.com", "Executive Membership", 150, 989, .01, .03));
        membershipList.Add(new NonprofitMembership(2498, "luna@gmail.com", "Non-profit Membership", 45, 1000, .02, false));
        membershipList.Add(new CorporateMembership(7152, "sookie@gmail.com", "Corporate Membership", 129.99, 500, .02));

        /* //Read
        foreach (BaseMembership aMember in membershipList)
        {
            Console.WriteLine(aMember);
            Console.WriteLine("");
        } */

        //Declare my variables
        bool userChoice;
        string userChoiceString;

      //CRUD APP
        //Create my do Loop that will go through all options for the user menu
        do 
        {
            //Create a small do loop to do validation and get a valid input from user
            do 
            {
                //initial the bool variable 
                userChoice = false;

                //To Do: Provide my user menu: 
                Console.WriteLine("Welcome to your Membership Services! Please choose from the following options: ");
                Console.WriteLine("C: Create a new membership and add to the membership list.");
                Console.WriteLine("R: Read all of the memberships in the membership list.");
                Console.WriteLine("U: Update an existing membership based on membership ID.");
                Console.WriteLine("D:  Delete an existing membership based on membership ID.");
                Console.WriteLine("L: List all of the memberships in the list including all of the information for each account type.");
                Console.WriteLine("P: Perform a purchase transaction.");
                Console.WriteLine("T: Perform a return transaction. ");
                Console.WriteLine("A: Apply cash-back rewards.");
                Console.WriteLine("Q: Quit the transaction processing.");

                //To Do: Get a valid user option 
                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString == "C" || userChoiceString == "c" ||
                            userChoiceString == "R" || userChoiceString == "r" ||
                            userChoiceString == "U" || userChoiceString == "u" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "L" || userChoiceString == "l" ||
                            userChoiceString == "P" || userChoiceString == "p" ||
                            userChoiceString == "T" || userChoiceString == "t" ||
                            userChoiceString == "A" || userChoiceString == "a" ||
                            userChoiceString == "Q" || userChoiceString == "q" );

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

            //To do: If the option is C or c, then Create a new membership and add to the membership list. Be sure no duplicate membershipID, must be unique. 
            if (userChoiceString == "C" || userChoiceString == "c")
            {
                Console.WriteLine("In the C area");
                
                /* int createMemberID;

                bool findMemberID = true;
                //validate username 
                for (int index = 0; index < membershipList.Count; index++)
                {
                    do 
                    {
                        Console.WriteLine("Please create a unique MemberID.");
                        createMemberID = Convert.ToInt32(Console.ReadLine());

                        
                        if (membershipList[index].MembershipID != createMemberID)
                        {
                            findMemberID = false;
                            Console.WriteLine("This is not a unique ID");
                        }
                        else
                        {
                            Console.WriteLine("This is a unique ID");
                            
                        }

                    } while (findMemberID == true);
                } */
               //create variables

            } //if else

            //To do: If the option is R or r, then read all of the members in the list. 
            else if (userChoiceString == "R" || userChoiceString == "r")
            {
                Console.WriteLine("In the R area");
                foreach (BaseMembership aMember in membershipList)
                {
                    Console.WriteLine(aMember);
                    Console.WriteLine("");
                }
            }

            //To do: If the option is U or u, then update an existing membership based on membershipID
            else if (userChoiceString == "U" || userChoiceString == "u")
            {
                Console.WriteLine("In the U area");
                
                //create variables
                bool memberIDFound = false;

                //Prompt for the membershipID and then validate to make sure that there is one. 
                
                Console.WriteLine("Please enter in your membershipID");
                int findMemberID = Convert.ToInt32(Console.ReadLine());

                //using a for loop to "search" for the memberID.
                for (int index = 0; index < membershipList.Count; index ++ )  
                {
                    if (membershipList[index].MembershipID == findMemberID)
                    {
                        memberIDFound = true;

                        //Prompt the user for what they would like to update.
                        Console.WriteLine("What would you like to update? Please enter the number for the field you would like to update.");
                        Console.WriteLine("1: Email Address");
                        Console.WriteLine("2: Annual Cost");
                        Console.WriteLine("3: Monthly Purchase Balance");
                        int userUpdateAnswer = Convert.ToInt32(Console.ReadLine());

                        //Update variables. Creating these so i may do validation on the user answers. 
                        string updateEmail = "";
                        double updateAnnualcost = 0.0;
                        double updatePurchaseBalance = 0.0;
                        switch (userUpdateAnswer)
                        {
                            case 1: 
                                do 
                                {
                                    Console.WriteLine("What do you want to update your email address to?");
                                    updateEmail = Console.ReadLine();
                                    if (updateEmail != "")
                                        {
                                        membershipList[index].MemberEmailAddress = updateEmail;
                                        }
                                    else 
                                    {
                                        Console.WriteLine("Invalid entry.");
                                    }
                                } while (updateEmail == "");
                            break;

                            case 2:
                                do
                                {
                                    Console.WriteLine("What do you want to update your annual cost to?");
                                    updateAnnualcost = Convert.ToDouble(Console.ReadLine());
                                    if (updateAnnualcost >= 0)
                                    {
                                        membershipList[index].AnnualCost = updateAnnualcost; 
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Invalid entry. Please enter a number greater than or equal to zero.");
                                    }

                                } while (updateAnnualcost < 0 );
                                break; 

                            case 3:
                            do
                            {
                                Console.WriteLine("What do you want to update your monthly purchase balance to? ");
                                updatePurchaseBalance = Convert.ToDouble(Console.ReadLine());
                                if ( updatePurchaseBalance >= 0)
                                {
                                    membershipList[index].CurrentPurchaseBalance = updatePurchaseBalance;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a number greater than zero.");
                                }
                            } while (updatePurchaseBalance < 0);
                            break;
                        }
                        
                    }
                }
                if (memberIDFound == true)
                {
                    Console.WriteLine("MemberID was found and information has been updated for you.");
                }
                else 
                {
                    Console.WriteLine("MemberID was not found. Nothing was updated.");
                }


            }

            //To do: If the option is D or d, then delete an existing membership based on membershipID
            else if (userChoiceString == "D" || userChoiceString == "d")
            {
                Console.WriteLine("In the D area");

                //create variables
                bool memberIDFound = false;

                //Prompt for the membershipID and then validate to make sure that there is one. 
                
                Console.WriteLine("Please enter in the membershipID that you wish to delete");
                int findMemberID = Convert.ToInt32(Console.ReadLine());

                //using a for loop to "search" for the memberID.
                
                for (int index = 0; index < membershipList.Count; index ++ )  
                {
                    if (membershipList[index].MembershipID == findMemberID)
                    {
                        
                        Console.WriteLine("Are you sure you want to delete this membership? Yes or No?");
                        string deleteAnswer = Console.ReadLine();
                        if (deleteAnswer == "Yes")
                        {
                            memberIDFound = true;
                            membershipList.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("MemberID was found, however will not be deleted.");
                        }

                    }
                }
                if (memberIDFound == true)
                {
                    Console.WriteLine("MemberID was found and has been deleted.");
                }
                else 
                {
                    Console.WriteLine("MemberID was not found. Nothing was deleted.");
                }
            }

            //To do: If the option is L or l, then list all of the memberships in the list including info for each account type
            else if (userChoiceString == "L" || userChoiceString == "l")
            {
                Console.WriteLine("In the L area");
                foreach (BaseMembership aMember in membershipList)
                {
                    Console.WriteLine(aMember);
                    Console.WriteLine("");
                }
            }

            //To do: If the option is P or p, then perform a purchase transaction by getting a membership number from the user, and a purchase amount. 
            //If the membership exists add the purchase amount to the monthly purchase total. 
            else if (userChoiceString == "P" || userChoiceString == "p")
            {
                Console.WriteLine("In the P area");
            }

            //To do: If the option is T or t, then perform a return transaction by getting a membership number from the user, and a return amount. 
            //If the membership exists then subtract the return from the monthly purchase total. 
            else if (userChoiceString == "T" || userChoiceString == "t")
            {
                Console.WriteLine("In the T area");
            }

            //To do: If the option is A or a, apply cash-back rewards as described by getting a membership number 
            else if (userChoiceString == "A" || userChoiceString == "a")
            {
                Console.WriteLine("In the A area");
            }

            //To do: If none of the above, then Quit. 
            else 
            {
                Console.WriteLine("Thank you for using our member services! Have a great day!");
            }
        } while (!(userChoiceString == "Q" || userChoiceString == "q"));

    }
  }
}

