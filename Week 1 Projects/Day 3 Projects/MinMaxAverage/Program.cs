using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    //Intro and obtain number of months
    Console.WriteLine("Hello User, please enter the number of months you would like to test.");
      int numberMonths = Convert.ToInt16(Console.ReadLine());
    
    //Validate user input with a do/while loop
    do
    {
        Console.WriteLine("Please enter a positive number.");
        Console.WriteLine("Please enter the number of months.");
        numberMonths = Convert.ToInt16(Console.ReadLine());
    }
    while (numberMonths < 0);

    int maxNumberBooks = -0;
    int minNumberBooks = 101;
    int totalNumberBooks = 0;
    int averageNumberBooks = totalNumberBooks/numberMonths;


    //Set up a for loop so it will repeat the question 
for (int baseMonth = 0; baseMonth < numberMonths; baseMonth++)
{
    Console.WriteLine("Please enter the number of books you read for Month " + (baseMonth+1));
    int numberBooks = Convert.ToInt16(Console.ReadLine());

//Validate the number of books from user with Do/While Loop
while (numberBooks < 0)
{ 
    Console.WriteLine("Please enter a positive number.");
    Console.WriteLine("Please enter the number of you read for Month " + (baseMonth+1));
    numberBooks = Convert.ToInt16(Console.ReadLine());
}

if (maxNumberBooks < numberBooks)
{ 
    maxNumberBooks = numberBooks;    
}

if (minNumberBooks > numberBooks)
{
    minNumberBooks = numberBooks;
}

totalNumberBooks = totalNumberBooks + numberBooks;
averageNumberBooks = totalNumberBooks/numberMonths;


}


Console.WriteLine("max number: " + maxNumberBooks);
Console.WriteLine("min books: " + minNumberBooks);
Console.WriteLine("Ave books: " + averageNumberBooks);


    }
  }
}

