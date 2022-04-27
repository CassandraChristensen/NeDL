using System;

namespace MyApplication
{
  class Music 
  {
      //Create my properties 
      public string LastName
      { get; set; }

      public string FirstName
      { get; set; }

      public string RecordLabel
      { get; set; }

      //Create my default constructor
      public Music ()
      {
          LastName = "";
          FirstName = "";
          RecordLabel = "";
      }

      //Create my constructor with parameters
      public Music (string newLastName, string newFirstName, string newRecordLabel)
      {
          LastName = newLastName;
          FirstName = newFirstName;
          RecordLabel = newRecordLabel;
      }


      //Create a polymorphism ToString 
      public override string ToString()
      {
          return "Artist Name: " + LastName + ", " + FirstName + " | Recording Company: " + RecordLabel;
      }
  }  
  
}
