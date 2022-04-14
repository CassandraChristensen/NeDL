using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       //Initialize the Array Int Variable Container. They don't have values yet so entering new int, and inside square brackets, entering in number of values will be included. 
        int [] scores = new int [10];
        
        
      
    for ( int indexQuiz = 0; indexQuiz < scores.Length; indexQuiz++)
    {  
        Console.WriteLine("Please enter score for quiz number " + (indexQuiz+1));
        scores[indexQuiz] = Convert.ToInt32(Console.ReadLine());
    }

      int minPossibleScore = scores[0];
      int maxPossibleScore = scores [0];

    //Find the minimum
    for (int indexQuiz = 0; indexQuiz < 10; indexQuiz++)
    {
        if (scores[indexQuiz] < minPossibleScore)
          {
            minPossibleScore = scores[indexQuiz];
          }
    }
    Console.WriteLine("The minimum possible scores is: " + minPossibleScore);
      
    //Find the max
    for (int indexQuiz = 0; indexQuiz < scores.Length; indexQuiz++)
    {
        if (scores[indexQuiz] > maxPossibleScore)
          {
            maxPossibleScore = scores[indexQuiz];
          }      
    }

    Console.WriteLine("The maximum possible scores is: " + maxPossibleScore);

    //find the total score
    int totalScore = 0;

    for (int indexQuiz = 0; indexQuiz < scores.Length; indexQuiz++)
    {
      totalScore = totalScore + scores[indexQuiz];
    }
    
    Console.WriteLine("The total score is: " + totalScore);
    
    //find the average score 
    int averageScore = totalScore/scores.Length;

   // for (int indexQuiz = 0; indexQuiz < 10; indexQuiz++)
    //{
     // averageScore = totalScore/10;
    //}  

    Console.WriteLine(" The average score is: " + averageScore);

    }
    }
  }

