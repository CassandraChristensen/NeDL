using System;

namespace MyApplication
{
  abstract class Music  //base class
  { 
    //Create my properties 

    public string ArtistName
    { get; set; }

    public string SongTitle
    { get; set; }


    //Create my default constructor 
    public Music ()
    {
        ArtistName = "";
        SongTitle = "";
    }

    //Create my constructor with multiple parameters
    public Music (string newArtistName, string newSongTitle)
    {
        ArtistName = newArtistName;
        SongTitle = newSongTitle;
    }

    //Create my abstract Method
    public abstract int ArtistAbstractTest ();

    //Create my ToString Method
    public override string ToString ()
    {
        return "The artist's name is: " + ArtistName + ". | A song title by them: " + SongTitle;
    }
  }
}