using System;

namespace MyApplication
{
  class Employee
  {
      
      //Create my private fields and my properties using short hand. Because I am using shorthand, I do not need to find the field of the property.
      public string LastName
      { get; set; }

      public string FirstName
      { get; set; }

      public char EmployeeType
      { get; set; }

      //Create my default constructor
      public Employee ()
      {
          LastName = null;
          FirstName = null; 
          EmployeeType = '\u0000';
      }
      
      //Create my constructor that passes values
      public Employee (string aLastName, string aFirstName, char aEmployeeType)
      {
          LastName = aLastName;
          FirstName = aFirstName;
          EmployeeType = aEmployeeType;
      }
      
      //Calculate the bonus 
      int employeeBonus = 0;

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return FirstName + " " + LastName + " is an " + EmployeeType + " employee. Their bonus will be: " + employeeBonus + ".";
      }

    
  } //Employee class
} //Namespace
