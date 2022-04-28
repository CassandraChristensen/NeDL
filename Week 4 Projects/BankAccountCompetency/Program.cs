using System;

namespace BankAccountCompetency
{
  class Program
  {
    static void Main(string[] args)
    {
        
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

        


        

    }
  }
}
