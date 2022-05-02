using System;

namespace MyApplication
{
  abstract class BaseMembership
  {
    //Create my properties for: MembershipID, MemberEmailAddress, TypeOfMembership, Annual Cost, Current amount of purchases (balance) 
    public int MembershipID
    { get; set; }

    public string MemberEmailAddress
    { get; set; }

    public string TypeOfMembership
    { get; set; }

    public double AnnualCost 
    { get; set; }

    public double CurrentPurchaseBalance
    { get; set; }

    //Create my constructors. Include: default and with passing parameters 
    public BaseMembership ()
    {
        MembershipID = 0;
        MemberEmailAddress = "";
        TypeOfMembership = "";
        AnnualCost = 0.0;
        CurrentPurchaseBalance = 0.0;
    }

    public BaseMembership (int newMembershipID, string newMemberEmailAddress, string newTypeOfMembership, double newAnnualCost, double newCurrentPurchaseBalance)
    {
        MembershipID = newMembershipID;
        MemberEmailAddress = newMemberEmailAddress;
        TypeOfMembership = newTypeOfMembership;
        AnnualCost = newAnnualCost;
        CurrentPurchaseBalance = newCurrentPurchaseBalance;
    }

    //Create my method. Include: PurchaseMethod, ReturnMethod, Abstract Cash Back and ToString

    //Purchase Method: 
    public double PurchaseMethod (double purchaseAmount)
    {
        CurrentPurchaseBalance = CurrentPurchaseBalance + purchaseAmount;
        return CurrentPurchaseBalance;
    }

    //Return Method: 
    public double ReturnMethod (double returnAmount)
    {
        CurrentPurchaseBalance = CurrentPurchaseBalance - returnAmount;
        return CurrentPurchaseBalance;
    }

    //Abstract Cash Back Method: Do not include a body since this is the abstract method in my abstract class. 
    public abstract double CashBackAbstractMethod();

    //ToString: 
    public override string ToString()
    {
        return "Membership ID: " + MembershipID + " | Membership Email Address: " + MemberEmailAddress + " | Type of Membership: " + TypeOfMembership + " | Annual cost: $" + AnnualCost + " | Current Purchase Balance: $" + CurrentPurchaseBalance;
    }
  } // class
} // namespace
