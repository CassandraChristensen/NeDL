using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create a Music Object
      /* List<Music> musicList = new List<Music>();
      List<PopArtist> popArtistList = new List<PopArtist>();
      List<RapArtist> rapArtists = new List<RapArtist>(); */

      List<Music> musicArtistList = new List<Music>();

      //Input data into it 
      /* musicList.Add(new Music("Swift", "Taylor", "Republic Records"));
      popArtistList.Add(new PopArtist("Cyrus", "Miley", "Columbia Records", "Wrecking Ball"));
      rapArtists.Add(new RapArtist("Mathers", "Marshall", "Interscope", "Stan")); */

      musicArtistList.Add(new Music("Swift", "Taylor", "Republic Records"));
      musicArtistList.Add(new PopArtist("Cyrus", "Miley", "Columbia Records", "Wrecking Ball"));
      musicArtistList.Add(new RapArtist("Mathers", "Marshall", "Interscope", "Stan"));


      //output to console
      /* foreach (Music anArtist in musicList)
      {
          Console.WriteLine(anArtist);
      }

      foreach (PopArtist anArtist in popArtistList)
      {
          Console.WriteLine(anArtist);
      }

      foreach (RapArtist anArtist in rapArtists)
      {
          Console.WriteLine(anArtist); */


      foreach (Music anArtist in musicArtistList)
      {
          Console.WriteLine(anArtist);
      }
      
    } //main
  } //class
} //Namespace

