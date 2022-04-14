using System;

namespace MyApplication
{
  class Program
  {

     //Create method. Steps: declare return variable, name Method, set parameters
 static int PowerMethod( int baseNumber, int exponentNumber)
      {
          int valueofPow = 1;  //declaring the value of the power so it can be returned.
                               //setting this at 1 so it may be adjusted and changed later. Not going to to do zero because then when I multiply it comes out to zero.
          
        //Do the calculation of the base number to the power of the exponent
        for (int baseExponent = 0; baseExponent < exponentNumber; baseExponent++ ) //i'm doing a for loop because I know how many times I want it to loop, based on what user says.
         { 
           //This is similar to the number of quizzes, because i want to run through it again until the exponent the user input is reached 
            valueofPow = valueofPow * baseNumber;
         }
         return valueofPow; //This will be what is output to the user
      }
  
  static int GetValidIntMethod (int lowRange, int highRange)
  {
    int value;
    do
    {
      Console.WriteLine("Please enter a number that is greater than " + lowRange + " and less than " + highRange );
      value = Convert.ToInt16(Console.ReadLine());
    }
    while (value < lowRange || value > highRange);
    return value;

  }
   


    static void Main(string[] args)
    {

       int baseNumber = 0;        //I am going to prompt the user for this info, but first, must initialize to zero, same with exponent
       int exponentNumber = 0;
       int answerLoop;

       do 
      {
        Console.WriteLine("Please enter a base number.");
        baseNumber = GetValidIntMethod(0,100);
          
          //Check validity of base number
   //       while (baseNumber < 1)
   //       {
   //        Console.WriteLine("Please enter a number that is equal or greater than one");
    //        Console.WriteLine("Please enter a base number.");
    //        baseNumber = Convert.ToInt16(Console.ReadLine());
    //      }
        

          //Prompt for exponent number
        Console.WriteLine("Please enter an exponent number ");
        exponentNumber = GetValidIntMethod(0,100);

          //Check validity of exponent number
  //        while (exponentNumber < 1)
  //        {
  //          Console.WriteLine("Please enter a number that is equal or greater than one");
  //          Console.WriteLine("Please enter an exponent number");
  //          exponentNumber = Convert.ToInt16(Console.ReadLine());
  //        }
        
      //Needed to initilize the int that i will be outputting to the user. also need to update the arguments, this will be from the user. 
      int valueofPower = PowerMethod(baseNumber , exponentNumber);
      Console.WriteLine(valueofPower);


      // Prompt if they want to continue
      Console.WriteLine("Do you want to continue? Enter 0 to stop and 1 to continue");
      answerLoop = Convert.ToInt32(Console.ReadLine());

      }
      while ( answerLoop == 1);

      

    }
  }
}
