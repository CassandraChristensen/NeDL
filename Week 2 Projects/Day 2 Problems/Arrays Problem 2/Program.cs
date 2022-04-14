using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       //Initialize the Array Int Variable Container. They don't have values yet so entering new int. Then, inside of square brackets, entering in number of values will be included. 
        int [,] studentScores = new int [3,5];  //3 rows for students and 5 columns. 5 tests per student.


        //Nested for loop to prompt the user and obtain each student's scores
        for (int student = 0; student < 3; student++)   
        {
            for (int score = 0; score < 5; score++)
            {
                Console.WriteLine("Please enter the scores for student: " + (student+1));
                studentScores[student,score] = Convert.ToInt32(Console.ReadLine()); 
            }
        
        }


        //average for each student
        for (int student = 0; student < 3; student++)
        {
        int totalStudentScore = 0;
            for (int score = 0; score < 5; score++)
            {
                totalStudentScore = totalStudentScore + studentScores[student,score];
            }
        int average = totalStudentScore/5;
        Console.WriteLine("Average for Student: " + (student+1) + " is: " + average);
        }
        

        //int totalClassScore = studentScores[0,0];  // why does this add 100 when I have it like that?
        int totalClassScore = 0;
        int minPossibleScore = studentScores[0,0];
        int maxPossibleScore = studentScores[0,0];
        

        //Nested for loop to find the average for each student 
        for (int student = 0; student < 3; student++)
        {
            for (int score = 0; score < 5; score++)
            {
                totalClassScore = totalClassScore + studentScores[student, score];
                
            }
        }
        int averageClassScore =  totalClassScore/studentScores.Length;


        //Nested loop for the min score
        for (int student = 0; student < 3; student++)
        {
            for (int score = 0; score < 5; score++)
            {
                if (studentScores[student,score] < minPossibleScore)
                { 
                    minPossibleScore = studentScores[student,score];
                }                
            }
        }


        //Nested loop for the max score
        for (int student = 0; student < 3; student++)
        {
            for (int score = 0; score < 5; score++)
            {
                if (studentScores[student,score] > maxPossibleScore)
                { 
                    maxPossibleScore = studentScores[student,score];
                }
            }
        }

        //output to the user 
        Console.WriteLine("The total score: " + totalClassScore);
        Console.WriteLine("The average score for the class is: " + averageClassScore);
        Console.WriteLine("The minimum score for the class is: " + minPossibleScore);
        Console.WriteLine("The maximum score for the class is: " + maxPossibleScore);

    }
    }
  }
