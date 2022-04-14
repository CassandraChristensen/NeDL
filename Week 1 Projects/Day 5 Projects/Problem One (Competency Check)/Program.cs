using System;

namespace HelloWorld
{
  class Program
  {
         static int GetValidInt ( int lowRange, int highRange)
         {
             int value;
             do
             {
                Console.WriteLine("Please enter a value greater than " + lowRange + " and less than " + highRange);
                value = Convert.ToInt16(Console.ReadLine());
             }
             while (value < lowRange || value > highRange);
             return value;
         } 

         static int WeightedScore (int totalNumberScore, int numberTests)
          {
            int weightedScore = totalNumberScore/numberTests;
            return weightedScore;
          }


          static void Main(string[] args)
    {

      //Prompt the instructro for the number of students for which grades need to be calculated  
      Console.WriteLine("Hello instructor, please enter the number of students for which grades need to be calculated.");
      int numberOfStudent = Convert.ToInt16(Console.ReadLine());

      //Validate that the input is at least one
      while (numberOfStudent < 1)
      {
          Console.WriteLine("Please enter a number that is at least one.");
          numberOfStudent = Convert.ToInt16(Console.ReadLine());
      }

      
     for (int baseStudent = 0; baseStudent <numberOfStudent; baseStudent++)
        {
            
         string studentName;
         int totalHomework = 0;
         int weightedHomework = totalHomework/5;
         int totalQuiz =0;
         int weightedQuiz = totalQuiz/3;
         int totalExam = 0;
         int weightedExam = totalExam/2;
         double finalWeightedGrade = 0;
         double gradeA = 90;
         char letterGradeA = 'A';
         double gradeB = 80;
         char letterGradeB = 'B';
         double gradeC = 70;
         char letterGradeC = 'C';
         double gradeD = 60;
         char letterGradeD = 'D';
         char letterGradeF = 'F';


            //Prompt for student name: 
             Console.WriteLine("Please enter the student's name.");
             studentName = Console.ReadLine();
            

            //Prompt for homework grades and validate the number entered, writing for loop because I know I want this to loop 5 times.
            for (int baseHomework = 0; baseHomework < 5; baseHomework++)
            {
                Console.WriteLine("Please enter the grade for homework assignment " + (baseHomework+1));
                int gradeHomework = GetValidInt(0,100);

                //Calculate the total homework, so the weighted homework can be found. 
                totalHomework = totalHomework + gradeHomework;
                weightedHomework = WeightedScore(totalHomework, 5);
            }

            //Prompt for quiz grades and validate the number entered, writing for loop because I know I want this to loop 3 times. 
            for (int baseQuiz =0; baseQuiz < 3; baseQuiz++)
            {
                Console.WriteLine("Please enter the grade for quiz number " + (baseQuiz+1));
                int gradeQuiz = GetValidInt(0,100);    

                //Calculate the total quiz, so the weighted quiz can be found. 
                totalQuiz = totalQuiz + gradeQuiz;
                weightedQuiz = WeightedScore(totalQuiz, 3);
            }

             //Prompt for test grades and validate the number entered, writing for loop because I know I want this to loop 2 times. 
            for (int baseTest = 0; baseTest < 2; baseTest++)
            {
                Console.WriteLine("Please enter the grade for test number " + (baseTest+1));
                int gradeExam = GetValidInt(0,100);

                //Calculate the total exam, so the weighted exam can be found.
                totalExam = totalExam + gradeExam;
                weightedExam = WeightedScore(totalExam, 2);
            }

            //Need to convert my weighted numbers to doubles since I have to multiple by a decimal.
            double doubleWeightedHomework = Convert.ToDouble(weightedHomework) * 0.5;
            double doubleWeightedQuiz = Convert.ToDouble(weightedQuiz) * 0.3;
            double doubleWeightedExam = Convert.ToDouble(weightedExam) * 0.2;

            //Calculate my final weighted grade by adding together the double amounts from my weighted amounts. 
            finalWeightedGrade = doubleWeightedHomework + doubleWeightedQuiz + doubleWeightedExam;

            //Output information to the instructor.
            Console.WriteLine(studentName);
            Console.WriteLine("The weighted average for homework scores is: " + weightedHomework);
            Console.WriteLine("The weighted average for quiz scores is: " + weightedQuiz);
            Console.WriteLine("The weighted average for exam scores is: " + weightedExam);
            Console.WriteLine("The final weighted grade is: " + finalWeightedGrade);
         
            if (finalWeightedGrade >= gradeA)
            {
                Console.WriteLine("Grade for this class is: " + letterGradeA);
            }
            else if (finalWeightedGrade < gradeA && finalWeightedGrade >= gradeB)
            {
                Console.WriteLine("Grade for this class is " + letterGradeB);
            }
            else if (finalWeightedGrade < gradeB && finalWeightedGrade >= gradeC)
            {
                Console.WriteLine("Grade for this class is: " + letterGradeC);
            }
            else if (finalWeightedGrade < gradeC && finalWeightedGrade >= gradeD)
            {
                Console.WriteLine("Grade for this class is: " + letterGradeD);
            }
            else 
            {
                Console.WriteLine("Grade for this class is: " + letterGradeF);
            }
        }
    }
  }
  
}  
