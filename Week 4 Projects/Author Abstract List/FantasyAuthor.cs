using System;

namespace MyApplication
{
  class FantasyAuthor : Author //Derived : Base
  {
   //Create my properties 
   public int GoodreadsChoiceAwardsBestFanstasyYearWon
   { get; set; }

   public double AveragePublished
   { get; set; }

   //Create my default constructor 
   public FantasyAuthor ()
   {
       GoodreadsChoiceAwardsBestFanstasyYearWon = 0;

   }

   //Create my constructor with parameters
   public FantasyAuthor (string newLastName, string newFirstName, char newGenre, string newBookTitle, string newPublishingCompany, int newGoodreadsChoiceAwardsBestFanstasyYearWon, double newAveragePublished) : base(newLastName, newFirstName, newGenre, newBookTitle, newPublishingCompany)
   {
       GoodreadsChoiceAwardsBestFanstasyYearWon = newGoodreadsChoiceAwardsBestFanstasyYearWon;
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
       return base.ToString() + "They won a Goodreads Choice Award for best Fantasy in: " + GoodreadsChoiceAwardsBestFanstasyYearWon + ". | The average books published in a decade is: " + AveragePublishedDecade() + ".";
   }
  }
}