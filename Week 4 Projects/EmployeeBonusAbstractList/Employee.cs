using System;

namespace MyApplication
{
  abstract class Employee
  {
   //Create my properties, Last Name, First Name and Employee type. Use, get/set. 

   //Last Name property 
   public string LastName
   { get; set; }

   public string FirstName
   { get; set; }

   public string EmployeeType
   { get; set; }

   //Create my default constructor
   public Employee ()
   {
       LastName = "";
       FirstName = "";
       EmployeeType = "";
   }

   //Create my constructor with parameters
   public Employee (string newLastName, string newFirstName, string newEmployeeType)
   {
       LastName = newLastName;
       FirstName = newFirstName;
       EmployeeType = newEmployeeType;
   }

   //Create my GetBonus Abstract Method
   public abstract double GetBonus();

   //Create my ToString polymorphism
   public override string ToString()
   {
       return "Employee: " + LastName + ", " + FirstName + " | Type: " + EmployeeType;
   }

  }
}
