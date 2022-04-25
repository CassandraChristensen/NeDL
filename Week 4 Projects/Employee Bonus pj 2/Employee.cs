using System;

namespace MyApplication
{
  class Employee
  {
      
      //Create my private fields and my properties using short hand. Because I am using shorthand, I do not need to define the field of the property.
      private string lastName;
      

      public string FirstName
      { get; set; }

      public char EmployeeType
      { get; set; }

      //Create my default constructor
      public Employee ()
      {
          lastName = null;
          FirstName = null; 
          EmployeeType = '\0';
      }
      
      //Create my constructor that passes values
      public Employee (string aLastName, string aFirstName, char aEmployeeType)
      {
          lastName = aLastName;
          FirstName = aFirstName;
          EmployeeType = aEmployeeType;
      }

      //Create a get/set methods for employee lastName
      public string getEmployeeLastName()
      {
          return lastName;
      }

      public void setEmployeeLastName( string anotherLastName)
      {
        lastName = anotherLastName;
      }

      
      //Calculate the bonus 
      int employeeBonus = 0;

      //Create my polymorphism. Use ToString Method.
      public override string ToString ()
      {
          return FirstName + " " + lastName + " is an " + EmployeeType + " employee. Their bonus will be: " + employeeBonus + ".";
      }

    
  } //Employee class
} //Namespace