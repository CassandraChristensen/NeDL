using System;

namespace BankAccountCompetency
{
  class SavingsAccount : BankAccount, IAnnualEarnings    //Derived Account : Base Account, Interface
  {
      //Create my property for Annual Interest Rate
      public double AnnualInterestRate
      { get; set; }

      //Create my default constructor. Include the base so it can call the default base class constructor as well. 
      public SavingsAccount () : base ()
      {
          AnnualInterestRate = 0.0;
      }

      //Create my constructor with passing parameters. Include the base so it can call my base class constructor as well. 
      public SavingsAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
      }


      //Create my Withdrawal abstract Method. This is overriding the abstract method in my base class. I'm going to first deduct the withdrawal amount from the current balance, and then i'm going to return the new balance. 
      public override double WithdrawalAbstract(double withdrawalAmount)
      {   
        CurrentBalance = CurrentBalance - withdrawalAmount;
        return CurrentBalance;
      }


    //Create my interface. This is my interface i created, i'm just returning the current balance times the annual interest rate, because i'm not actually updating the balance. Just reporting the amount on my ToString.
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }

    //Create my ToString(): This output the message to my console. 
      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: " + AnnualInterestRate + " | Annual Earnings from interest: " + AnnualEarnings();   
      }
  }
}