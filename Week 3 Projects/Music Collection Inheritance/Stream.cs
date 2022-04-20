using System;

namespace MyApplication
{
  class Stream : Music //Stream = Child(Derived) Class: Music = Parent(Base) Class
  {

      //Create my private fields
    /* private long numberStreams;

    private string mostStreamedAlbum; */

    public string mostStreamedAlbum    // property shorthand
      { get; set; } 

    public long numberStreams
    { get; set; }

    //Create my default constructor
    public Stream ()
    {
        numberStreams = -1;
        mostStreamedAlbum = null;
    }

    //Create my constructor that will allow my to pass my private variables
    /* public Stream (long aNumberStreams, string theMostStreamedAlbum) //: base(aArtistName, aSongTitle)
    {
        numberStreams = aNumberStreams;
        mostStreamedAlbum = theMostStreamedAlbum;

    } */

    public override string ToString ()
    {
        return getArtistName() + " total number of streams on spotify is: " + numberStreams + " and their most streamed album is: " + mostStreamedAlbum + " while their most listened to song is: " + SongTitle;
    }

    public override void SingMethod ()
    {
        Console.WriteLine( getArtistName() + " sings.");
    }


  } //class Stream
} //namespace