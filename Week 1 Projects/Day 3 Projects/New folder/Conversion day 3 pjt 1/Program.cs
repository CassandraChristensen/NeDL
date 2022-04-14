using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Intro to User
      Console.WriteLine("Good morning, may I please have your name?");
      string userName = Console.ReadLine(); 
      Console.WriteLine("Hello, " + userName + ". May I please have the number of feet you are were to convert to inches?");
      double numberFeet = Convert.ToDouble(Console.ReadLine());

      //Perform validation loop
    //  while (numberFeet < 0)
    //  {
      //    Console.WriteLine("Please enter a positive number.");
    //      Console.WriteLine("Please enter the number of feet you want to convert to inches.");
      //    numberFeet = Convert.ToDouble(Console.ReadLine());
    //  }

      //Perform a Do While Loop 
      do 
      {
          Console.WriteLine("Please enter a positive number.");
          numberFeet = Convert.ToDouble(Console.ReadLine());
      }          
    while (numberFeet < 0);

      //Calculate the conversion 

    double numberInches = numberFeet * 12;

        //Output info to the user 

        Console.WriteLine(numberFeet + "feet converts to " + numberInches + "inches.");      
    }
  }
}

