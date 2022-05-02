using System;

namespace MyApplication
{
  class NonprofitMembership : BaseMembership
  {
    //Create my properties for: Cash back rewards
    public double NPCashBackRewards    //This will be perfect if non military/education
    { get; set; }

    public bool MilitaryOrEducationQuestion  //This will double the NPCashBackRewards if true
    { get; set; }

    //Create my constructors, both default and with parameters passing 
    public NonprofitMembership () : base ()
    {
        NPCashBackRewards = 0.0;
        MilitaryOrEducationQuestion = false;
    }

    public NonprofitMembership (int newMembershipID, string newMemberEmailAddress, string newTypeOfMembership, double newAnnualCost, double newCurrentPurchaseBalance, double newNPCashBackRewards, bool newMilitaryOrEducationQuestion) : base (newMembershipID, newMemberEmailAddress, newTypeOfMembership, newAnnualCost, newCurrentPurchaseBalance)
    {
        NPCashBackRewards = newNPCashBackRewards;
        MilitaryOrEducationQuestion = newMilitaryOrEducationQuestion;
    }

    //Create my methods: Abstract Cash Back, Interface and ToString

    //Abstract Cash Back Method: 
    public override double CashBackAbstractMethod ()
    {
        double totalCashBack;
        if (MilitaryOrEducationQuestion == true)
        {
            totalCashBack = CurrentPurchaseBalance * (NPCashBackRewards * 2);
        }
        else 
        {
            totalCashBack = CurrentPurchaseBalance * NPCashBackRewards;
        }
        return totalCashBack;
    }

    //Interface

    
    //ToString 
    public override string ToString()
    {
        return base.ToString() + " | Cash Back Rewards Percentage: "  + NPCashBackRewards + " | Miliary or Educational Organization: " + MilitaryOrEducationQuestion;
    }
  } //Class
} //Namespace