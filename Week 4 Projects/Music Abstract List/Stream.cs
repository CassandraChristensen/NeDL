using System;

namespace MyApplication
{
  class Stream : Music  // Derived : Base
  { 
    //Create my properties 

    public string MostStreamedAlbum
    { get; set; }

    public int NumberStreams
    { get; set; }


    //Create my default constructor 
    public Stream ()
    {
        MostStreamedAlbum = "";
        NumberStreams = 0;
    }

    //Create my constructor with multiple parameters
    public Stream (string newArtistName, string newSongTitle, string aMostStreamedAlbum, int newNumberStreams) : base(newArtistName, newSongTitle)
    {
        MostStreamedAlbum = aMostStreamedAlbum;
        NumberStreams = newNumberStreams;
    }

    //Create my abstract Method
    public override int ArtistAbstractTest ()
    {
        return NumberStreams % 2;
    }

    //Create my ToString Method
    public override string ToString ()
    {
        return base.ToString() + ". | Number of streams: " + NumberStreams + ". | Modulus of 2: " + ArtistAbstractTest();
    }
  }
}