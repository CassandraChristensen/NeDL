using System;

namespace MyApplication
{
  class Employee
  {
    //Create my properties
    public string LastName
    { get; set; }
    public string FirstName
    { get; set; }
    public string EmploymentType
    { get; set; }

    //Create my default constructor 
    public Employee ()
    {
        LastName = "";
        FirstName = "";
        EmploymentType = "";
    }

    //Create my constructor with parameters
    public Employee (string newLastName, string newFirstName, string newEmploymentType)
    {
        LastName = newLastName;
        FirstName = newFirstName;
        EmploymentType = newEmploymentType;
    }

    //Create my GetBonus Method
    public override string ToString ()
    {
        return "Employee: " + LastName + ", " + FirstName + " | Type: " + EmploymentType; 
    }
  }
}