using System;

namespace MyApplication
{
  class Billboard : Music //Billboard = child(derived) class & Music = parent(base) class
  {  
    //Create my field 
    //private int topTen;

    //This is a property
    public int topTen  
    { get; set; }


    //This is my default constructor
    public Billboard()   
    {
        topTen = -1;
    }

    //This is my constructor with values being passed
    /* public Billboard( int aTopTen ) //: base(aArtistName, aSongTitle)
    {
        topTen = aTopTen;
    } */

    public override string ToString()
    {
        return getName() + " has had " + topTen + " top ten Billboard Hot Rap Song hits. My favorite song of his is: " + SongTitle;
    }

  } // class Billboard
}  // namespace