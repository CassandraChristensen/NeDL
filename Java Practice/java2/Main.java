import java.util.Scanner;

import javax.lang.model.util.ElementScanner14;

public class Main 
{
  static Scanner myObj = new Scanner (System.in); 
  static int getValidInt(int lowValue, int highValue)
  {
    
    int value; 
    do
    {
      System.out.println("Please enter a number greater than or equal to " + lowValue + "and less than or equal to " + highValue);
      value = myObj.nextInt();
    } while (value < lowValue || value > highValue);
    return value;
  }

    
    public static void main(String[] args) 
    {
        Scanner myObj = new Scanner (System.in); 
        
      int numberStudents;

        do 
        {
        System.out.println("Hello, Teacher! Please enter the number of students you wish to grade.");
        numberStudents = myObj.nextInt();
        } while (numberStudents < 1);

        System.out.println(numberStudents);
      
        //Create a big for loop that will loop through all info and output to the user
        for (int baseStudent = 0; baseStudent < numberStudents; baseStudent++)
        {
        
          int homeworkTotal = 0;
          int homeworkAverage = homeworkTotal/5;
          int quizTotal = 0;
          int quizAverage = quizTotal/3;
          int examTotal = 0;
          int examAverage = examTotal/2;
          String studentName = "";

          
            System.out.println("Please enter the student's name");
            studentName = myObj.next();
          
          
          //prompt for homework grades
          for (int baseHomework = 0; baseHomework < 5; baseHomework++)
          {
            System.out.println("Please enter the student's grade for homework assignment " + (baseHomework+1));
            int homeworkGrade = getValidInt(0,100);

            //Calculate the total homework so the weighted homework can be found. 
            homeworkTotal = homeworkTotal + homeworkGrade;
            //homeworkAverage = homeworkTotal/5;

          }
          
          //prompt for quiz grades
          for (int baseQuiz = 0; baseQuiz < 3; baseQuiz++)
          {
            System.out.println("Please enter the student's grade for quiz assignment " + (baseQuiz+1));
            int quizGrade = getValidInt(0,100);
            
            //Calculate the total quiz home and the average
            quizTotal = quizTotal + quizGrade;
            //quizAverage = quizTotal/3;

          }

          //prompt for exam grades
          for (int baseExam = 0; baseExam < 2; baseExam++)
          {
            System.out.println("Please enter the student's grade for exam " + (baseExam+1));
            int examGrade =getValidInt(0, 100);

            //Caculate the total home and the average
            examTotal = examTotal + examGrade;

          }

        
          homeworkAverage = homeworkTotal/5;
          quizAverage = quizTotal/3;
          examAverage = examTotal/2;

          double finalGrade = (homeworkAverage * .50) + (quizAverage * .30) + (examAverage * .20);

          System.out.println("The student's name is: " + studentName);
          System.out.println("Homework average is: " + homeworkAverage);
          System.out.println("Quiz average is: " + quizAverage);
          System.out.println("Exam average is: " + examAverage);

          if (finalGrade >= 90)
          {
            System.out.println("Final grade is: A");
          }
          else if (finalGrade >= 80 && finalGrade < 90)
          {
            System.out.println("Final grade is: B");
          }
          else if (finalGrade >= 70 && finalGrade < 80)
          {
            System.out.println("Final grade is: C");
          }
          else if (finalGrade >= 60 && finalGrade < 70)
          {
            System.out.println("Final grade is: D");
          }
          else
          {
            System.out.println("Final grade is: F");
          }
      }//end of big for loop


    }
  }
  