using System;

namespace MyApplication
{
  class Program
  {

     //Create method. Steps: declare return variable, name Method, set parameters
 static int PowerMethod( int baseNumber, int exponentNumber)    ///then do the other logic in the MAIN program. 
      {
          int valueofPow = 1;  //declaring the value of the power so it can be returned.
                               //setting this at 1 so it may be adjusted and changed later. Not going to to do zero because then when I multiply it comes out to zero.
         
       //Do the calculation of the base number to the power of the exponent
          for (int baseExponent = 0; baseExponent < exponentNumber; baseExponent++ ) //i'm doing a for loop because I know how many times I want it to loop, based on what user says.
           {
           //This is similar to the number of quizzes, because i want to run through it again until the exponent the user input is reached 
              valueofPow = valueofPow * baseNumber;
           }
           return valueofPow;
        
          //This will be what is output to the user      
      }
  
  //Create method. Steps: declare return variable, name Method, set parameters.
  static int GetValidInt( int lowRange, int highRange)
  {
    int value;
    do 
    {
      Console.WriteLine("Please enter a value great than: " + lowRange + " and less than: " + highRange);
      value = Convert.ToInt16(Console.ReadLine());
    }
    while (value < lowRange || value > highRange);
    return value;
  }


    static void Main(string[] args)
    {

       int baseNumber = 0;        //I am going to prompt the user for this info, but first, must initialize to zero, same with exponent
       int begExponentNumber = 0;
       int endExponentNumber = 0;
       int answerLoop;
       

      do 
      {
        //Prompt for a base number, validate using GetValidInt Method.
        Console.WriteLine("Please enter a base number.");
        baseNumber = GetValidInt(0,100);
          
        
        //Prompt for a beginning exponent number, validate using GetValidInt Method.
        Console.WriteLine("Please enter a beginning exponent number.");
        begExponentNumber = GetValidInt(0,100);

        //Prompt for an ending exponent number, validate using GetValidInt Method, validate with a while loop that endExponentNumber is greater than the beginningExponentNumber
        Console.WriteLine("Please enter an ending exponent number.");
        endExponentNumber = GetValidInt(0,100);
        while (endExponentNumber < begExponentNumber)
        {
          Console.WriteLine("Please enter a number greater than your beginning exponent number.");
          endExponentNumber = Convert.ToInt16(Console.ReadLine());
        }

        
       //Needed to initilize the int that I will be outputting to the user. also need to update the arguments, this will be from the user.
       //start loop from beg to end then calculate the control variable to change 
       //my for loop is initializing a base exponent number, but then i'm making it equal my beginning exponent since that is the number I want to start at.
       //loop will continue until the end exponenet has been reached.

        for ( int exponentNumber = begExponentNumber; exponentNumber <= endExponentNumber; exponentNumber++)
        {
        int valueofPower = PowerMethod (baseNumber, exponentNumber);
        Console.WriteLine("The value of your power is " + valueofPower);
        } 
        

        // Prompt if they want to continue
        Console.WriteLine("Do you want to continue? Enter 0 to stop and 1 to continue");
        answerLoop = Convert.ToInt32(Console.ReadLine());
    

      }
      while ( answerLoop == 1);

      

    }
  }
}