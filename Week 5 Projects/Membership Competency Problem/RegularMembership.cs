using System;

namespace MyApplication
{
  class RegularMembership : BaseMembership
  {
    //Create my properties for: Cash back rewards
    public double RegularCashBackRewards    //This will be a flat percent 
    { get; set; }

    //Create my constructors, both default and with parameters passing 
    public RegularMembership () : base ()
    {
        RegularCashBackRewards = 0.0;
    }

    public RegularMembership (int newMembershipID, string newMemberEmailAddress, string newTypeOfMembership, double newAnnualCost, double newCurrentPurchaseBalance, double newRegularCashBackRewards) : base (newMembershipID, newMemberEmailAddress, newTypeOfMembership, newAnnualCost, newCurrentPurchaseBalance)
    {
        RegularCashBackRewards = newRegularCashBackRewards;
    }

    //Create my methods: Abstract Cash Back, Interface and ToString

    //Abstract Cash Back Method: 
    public override double CashBackAbstractMethod ()
    {
        double totalCashBack = CurrentPurchaseBalance * RegularCashBackRewards;
        return totalCashBack;
    }

    //Interface

    
    //ToString 
    public override string ToString()
    {
        return base.ToString() + " | Cash Back Rewards Percentage: "  + RegularCashBackRewards;
    }
  } //Class
} //Namespace
