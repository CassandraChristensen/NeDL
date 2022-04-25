using System;

namespace MyApplication
{
  class Billboard : Music  // Derived : Base
  { 
    //Create my properties 

    public int TopTen
    { get; set; }


    //Create my default constructor 
    public Billboard ()
    {
        TopTen = 0;
    }

    //Create my constructor with multiple parameters
    public Billboard (string newArtistName, string newSongTitle, int newTopTen) : base(newArtistName, newSongTitle)
    {
        TopTen = newTopTen;
    }

    //Create my abstract Method
    public override int ArtistAbstractTest()
    {
        return TopTen % 2; 
    }
    

    //Create my ToString Method
    public override string ToString ()
    {
        return base.ToString() + ". | Top ten is: " + TopTen + ". | Modulus of 2: " + ArtistAbstractTest();
    }
  }
}