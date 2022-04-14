using System;

namespace MyApplication
{
  class Program
  {

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the total number of stones. ");
        int totalStones = Convert.ToInt32(Console.ReadLine());
        while (totalStones < 1 || totalStones > 10000000)
        {
            Console.WriteLine("Please enter a valid integer that is greater than or equal to 1 and less than 10,000,000.");
            totalStones = Convert.ToInt32(Console.ReadLine());
        }

        if (totalStones % 2 == 1)
        {
            Console.WriteLine("Alice wins");
        }
        else
        {
            Console.WriteLine("Bob wins");
        }

        
    }
  }
}
