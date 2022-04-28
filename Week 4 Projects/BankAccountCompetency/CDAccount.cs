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

      //Create my default constructor 
      public CDAccount ()
      {
          AnnualInterestRate = 0.0;
          PenaltyEarlyWithdrawal = 0.0;
      }

      //Create my constructor with passing parameters
      public CDAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualInterestRate, double newPenaltyEarlyWithdrawal) : base (newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualInterestRate = newAnnualInterestRate;
          PenaltyEarlyWithdrawal = newPenaltyEarlyWithdrawal;
      }


      //Create a Withdraw+Penalty amount
      public double TotalWithdrawal(double withdrawlandPenalty)
      {
          return withdrawlandPenalty + PenaltyEarlyWithdrawal;
      } 

      //Create my Withdrawal abstract Method
      public override double WithdrawalAbstract(double withdrawalAmount)
      {    
          double totalWithdrawal = withdrawalAmount + PenaltyEarlyWithdrawal;
          CurrentBalance = CurrentBalance - totalWithdrawal;
          return CurrentBalance;
      }

      //Implement my interface method
      public double AnnualEarnings()
      {
          return CurrentBalance * AnnualInterestRate;
      }

      
     public override double SetPenaltyPlusWithdrawal( double newPenalty )
     {
         return PenaltyEarlyWithdrawal + newPenalty;
     }

      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: " + AnnualInterestRate + " | Penalty for early withdrawal: " + PenaltyEarlyWithdrawal + " | Annual earnings from interest: " + AnnualEarnings();   
      }
  }
}