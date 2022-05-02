using System;

namespace MyApplication
{
  class CorporateMembership : BaseMembership
  {
    //Create my properties for: Cash back rewards
    public double CorporateCashBackRewards    //This will be a flat percent 
    { get; set; }

    //Create my constructors, both default and with parameters passing 
    public CorporateMembership () : base ()
    {
        CorporateCashBackRewards = 0.0;
    }

    public CorporateMembership (int newMembershipID, string newMemberEmailAddress, string newTypeOfMembership, double newAnnualCost, double newCurrentPurchaseBalance, double newCorporateCashBackRewards) : base (newMembershipID, newMemberEmailAddress, newTypeOfMembership, newAnnualCost, newCurrentPurchaseBalance)
    {
        CorporateCashBackRewards = newCorporateCashBackRewards;
    }

    //Create my methods: Abstract Cash Back, Interface and ToString

    //Abstract Cash Back Method: 
    public override double CashBackAbstractMethod ()
    {
        double totalCashBack = CurrentPurchaseBalance * CorporateCashBackRewards;
        return totalCashBack;
    }

    
    //ToString 
    public override string ToString()
    {
        return base.ToString() + " | Cash Back Rewards Percentage: "  + CorporateCashBackRewards;
    }
  } //Class
} //Namespace