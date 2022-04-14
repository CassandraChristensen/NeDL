using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Prompt user for number of days they ran
      Console.WriteLine("Hello User, please enter the number of days you ran this week.");
      int numberDays = Convert.ToInt16(Console.ReadLine());

      //Validate the user input with a Do/While Loop
    do
    {
        Console.WriteLine("Please enter a positive number.");
        Console.WriteLine("Please enter the number of days you ran this week.");
        numberDays = Convert.ToInt16(Console.ReadLine());
    }
    while (numberDays < 0);

    int maxMilesRan = -1;
    int minMilesRan = 101;
    int totalMilesRan = 0;
    int averageMilesRan = totalMilesRan/numberDays;

   //Create a For Loop that way the same Console.WriteLine will be repeated till all days ran are accounted for. 
    for (int baseDay = 0; baseDay < numberDays; baseDay++)
    {
        Console.WriteLine("Please enter the number of miles you ran on " + (baseDay+1));
        int numberMiles = Convert.ToInt16(Console.ReadLine());
    
    //Create a while loop to validate user input 
    while (numberMiles < 0)
    { 
        Console.WriteLine("Please enter a positive number.");
        Console.WriteLine("Please enter the numer of miles you ran on " + (baseDay+1));
        numberMiles = Convert.ToInt16(Console.ReadLine());
    }

    //Need to include If Condition for the miles 
    if (maxMilesRan < numberMiles)
    { 
        maxMilesRan = numberMiles;
    }
    if (minMilesRan > numberMiles)
    { 
        minMilesRan = numberMiles;
    }

    totalMilesRan = totalMilesRan + numberMiles;
    averageMilesRan = totalMilesRan/numberDays;

    }

    //Convert miles to kilometers 
    int totalKiloRan = totalMilesRan;
    double doubleKiloRan = totalKiloRan* 1.6;

    //Output info to user
    Console.WriteLine("Max: " + maxMilesRan);
    Console.WriteLine("Min: " + minMilesRan);
    Console.WriteLine("Average: " + averageMilesRan);
    Console.WriteLine("Total Kilo Ran: " + doubleKiloRan);



    }
  }
}

