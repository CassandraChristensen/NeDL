using System;

namespace MyApplication
{
     class Music //This is my base class (Parent)
    { 
    
        //Create Class Members. AKA fields and methods.

     //These are my fields. AKA instance variables that are declared inside of a class. I'll be able to access these when I create an object of the class.
     //They are private so only methods of the object can access it. 

     /* private string artistName;
     private string songTitle; */

      private string artistName; //my field
      public string getName()  //property longhand
      {
          return artistName;
      }

      public void setName (string ArtistName)
      {
          artistName = ArtistName;
      }

      
      public string SongTitle    // property shorthand
      { get; set; }  

      //This is my default constructor. AKA it is a special method. It is used when no values are being passed.
     public Music () //Constructors will have the same name as the class
      {
        artistName = null;
        SongTitle = null;
      }



       //This is the constructor when two values are being passed. This constructor allows me to use the private variables.
     /*  public Music (string aArtistName, string aSongTitle)
      {
        artistName = aArtistName;
        songTitle = aSongTitle;
     }
 */


     //This overrides ToString so an object can be printed out with the WriteLine.
      public override string ToString()
       {
        return "The artist's name is: " + artistName + " and one of their most well known songs is called: " + SongTitle;
      }

      
        //a fun method
      public void GoatMethod()
      {
      Console.WriteLine(artistName + " is the G.O.A.T.");
      }

      public void SingMethod()
      {
          Console.WriteLine("The artist sings in addition to rapping.");
      }
    }// class Music
} // namespace