using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Prompt user for their name. 
      Console.WriteLine("Please enter your name.");
      string userName = Console.ReadLine();
      Console.WriteLine("Hello, " + userName + ". Please enter the number of days you weighed yourself");
      int numberDays = Convert.ToInt16(Console.ReadLine());

      //Validate user input 
      do 
      { 
          Console.WriteLine("Please enter a positive number");
          Console.WriteLine("Please enter the number of days you weighed yourself.");
          numberDays = Convert.ToInt16(Console.ReadLine());
      }
      while (numberDays < 0);

      //Initialize the variables needed for the code
      double maxWeight = -1;
      double minWeight = 500;
      double totalWeight = 0;
      double averageWeight = totalWeight/numberDays;


      //Start for loop so we may ask them for their weight on a loop 
      for (int baseDay = 0; baseDay < numberDays; baseDay++)
      {
          Console.WriteLine("Please enter in your weight using lbs for Day " + (baseDay+1));
          double numberWeight = Convert.ToDouble(Console.ReadLine());

      //Validate user input 
      while (numberWeight < 0)
      {
          Console.WriteLine("Please enter in a positive number.");
          Console.WriteLine("Please enter in your weight using lbs for Day " + (baseDay+1));
          numberWeight = Convert.ToDouble(Console.ReadLine());
      } 

     //If statement to get min/max 
     if (maxWeight < numberWeight)
     {
        maxWeight = numberWeight;
     }

     if (minWeight > numberWeight)
     {
        minWeight = numberWeight;
     }

     //make sure total weight and average weight is updating each loop
     totalWeight = totalWeight + numberWeight;
     averageWeight = totalWeight/numberDays;
    }

    //Convert weight from lbs to kilograms
    double totalkilograms = totalWeight * 0.45359237;
    double averagekilograms = totalkilograms/numberDays;

    Console.WriteLine("Max weight: " + maxWeight);
    Console.WriteLine("Min weight: " +minWeight);
    Console.WriteLine("Average Weight in lbs: " + averageWeight);
    Console.WriteLine("Average weight in kilograms: " +averagekilograms);
    

    }
  }
}

