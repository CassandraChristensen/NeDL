using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
      static double GetValidDouble (double lowValue)
      {
          double value;
          do
          { 
          Console.WriteLine("please enter an amount greater than: " + lowValue);
          value = Convert.ToDouble(Console.ReadLine());
          } while (lowValue > value);
          return value;
      }
     
    
    static void Main(string[] args)
    {
        //Create my list 
        List<BaseMembership> membershipList = new List<BaseMembership>();

        //Hardcode data in
        membershipList.Add(new RegularMembership(5263, "janedoe@gmail.com", "Regular Membership", 400, 1200, .01));
        membershipList.Add(new ExecutiveMembership(6587, "johndoe@gmail.com", "Executive Membership", 150, 1005, .01, .03));
        membershipList.Add(new ExecutiveMembership(4781, "austin@gmail.com", "Executive Membership", 5, 500, .02, .04));
        membershipList.Add(new NonprofitMembership(2498, "luna@gmail.com", "Non-profit Membership", 45, 1000, .02, true));
        membershipList.Add(new NonprofitMembership(3569, "lauren@gmail.com", "Non-profit Membership", 30, 900, .03, false));
        membershipList.Add(new CorporateMembership(7152, "sookie@gmail.com", "Corporate Membership", 129.99, 500, .02));



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
                bool memberIDTaken = true;

                //validate username 
                
                Console.WriteLine("Please create a unique MemberID.");
                int createMemberID = Convert.ToInt32(Console.ReadLine());

                for (int index = 0; index < membershipList.Count; index++)
                {
                        
                    if (membershipList[index].MembershipID == createMemberID)
                    {
                        memberIDTaken = true;
                        Console.WriteLine("This is not a unique ID. Member not created.");
                        break;
                    }
                    else
                    {
                        memberIDTaken = false;
                        Console.WriteLine("This is a unique ID."); 
                    } //end else
                        
                }//end for loop
                if (!(memberIDTaken))
                {
                    Console.WriteLine("What type of membership are you wanting to create?");
                        Console.WriteLine("Regular");
                        Console.WriteLine("Corporate");
                        Console.WriteLine("Nonprofit");
                        Console.WriteLine("Executive");
                        string updateMemberType = Console.ReadLine();
 
                        //Create if statements to go through prompt questions for creating memberID.
                        if (updateMemberType == "Regular")
                        {
                            //Prompt for email, annual cost of membership, current purchase balance and cash back percentage
                            Console.WriteLine("Please enter your email address.");
                            string createEmail = Console.ReadLine();
                            Console.WriteLine("Please enter the annual cost of your membership");
                            double createAnnualCost = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your currently purchase balance.");
                            double createPurchaseBalance = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your cash back rewards percentage. ");
                            double createCashBack = Convert.ToDouble(Console.ReadLine());

                            //create my object
                            membershipList.Add(new RegularMembership(createMemberID, createEmail, updateMemberType, createAnnualCost, createPurchaseBalance, createCashBack ));
                            

                        } //end of if for regular
                        else if (updateMemberType == "Corporate")
                        {
                            
                            //Prompt for email, annual cost of membership, current purchase balance and cash back percentage 
                            Console.WriteLine("Please enter your email address.");
                            string createEmailCorp = Console.ReadLine();
                            Console.WriteLine("Please enter the annual cost of your membership");
                            double createAnnualCostCorp = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your currently purchase balance.");
                            double createPurchaseBalanceCorp = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your cash back rewards percentage. ");
                            double createCashBackCorp = Convert.ToDouble(Console.ReadLine());

                            //create my object
                            membershipList.Add(new CorporateMembership(createMemberID, createEmailCorp, updateMemberType, createAnnualCostCorp, createPurchaseBalanceCorp, createCashBackCorp));
                            

                        } //end of corporate else if
                        else if (updateMemberType == "Nonprofit")
                        {   
                            
                            //Prompt for email, annual cost of membership, current purchase balance and cash back percentage 
                            Console.WriteLine("Please enter your email address.");
                            string createEmailNP = Console.ReadLine();
                            Console.WriteLine("Please enter the annual cost of your membership");
                            double createAnnualCostNP = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your currently purchase balance.");
                            double createPurchaseBalanceNP = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("True or False: Are you in the Military or apart of an Educational Organization?");
                            bool createMiliaryEdu = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Please enter your cash back rewards percentage");
                            double createCashBackNP = Convert.ToDouble(Console.ReadLine());
                            
                            //create my object
                            membershipList.Add(new NonprofitMembership(createMemberID, createEmailNP, updateMemberType, createAnnualCostNP, createPurchaseBalanceNP, createCashBackNP, createMiliaryEdu));
                            

                        } //end of non profit else if
                        else if (updateMemberType == "Executive")
                        {
                            //Prompt for email, annual cost of membership, current purchase balance and cash back percentage 
                            Console.WriteLine("Please enter your email address.");
                            string createEmailExec = Console.ReadLine();
                            Console.WriteLine("Please enter the annual cost of your membership");
                            double createAnnualCostExec = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your currently purchase balance.");
                            double createPurchaseBalanceExec = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your cash back rewards percentage for Tier 1. (When your purchase balance is less than $1000.)");
                            double createTier1CashBackExec = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Please enter your cash back rewards percentage for Tier 2. (When your purchase balance is greater than 1000.)");
                            double createTier2CashBackExec = Convert.ToDouble (Console.ReadLine());

                            //Create my new object
                            membershipList.Add(new ExecutiveMembership (createMemberID, createEmailExec, updateMemberType, createAnnualCostExec, createPurchaseBalanceExec, createTier1CashBackExec, createTier2CashBackExec));
                            

                        } //end of else if
                    Console.WriteLine("Member has been created.");
                }
                

            } //if else for option Create

            //To do: If the option is R or r, then read all of the members in the list. 
            else if (userChoiceString == "R" || userChoiceString == "r")
            {
                
                foreach (BaseMembership aMember in membershipList)
                {
                    Console.WriteLine(aMember);
                    Console.WriteLine("");
                }
            }

            //To do: If the option is U or u, then update an existing membership based on membershipID
            else if (userChoiceString == "U" || userChoiceString == "u")
            {
                
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
                               
                                Console.WriteLine("What do you want to update your annual cost to?");
                                double updateAnnualcost = GetValidDouble(0);
                                membershipList[index].AnnualCost = updateAnnualcost;
                                   
                                break; 

                            case 3:
                            
                                Console.WriteLine("What do you want to update your monthly purchase balance to? ");
                                double updatePurchaseBalance = GetValidDouble(0);
                                membershipList[index].CurrentPurchaseBalance = updatePurchaseBalance;
                                
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
            
                bool memberIDFound = false;

                //Prompt for the membershipID and then validate to make sure that there is one. 
                Console.WriteLine("Please enter in the membershipID that you wish to delete");
                int findMemberID = Convert.ToInt32(Console.ReadLine());

                //using a for loop to "search" for the memberID.
                for (int index = 0; index < membershipList.Count; index ++ )  
                {
                    //if found 
                    if (membershipList[index].MembershipID == findMemberID)
                    {
                        //prompt to make sure they really want to delete.
                        Console.WriteLine("Are you sure you want to delete this membership? Yes or No?");
                        string deleteAnswer = Console.ReadLine();
                        if (deleteAnswer == "Yes")
                        {
                            memberIDFound = true;
                            membershipList.RemoveAt(index);
                            Console.WriteLine("MemberID was found, and has been deleted.");
                        }
                        else
                        {
                            memberIDFound = true;
                            Console.WriteLine("MemberID was found, however will not be deleted.");
                            Console.WriteLine("");
                        }

                    }
                }
                //error message if not found.
                if (!(memberIDFound)) 
                {
                    Console.WriteLine("MemberID was not found. Nothing was deleted.");
                    Console.WriteLine("");
                }
            }

            //To do: If the option is L or l, then list all of the memberships in the list including info for each account type
            else if (userChoiceString == "L" || userChoiceString == "l")
            {
                //print to console each member in list
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
                bool memberIDFound= false;

                //Prompt for memberID
                Console.WriteLine("Please enter your memberID");
                int purchaseMemberID = Convert.ToInt32(Console.ReadLine());

                //for loop to search through index for member id. 
                for (int index = 0; index < membershipList.Count; index++)
                {
                    //if found, apply purchase.
                    if (membershipList[index].MembershipID == purchaseMemberID)
                    {
                        memberIDFound = true;
                        Console.WriteLine("What is the amount of your purchase?");
                        double purchaseAmount = GetValidDouble(0);
                        membershipList[index].PurchaseMethod(purchaseAmount);
                        Console.WriteLine("Purchase has been added. New monthly purchase balance is: $" + membershipList[index].CurrentPurchaseBalance);
                        Console.WriteLine("");

                    }
                }
                //error statement if not found
                if (memberIDFound == false)
                {
                    Console.WriteLine("MemberID not found. Purchase not applied to balance.");
                }

                
            }

            //To do: If the option is T or t, then perform a return transaction by getting a membership number from the user, and a return amount. 
            //If the membership exists then subtract the return from the monthly purchase total. 
            else if (userChoiceString == "T" || userChoiceString == "t")
            {
                bool memberIDFound= false;

                //prompt for member id
                Console.WriteLine("Please enter your memberID");
                int purchaseMemberID = Convert.ToInt32(Console.ReadLine());

                //for loop to search through member id
                for (int index = 0; index < membershipList.Count; index++)
                {

                    //if found, apply return
                    if (membershipList[index].MembershipID == purchaseMemberID)
                    {
                        memberIDFound = true;
                        Console.WriteLine("What is the amount of your return?");
                        double purchaseAmount = GetValidDouble(0);
                        membershipList[index].ReturnMethod(purchaseAmount);
                        Console.WriteLine("Return has been accepted. New monthly purchase balance is: $" + membershipList[index].CurrentPurchaseBalance);
                        Console.WriteLine("");

                    }
                }
                //error statement if not found
                if (memberIDFound == false)
                {
                    Console.WriteLine("MemberID not found. Purchase not applied to balance.");
                }
            }

            //To do: If the option is A or a, apply cash-back rewards as described by getting a membership number 
            else if (userChoiceString == "A" || userChoiceString == "a")
            {
                bool memberIDFound = false;

                //Prompt for a valid member id
                Console.WriteLine("Please enter in your memberID");
                int applyMemberID = Convert.ToInt32(Console.ReadLine());

                //For loop to search through index 
                for (int index = 0; index < membershipList.Count; index++)
                {
                    
                    //If membershipID is found then apply cash back rewards. Remember to zero out balance afterwards.
                    if (membershipList[index].MembershipID == applyMemberID)
                    {
                        memberIDFound = true;
                        Console.WriteLine("Your cash back reward request for membership: " + membershipList[index].MembershipID + " in the amount of $" + membershipList[index].CashBackAbstractMethod() + " has been made.");
                        Console.WriteLine("");
                        membershipList[index].CurrentPurchaseBalance = 0;
                    }
                }   
                //Error statement if not found
                if (memberIDFound == false)
                {
                    Console.WriteLine("MemberID was not found. Cash back rward request not applied.");
                    Console.WriteLine("");
                }             

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

