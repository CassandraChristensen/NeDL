using System;

namespace BankAccountCompetency
{
  class Program
  {
    static double GetValidDouble (double lowValue)
    {
        double value;
        do 
        {
            Console.WriteLine("Please enter a value greater than " + lowValue);
            value = Convert.ToInt32(Console.ReadLine());
        } while (value < lowValue);
        return value;

    }
    static void Main(string[] args)
    {
        //declare my variables 
        bool userChoice;
        string userChoiceString;

        //Create my list 
        List<BankAccount> bankAccountList = new List<BankAccount>();
        List<SavingsAccount> savingsAccountList = new List<SavingsAccount>();
        List<CheckingAccount> checkingAccountList = new List<CheckingAccount>();
        List<CDAccount> cdAccountList = new List<CDAccount>();


        //Create my object and hardcode data into it 

        //SavingsAccount: 
        bankAccountList.Add(new SavingsAccount(52678, "Savings Account", 1500, .10));
        savingsAccountList.Add(new SavingsAccount(25789, "Savings Account", 2800, .10));
        checkingAccountList.Add(new CheckingAccount(65879, "Checking Account", 3900, 30));
        cdAccountList.Add(new CDAccount(38698, "CD Account", 4500, .10, 30));
        
        

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
                //Create a foreach loop so all accounts in the list will be printed 
                //All Must include: Account ID, Type of Account, Current Balance. Also, as appropriate include the interest rate, annual fee, early penalty and annual earnings based on interest 
                /* foreach (BankAccount anAccount in bankAccountList)
                {
                    Console.WriteLine(anAccount);
                } */

                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    Console.WriteLine(bankAccountList[index]);
                }
            }

            //To Do: Else If the option is D or d, then deposit money into account. 
            else if (userChoiceString == "D" || userChoiceString == "d")
            {

                //Prompt the user to enter the account number for the account they wish to deposit money to. 
                Console.WriteLine("Please enter the Account Number for the account you are wishing to deposit money to.");
                int depositAccountNumber = Convert.ToInt32(Console.ReadLine());


                //Create a bool variable so you can give error message if account ID not found
                bool accountFound = false;

                //Create a for loop to search through the index and find a valid accountID
                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    if (bankAccountList[index].AccountID == depositAccountNumber)
                    {
                        accountFound = true; 
                        Console.WriteLine("How much would you like to deposit?");
                        double depositAmount = GetValidDouble(0);
                        

                        //This performs the deposit method, it is returning the current balance, back to this index, after the deposit amount has been added to it.
                        bankAccountList[index].DepositMethod(depositAmount);
                        Console.WriteLine("The amount has been deposited. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                    }
                }
                if (accountFound == false)
                {
                    Console.WriteLine("The account number was not found.");
                }


            }

            //To Do: Else If the option is W or w, then withdraw money from the account. 
            else if (userChoiceString == "W" || userChoiceString == "w")
            {
                
                //Prompt the user to enter the account number for the account they wish to withdraw money from.
                Console.WriteLine("Please enter the Account Number for the account you are wishing to withdraw money from.");
                int withdrawAccountNumber = Convert.ToInt32(Console.ReadLine());


                //Create a bool variable so you can give error message if account ID not found
                bool accountFound = false;
                

                //Create a for loop to search through the index and find a valid accountID
                for (int index = 0; index < bankAccountList.Count; index ++)
                {
                    if (bankAccountList[index].AccountID == withdrawAccountNumber)
                    {
                        accountFound = true; 

                        if (bankAccountList[index].TypeOfAccount == "Savings Account")  //Savings Account
                        {
                            double withdrawSavingsAmount;
                            do
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                withdrawSavingsAmount = GetValidDouble(0);
                                if (bankAccountList[index].CurrentBalance <= withdrawSavingsAmount)
                                {
                                    Console.WriteLine("Insufficient funds. Please enter a withdrawal amount less than your current balance.");
                                }
                            }
                            while (bankAccountList[index].CurrentBalance <= withdrawSavingsAmount);

                            //This performs the withdrawal method, it is returning the current balance, back to this index, after the withdrawal amount has been removed from it.                         
                            bankAccountList[index].WithdrawalAbstract(withdrawSavingsAmount);
                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);

                        }
                        else if (bankAccountList[index].TypeOfAccount == "Checking Account")  //Checking Account
                        {
                            double withdrawCheckingAmount;
                            do
                            {
                            Console.WriteLine("How much would you like to withdraw?");
                            withdrawCheckingAmount = GetValidDouble(0);
                            if (withdrawCheckingAmount > (bankAccountList[index].CurrentBalance / 2))
                            {
                                Console.WriteLine("Insufficient funds. Please enter a withdrawal amount that is not greater than 50% of your current balance.");
                            }
                            }
                            while (withdrawCheckingAmount > (bankAccountList[index].CurrentBalance / 2));

                            //This performs the withdrawal method, it is returning the current balance, back to this index, after the withdrawal amount has been removed from it.
                            bankAccountList[index].WithdrawalAbstract(withdrawCheckingAmount);
                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                        }
                        else //CD Account 
                        {
                            double withdrawCDAmount;
                            do
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                withdrawCDAmount = GetValidDouble(0);
                               
                                if (bankAccountList[index].CurrentBalance < bankAccountList[index].SetPenaltyPlusWithdrawal(withdrawCDAmount))
                                {
                                    Console.WriteLine("Insufficient funds. Please enter a withdrawal amount that is not greater than the current balance, when the penalty fee is added.");
                                }
                                
                            } while (cdAccountList[index].CurrentBalance < cdAccountList[index].PenaltyEarlyWithdrawal);

                            //This performs the withdrawal method, it is returning the current balance, back to this index, after the withdrawal amount has been removed from it.
                            bankAccountList[index].WithdrawalAbstract(withdrawCDAmount);
                            Console.WriteLine("The amount has been withdrawn. Your new balance is: $" + bankAccountList[index].CurrentBalance);
                        }
                    }
                }
                if (accountFound == false)
                {
                    Console.WriteLine("The account number was not found.");
                }

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
