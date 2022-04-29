using System;

namespace BankAccountCompetency
{
  class CheckingAccount : BankAccount    //Derived Account : Base Account (I'm not including the interface on this one because I don't need the method for this class.)
  {
      //Create my property for AnnualFee
      public double AnnualFee
      { get; set; }

      //Create my default constructor. Include base so it can call my base class's default constructor. Even if i didn't write it out, it would still happen automatically. But better to write it out and show what's happening.
      public CheckingAccount () : base ()
      {
          AnnualFee = 0.0;
      }

      //Create my constructor with parameters. Include base so it can call my base class's constructor. 
      public CheckingAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualFee) : base(newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualFee = newAnnualFee;
      }


      //Create my abstract Withdrawal Method. This is overriding the abstract method in my base class. I'm going to first deduct the withdrawal amount from the current balance, and then i'm going to return the new balance. 
      public override double WithdrawalAbstract (double withdrawalAmount)
      {
          CurrentBalance = CurrentBalance - withdrawalAmount;
          return CurrentBalance;
      }

      //Create my ToString 
      public override string ToString ()
      {
          return base.ToString() + " | Annual Fee: " + AnnualFee;
      }
  }
}