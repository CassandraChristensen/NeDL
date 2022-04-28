using System;

namespace BankAccountCompetency
{
  class Program
  {
    static void Main(string[] args)
    {
        //declare my variables 
        bool userChoice;
        string userChoiceString;

        //Create my list 
        List<BankAccount> bankAccountList = new List<BankAccount>();

        //Create my object and hardcode data into it 

        //SavingsAccount: 
        bankAccountList.Add(new SavingsAccount(52678, "Savings Account", 1500, .10));
        bankAccountList.Add(new CheckingAccount(25789, "Checking Account", 2800, 25));
        bankAccountList.Add(new CDAccount(65879, "CD Account", 3900, .10, 30));

        //Print to console
        foreach (BankAccount anAccount in bankAccountList)
        {
            Console.WriteLine(anAccount);
        }

        //Create my main do loop that will go through all options for the user menu
        do
        {

            //Create a smaller do loop to do validation and get a valid input from user
            do
            {
                //initial the bool variable 
                userChoice = false;

                //To Do: Provide my user menu. 
                Console.WriteLine("Welcome to Nebraska Bank! Please choose from the following options: ");
                Console.WriteLine("L: List your accounts and all of their information. ");
                Console.WriteLine("D: Deposit money into one of your accounts. ");
                Console.WriteLine("W: Withdraw money from one of your accouonts. ");
                Console.WriteLine("Q: Quit the user menu.");

                //To Do: Get a valid user option
                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "W" || userChoiceString == "w" ||
                            userChoiceString == "Q" || userChoiceString == "q" );
                
                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option. ");
                }
            } while (!userChoice);

            //To Do: If the option is L or l, then List all of the accounts and their information. 
            if (userChoiceString == "L" || userChoiceString == "l")
            {
                Console.WriteLine("In the L/l area.");
            }

            //To Do: Else If the option is D or d, then deposit money into account. 
            else if (userChoiceString == "D" || userChoiceString == "d")
            {
                Console.WriteLine("In the D/d area.");
            }

            //To Do: Else If the option is W or w, then withdraw money from the account. 
            else if (userChoiceString == "W" || userChoiceString == "w")
            {
                Console.WriteLine("In the W/w area. ");
            } 

            //To Do: Else the option is Q or q, then quit
            else 
            {
                Console.WriteLine("Thank you for banking with us! Goodbye!");
            }

        } while (!(userChoiceString == "Q" || userChoiceString == "q"));

        


        

    } //main
  } //class
} //namespace
