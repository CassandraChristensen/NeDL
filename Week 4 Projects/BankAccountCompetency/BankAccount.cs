using System;

namespace BankAccountCompetency
{
  abstract class BankAccount             //This is my base account and will be abstract because I'm going to use an abstract Method.
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
    public virtual double DepositMethod(double depositAmount)
    {
        return CurrentBalance + depositAmount;
    }

    //Create my abstract Withdrawal Method
    public abstract double WithdrawalAbstract(double withdrawalAmount); //this does not have a body because it's an abstract method
    

    //Create my ToString: 
    public override string ToString()
    {
        return "Account ID: " + AccountID + " | Type of Account: " + TypeOfAccount + " | Current Balance: " + CurrentBalance;
    }


  } //class
} //namespace