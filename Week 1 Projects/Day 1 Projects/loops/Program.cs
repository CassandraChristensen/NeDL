using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
     //Introduction and introductory question
     Console.WriteLine("What is your name?");
     string myName = Console.ReadLine(); 
     Console.WriteLine("Hello, " + myName + ". How much change is in your piggy bank?");
     //Prompt user for how many pennies they have
     Console.WriteLine("How many pennies do you have in your piggy bank?");
     int coinPenny = Convert.ToInt16(Console.ReadLine());

     //Prompt user for how many Nickels they have
     Console.WriteLine("How many nickels do you have in your piggy bank?");
     int coinNickel = Convert.ToInt16(Console.ReadLine());

     //Prompt user for how many dimes they have
     Console.WriteLine("How many dimes do you have in your piggy bank?");
     int coinDime = Convert.ToInt16(Console.ReadLine());

     //Prompt user for how many quarters they have 
     Console.WriteLine("How many quarters do you have in your piggy bank?");
     int coinQuarter = Convert.ToInt16(Console.ReadLine());

     //Convert Int to Double

     double doublePenny = coinPenny; 
     double doubleNickel = coinNickel;
     double doubleDime = coinDime;
     double doubleQuarter = coinQuarter;

     //Total amount: 
     double doublePennyTotal = doublePenny;
     double doubleNickelTotal = doubleNickel * 5;
     double doubleDimeTotal = doubleDime * 10;
     double doubleQuarterTotal = doubleQuarter * 25;
     double totalMoney = (doublePennyTotal + doubleNickelTotal + doubleDimeTotal + doubleQuarterTotal)/100;

     //Output info to the user 
     Console.WriteLine("The total amount in your piggy bank is: " + totalMoney);


    }
  }
}



