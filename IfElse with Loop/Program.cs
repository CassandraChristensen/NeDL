using System;
namespace MyApplication
{
  class Program
  {

      static int MyMinMethod (int num1, int numb2 )  //Write a method for mininum possible score. 
      {
        if (num1 < numb2)    
        {
            return num1;
        }
        else
        {
            return numb2;
        }
      }


      static int MyMaxMethod (int num3, int num4)  //Create a method to find the max
      {
          if (num3 > num4)
          {
            return num3;
          }
          else 
          {
              return num4;
          }
      }

      static int GetValidIntMethod (int lowRange, int highRange)  //GetValidIntMethod //first value, then while loop. new logic: parametrs for 10 and 100 then return the value
      {
    
        //  int value;
          int value;                      //if created in the do, then only exists there. 
          do 
          { 
              Console.WriteLine("Please enter a number between " + lowRange + " and " + highRange);
              value = Convert.ToInt16(Console.ReadLine());
              //check value using if, return will go here
          }
          while (value < lowRange || value > highRange);
          return value;
        
      }



    static void Main(string[] args)
    {
    //Introduction, prompt the teacher for the number of quizzes 
    Console.WriteLine("Hello, Teacher. Please enter the number of quizzes you graded.");
    int numberQuiz = GetValidIntMethod(0,100);

    //Write a validation input while condition loop
  //  while (numberQuiz < 0)
 //   { 
   //     Console.WriteLine("Please enter a positive number.");
     //   Console.WriteLine("Please enter the number of quizzes you graded.");
       // numberQuiz = Convert.ToInt16(Console.ReadLine());
   // }

   
    //Enter my Method for GetValidInt
    
   // numberQuiz = GetValidIntMethod(0, 100); **I took this out beacuse i included it already directly into the user input



    int maxPossibleScore = -1;    // Initialize to min minus 1
    int minPossibleScore = 101;  // Initialize to max plus 1
    int totalScore = 0;          // Initialize to zero     
    int scoreAverage = totalScore/numberQuiz;
   


    for (int baseQuiz = 0; baseQuiz < numberQuiz; baseQuiz++)  //If baseQuiz is less than the number of quizzes, then add a number to each base quiz until number of quizz is reached
    {                                                               //This is a for loop, because we know how many times we want to loop. It was important to initialize to zero 
        //Prompt the teacher to enter quiz scores                          //because the number of quiz starts at 1. 
        Console.WriteLine("Please enter the quiz score " + (baseQuiz+1)); 
        int scoreQuiz = GetValidIntMethod(0,100);

        //Validate the quiz scores
      //  while (scoreQuiz < 0)                                 //This is a while loop, it will loop indefinitely until the condition is met and an appropriate answer given.
      //  {
      //      Console.WriteLine("Please enter a score greater than 0");
      //      Console.WriteLine("Please enter quiz scores");
      //      scoreQuiz = Convert.ToInt16(Console.ReadLine());
      //  }

     // scoreQuiz = GetValidIntMethod(0,100);  ** I took this out because i included it already directly into the user input

        minPossibleScore = MyMinMethod(scoreQuiz, minPossibleScore);
        maxPossibleScore = MyMaxMethod (scoreQuiz, maxPossibleScore);
        

     //during loop, sum up all of the value, then when the loop is done, divide  TOTAL them together. Initial = 0, then add to the total, then divide by the total number of scores
    
    
    totalScore = totalScore + scoreQuiz;  // This is needed because it's adding a new quiz with each loop
    scoreAverage = totalScore/numberQuiz; // This is needed because the scoreAverage needs to be updated after each loop
    }
        //Output the information to the User
        Console.WriteLine("Max: " + maxPossibleScore);
        Console.WriteLine("Min: " + minPossibleScore);
        Console.WriteLine("Average: " + scoreAverage);

    }
    }
  }


