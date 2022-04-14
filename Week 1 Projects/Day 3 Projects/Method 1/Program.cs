using System;

namespace MyApplication
{
  class Program
  {
    static int GetValidInt(int minLow, int minHigh)
    {
      int valueAge;
      do 
      {
          Console.WriteLine("Please enter a number between 0-100");
          valueAge = Convert.ToInt32(Console.ReadLine());
        //  return valueAge;
      }
      while (quizValue < minLow || Quiz > minHigh);
      return quizValue
    }

    static void Main(string[] args)
    {
     // string aString = "Please enter the number of quizzes you want graded";
     int minLow = 0;
     int minHigh = 101;
      int validInt = GetValidInt("Please enter the number of quizzes you want to grade);
    }
  }
}
