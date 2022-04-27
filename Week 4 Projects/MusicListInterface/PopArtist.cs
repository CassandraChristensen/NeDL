using System;

namespace MyApplication
{
  class PopArtist : Music, IArtistSound
  {
    //Create my properties 
    public string SongTitle
    { get; set; }


    //Default constructor
    public PopArtist ()
    {
        SongTitle = "";
    }

    //Constructor with parameters
    public PopArtist(string newLastName, string newFirstName, string newRecordLabel, string newSongTitle) : base(newLastName, newFirstName, newRecordLabel)
    {
        SongTitle = newSongTitle;
    }

    //Create my ArtistSound interface
    public string ArtistSound()
    {
        //the body of the interface method is provided here
        return "A Pop Artist sings.";
    } 

    //Create my tostring
    public override string ToString ()
    {
        return base.ToString() + " | Song Title: " + SongTitle + " | Sound: " + ArtistSound();
    }

  }
}
