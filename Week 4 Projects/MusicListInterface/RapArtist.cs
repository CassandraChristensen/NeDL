using System;

namespace MyApplication
{
  class RapArtist : Music, IArtistSound
  {
    //Create my properties 
    public string SongTitle
    { get; set; }


    //Default constructor
    public RapArtist ()
    {
        SongTitle = "";
    }

    //Constructor with parameters
    public RapArtist(string newLastName, string newFirstName, string newRecordLabel, string newSongTitle) : base(newLastName, newFirstName, newRecordLabel)
    {
        SongTitle = newSongTitle;
    }

    //Create my ArtistSound interface
    public string ArtistSound()
    {
        //the body of the interface method is provided here
        return "A Rap artists raps.";
    }

    //Create my tostring
    public override string ToString ()
    {
        return base.ToString() + " | Song Title: " + SongTitle + " | Sound: " + ArtistSound();
    }

  }
}