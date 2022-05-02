using System;

namespace MyApplication
{
  class ExecutiveMembership : BaseMembership
  {
    //Create my properties for: Cash back rewards Tier 1 and Tier 2
    public double ExecutiveCashBackRewardsTier1    //Less than or equal to 1000
    { get; set; }

    public double ExecutiveCashBackRewardsTier2  //More than 1000
    { get; set; }

    //Create my constructors, both default and with parameters passing 
    public ExecutiveMembership () : base ()
    {
        ExecutiveCashBackRewardsTier1 = 0.0;
        ExecutiveCashBackRewardsTier2 = 0.0;
    }

    public ExecutiveMembership (int newMembershipID, string newMemberEmailAddress, string newTypeOfMembership, double newAnnualCost, double newCurrentPurchaseBalance, double newExecutiveCashBackRewardsTier1, double newExecutiveCashBackRewardsTier2) : base (newMembershipID, newMemberEmailAddress, newTypeOfMembership, newAnnualCost, newCurrentPurchaseBalance)
    {
        ExecutiveCashBackRewardsTier1 = newExecutiveCashBackRewardsTier1;
        ExecutiveCashBackRewardsTier2 = newExecutiveCashBackRewardsTier2;
    }

    //Create my methods: Abstract Cash Back, Interface and ToString

    //Abstract Cash Back Method: 
    public override double CashBackAbstractMethod ()
    {
        double totalCashBack;
        if (CurrentPurchaseBalance <= 1000) 
        {
            totalCashBack = CurrentPurchaseBalance * ExecutiveCashBackRewardsTier1;
        }
        else 
        {
            totalCashBack = CurrentPurchaseBalance * ExecutiveCashBackRewardsTier2;
        }
        return totalCashBack;
    }

    //Interface

    
    //ToString 
    public override string ToString()
    {
        return base.ToString() + " | Tier 1 Cash Back Rewards Percentage: "  + ExecutiveCashBackRewardsTier1 + " | Tier 2 Cash Back Rewards Percentage: " + ExecutiveCashBackRewardsTier2;
    }
  } //Class
} //Namespace