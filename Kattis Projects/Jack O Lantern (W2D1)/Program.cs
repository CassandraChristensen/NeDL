using System;

namespace MyApplication
{
  class Program
  {

    static int GetValidInt(int lowRange, int highRange)
    {
        int value;
        do
        {
            Console.WriteLine("Please enter a number that is greater than: " + lowRange + " and less than: " + highRange);
            value = Convert.ToInt16(Console.ReadLine());
        } while (value < lowRange || value > highRange);
        return value;
    }
    static void Main(string[] args)
    {
      //Console.WriteLine("Please enter the number of eye designs you have created.");
      int N = GetValidInt(1,500);

      //Console.WriteLine("Please enter the number of nose designs you have created.");
      int T = GetValidInt(1,500);

      //Console.WriteLine("Please enter the number of mouth designs you have created.");
      int M = GetValidInt(1,500);

      int totalDesigns = N * T * M;

      Console.WriteLine("The total number of designs possible is: " + totalDesigns);
    }

  }
}

