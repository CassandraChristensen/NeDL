using System;

namespace MyApplication
{
  class ContemporaryAuthor : Author //Derived : Base
  {
   //Create my properties 
   public int GoodreadsChoiceAwardsBestYAYearWon
   { get; set; }

   public double AveragePublished
   { get; set; }

   //Create my default constructor 
   public ContemporaryAuthor ()
   {
       GoodreadsChoiceAwardsBestYAYearWon = 0;

   }

   //Create my constructor with parameters
   public ContemporaryAuthor (string newLastName, string newFirstName, char newGenre, string newBookTitle, string newPublishingCompany, int newGoodreadsChoiceAwardsBestYAYearWon, double newAveragePublished) : base(newLastName, newFirstName, newGenre, newBookTitle, newPublishingCompany)
   {
       GoodreadsChoiceAwardsBestYAYearWon = newGoodreadsChoiceAwardsBestYAYearWon;
       AveragePublished = newAveragePublished;
   }

   //Create my abstract 
   public override double AveragePublishedDecade()
   {
       return AveragePublished * 10;
   }

   //Create my ToString()
   public override string ToString ()
   {
       return base.ToString() + "They won a Goodreads Choice Award for best Young Adult fiction in: " + GoodreadsChoiceAwardsBestYAYearWon + ". | The average books published in a decade is: " + AveragePublishedDecade() + ".";
   }
  }
}