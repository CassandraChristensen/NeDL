using System;

namespace BankAccountCompetency
{
  class CDAccount : BankAccount    //Derived Account : Base Account, Interface
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

      //Create my Deposit Method
      public override double DepositMethod(double depositAmount)
      {
          return CurrentBalance + depositAmount;
      }

      //Create my Withdrawal abstract Method
      public override double WithdrawalAbstract(double withdrawalAmount)
      {    
          return CurrentBalance - withdrawalAmount;
      }

      public override string ToString()
      {
          return base.ToString() + " | Annual Interest: " + AnnualInterestRate + " | Penalty for early withdrawal: " + PenaltyEarlyWithdrawal;   
      }
  }
}