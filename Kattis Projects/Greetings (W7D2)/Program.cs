using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

      //Prompt user to enter greeting
      Console.WriteLine("Please enter your greeting.");
      string greeting = Console.ReadLine()!;

     //
      string section = greeting.Substring(1, greeting.Length - 2);

      Console.WriteLine(section);

      string result = "";

      for (int index = 0; index<section.Length*2; index++)
      {
          result += "e";
      }

      Console.WriteLine("h" + result + "y");
    } //main
  } //class program
} //namespace




