using System;

namespace BankAccountCompetency
{
  class CheckingAccount : BankAccount    //Derived Account : Base Account, Interface
  {
      //Create my property 
      public double AnnualFee
      { get; set; }

      //Create my default constructor 
      public CheckingAccount ()
      {
          AnnualFee = 0.0;
      }

      //Create my constructor with parameters 
      public CheckingAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance, double newAnnualFee) : base(newAccountID, newTypeofAccount, newCurrentBalance)
      {
          AnnualFee = newAnnualFee;
      }


      //Create my abstract Withdrawal Method
      public override double WithdrawalAbstract (double withdrawalAmount)
      {
          return CurrentBalance - withdrawalAmount;
      }

      //Create my ToString 
      public override string ToString ()
      {
          return base.ToString() + " | Annual Fee: " + AnnualFee;
      }
  }
}