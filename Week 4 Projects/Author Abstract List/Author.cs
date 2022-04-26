using System;

namespace MyApplication
{
  abstract class Author  //base class also an abstract class
  {
    //Create my properties 
    public string LastName
    { get; set; }

    public string FirstName
    { get; set; }

    public char Genre
    { get; set; }

    public string BookTitle
    { get; set; }

    public string PublishingCompany
    { get; set; }


    //Create my default constructor 
    public Author ()
    {
        LastName = "";
        FirstName = "";
        Genre = '\u0000';
        BookTitle = "";
        PublishingCompany = "";
    }

    //Create my constructor with parameters 
    public Author (string newLastName, string newFirstName, char newGenre, string newBookTitle, string newPublishingCompany)
    {
        LastName = newLastName;
        FirstName = newFirstName;
        Genre = newGenre;
        BookTitle = newBookTitle;
        PublishingCompany = newPublishingCompany;
        
    }

    //Create my abstract method 
    public abstract double AveragePublishedDecade();

    //Create my polymorphism ToString() Method
    public override string ToString()
    {
        return "The authors name is: " + LastName + ", " + FirstName + ". | Their Genre is: " + Genre + " A book title by them is: " + BookTitle + ". | Their publishing company is: " + PublishingCompany + ".";
    }
    
  }
}