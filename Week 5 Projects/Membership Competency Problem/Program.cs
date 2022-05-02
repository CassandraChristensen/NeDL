using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create my list 
      List<BaseMembership> membershipList = new List<BaseMembership>();

      //Hardcode data in: Regular Membership
      membershipList.Add(new RegularMembership(5263, "janedoe@gmail.com", "Regular Membership", 79.99, 1200, .01));
      membershipList.Add(new ExecutiveMembership(6587, "johndoe@gmail.com", "Executive Membership", 150, 989, .01, .03));
      membershipList.Add(new NonprofitMembership(2498, "luna@gmail.com", "Non-profit Membership", 45, 1000, .02, false));
      membershipList.Add(new CorporateMembership(7152, "sookie@gmail.com", "Corporate Membership", 129.99, 500, .02));

      //Read
      foreach (BaseMembership aMember in membershipList)
      {
          Console.WriteLine(aMember);
          Console.WriteLine("");
      }
    }
  }
}

