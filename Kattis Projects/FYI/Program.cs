using System;

namespace MyApplication
{
  class Program
  {
    
    static int GetValidIntMethod (int lowRange, int highRange)
    {
        int value; 
        do 
        {
            Console.WriteLine("Please enter a number between " + lowRange + " and " + highRange );
            value = Convert.ToInt32(Console.ReadLine());
        }
        while (value < lowRange || value > highRange);
        return value;
    }
    static void Main(string[] args)
    {
      //Prompt the user to enter the phone number
        Console.WriteLine("Please enter in a 7 digit phone number.");

      //Obtain the number and validate that its greater than 1,000,000 and less than 9,999,999, if not, give error message. 
        int phoneNumber = GetValidIntMethod(1000000,9999999); 

        bool prefixFound = false;
      //if loop. if prefix is 555, output a 1, else, output a zero 
      if (phoneNumber >= 5550000 && phoneNumber <= 5559999)
      {
          prefixFound = true;
          Console.WriteLine("1");
      }
      else 
      {
          prefixFound = false;
          Console.WriteLine("0");
      }

    }
  }
}
