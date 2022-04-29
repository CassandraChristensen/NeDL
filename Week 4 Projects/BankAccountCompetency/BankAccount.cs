using System;

namespace BankAccountCompetency
{
  abstract class BankAccount : ISetPenalty      //This is my base account and will be abstract because I'm going to use an abstract Method.
  {
    //Create my properties for Account ID, TypeAccount, CurrentBalance

    public int AccountID
    { get; set; }

    public string TypeOfAccount
    { get; set; }

    public double CurrentBalance
    { get; set; }

    //Create my default constructor
    public BankAccount ()
    {
        AccountID = 0;
        TypeOfAccount = "";
        CurrentBalance = 0.0;
    }

    //Create my constructors with passing parameters
    public BankAccount (int newAccountID, string newTypeofAccount, double newCurrentBalance)
    {
        AccountID = newAccountID;
        TypeOfAccount = newTypeofAccount;
        CurrentBalance = newCurrentBalance;
    }

    //Create my Deposit Method
    public double DepositMethod(double depositAmount)
    {
        CurrentBalance = CurrentBalance + depositAmount;
        return CurrentBalance;
    }

    //Create my abstract Withdrawal Method
    public abstract double WithdrawalAbstract(double withdrawalAmount); //this does not have a body because it's an abstract method in my abstract class


    //This is an interface I created that i'm going to use in my CD account class. I'm returning 0 here because I don't need to do anything with this in this class.
    public virtual double SetPenaltyPlusWithdrawal (double withdrawalAmount)
    {
        return 0;
    }

    //Create my ToString: This will output my message to the console.
    public override string ToString()
    {
        return "Account ID: " + AccountID + " | Type of Account: " + TypeOfAccount + " | Current Balance: " + CurrentBalance;
    }


  } //class
} //namespace