using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    //Intro and prompt user for int X
     Console.WriteLine("Hello User. Please enter a value for X");
     int valueX = Convert.ToInt32(Console.ReadLine());

     //Prompt user for int y 
     Console.WriteLine("Please enter value for Y");
     int valueY = Convert.ToInt32(Console.ReadLine());

     //Calculate and output
     Console.WriteLine(valueX > valueY);


    }
  }
}