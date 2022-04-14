using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter an integer for letter a.");
      int a = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Please enter an integer for letter b.");
      int b = Convert.ToInt16(Console.ReadLine());

    int answer1 = 1;
    int answer2 =0;

      if (a > b)
      {
          Console.Write(answer1);
      }
      else
      {
          Console.Write(answer2);
      }



    }
  }
}