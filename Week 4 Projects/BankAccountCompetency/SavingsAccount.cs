using System;

namespace BankAccountCompetency
{
  class SavingsAccount : BankAccount, IAnnualEarnings    //Derived Account : Base Account, Interface
  {
      //Create my property for Annual Interest Rate
      public double AnnualInterestRate
      { get; set; }

      //Create my default constructor 
      public SavingsAccount () : base ()
      {
          AnnualInterestRate = 0.0;
      }

      //Create my constructor with passing parameters
      public SavingsAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
      }


      //Create my Withdrawal abstract Method
      public override double WithdrawalAbstract(double withdrawalAmount)
      {   
        CurrentBalance = CurrentBalance - withdrawalAmount;
        return CurrentBalance;
      }


    //Create my interface
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }

      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: " + AnnualInterestRate + " | Annual Earnings from interest: " + AnnualEarnings();   
      }
  }
}