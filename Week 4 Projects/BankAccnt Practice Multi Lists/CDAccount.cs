using System;

namespace BankAccountCompetency
{
  class CDAccount : BankAccount, IAnnualEarnings, ISetPenalty  //Derived Account : Base Account, Interface
  {
      //Create my property for Annual Interest Rate
      public double AnnualInterestRate
      { get; set; }

      public double PenaltyEarlyWithdrawal
      { get; set; }

      //Create my default constructor. Include base so it can call my base class's default constructor. Even if i didn't write it out, it would still happen automatically. But better to write it out and show what's happening.
      public CDAccount () : base ()
      {
          AnnualInterestRate = 0.0;
          PenaltyEarlyWithdrawal = 0.0;
      }

      //Create my constructor with parameters. Include base so it can call my base class's constructor. 
      public CDAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate, double newPenaltyEarlyWithdrawal) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
          PenaltyEarlyWithdrawal = newPenaltyEarlyWithdrawal;
      }


      //Create my Withdrawal abstract Method. This is overriding the abstract method in my base class. I'm going to first deduct the withdrawal amount from the current balance, and then i'm going to return the new balance. 
      public override double WithdrawalAbstract(double withdrawalAmount)
      {    
          double totalWithdrawal = withdrawalAmount + PenaltyEarlyWithdrawal;
          CurrentBalance = CurrentBalance - totalWithdrawal;
          return CurrentBalance;
      }

      //Implement my interface method. This is my interface i created, i'm just returning the current balance times the annual interest rate, because i'm not actually updating the balance. Just reporting the amount on my ToString.
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }

      
      //This is another interface, it adds the PenaltyEarlyWithdrawal fee with the withdrawal amount. I'm not updating the penalty withdrawal in the index so I'm not going to update the PenaltyEarlyWithdrawal Amount. I'm using this for validation to make sure the user has sufficient funds.  
     public override double SetPenaltyPlusWithdrawal( double withdrawalAmount )
     {
         return PenaltyEarlyWithdrawal + withdrawalAmount;
     }

     //This is my ToString. It outputs the message to the console. 
      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: " + AnnualInterestRate + " | Penalty for early withdrawal: " + PenaltyEarlyWithdrawal + " | Annual earnings from interest: " + AnnualEarnings();   
      }
  }
}