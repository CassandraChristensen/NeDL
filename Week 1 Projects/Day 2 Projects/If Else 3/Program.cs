using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Prompt User for a variable X
      Console.WriteLine("Please give a number to represent variable X.");
      int numberX = Convert.ToInt16(Console.ReadLine());

      //Prompt user for variable Y
      Console.WriteLine("Please give a number to represent variable Y");
      int numberY = Convert.ToInt16(Console.ReadLine());

      //Write If Statement
      if (numberX > numberY)
      {
          Console.WriteLine("Breakfast");
      }

      //Write Else If Statement
      else if (numberX < numberY)
      {
          Console.WriteLine("Lunch");
      }
      //Write Else Statement
      else 
      {
          Console.WriteLine("Dinner");
      }

      }
    }
  }

