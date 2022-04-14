using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Intro, prompt user for speed using mph, and obtain info from user
      Console.WriteLine("How many miles did you drive?");
      Console.WriteLine("Please enter the speed using the unit of measure mph that you were driving.");
      double mphSpeed = Convert.ToDouble(Console.ReadLine());

      //Prompt user for time spent driving in minutes 
      Console.WriteLine("How many minutes were you driving for?");
      double timeMin = Convert.ToDouble(Console.ReadLine());
      while (timeMin > 99)
        {
            //Error message prompt: 
            Console.WriteLine("Please enter a number less than 99");
            Console.WriteLine("Please enter how many minutes you were for?");
            timeMin = Convert.ToDouble(Console.ReadLine());

        }


        //Calculate using formula 
        double milesTotal = timeMin * mphSpeed/60;

        //Output info to user
        Console.WriteLine("How many miles you drove: " + milesTotal);
    }
  }
}
