using System;

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
      //Create a single object to test that the class Music is working. Use a constructor to pass the variables.
      /* Music myMusic = new Music("Taylor Swift", "Peace");
      Music myMusic2 = new Music("Eminem", "Stan");  */

      //Create a single object to test that the Stream class is working. 
      /* Stream myStream = new Stream(25000000000, "The Slim Shady LP"); */

      //Create a single object to test that the Billboard class is working.
      /* Billboard myBillBoard = new Billboard(31); */ 
        
      //Create single objects to test that the class Music is working. Use get/set method though. Both short and long hand. 
      Music myMusic = new Music();
      myMusic.setName("Eminem");
      myMusic.SongTitle = "Stan";

      //Create an object to test that the class Stream is working.
      Stream myStream = new Stream ();
      myStream.setName("Taylor Swift");
      myStream.SongTitle = "All Too Well";
      myStream.numberStreams = 3100000000;
      myStream.mostStreamedAlbum = "Red";

      //Create an object to test that the class Billboard is working.
      Billboard myBillboard = new Billboard ();
      myBillboard.setName("Billy Joel");
      myBillboard.SongTitle = "Goodnight my Angel";
      myBillboard.topTen = 3;

      //Call the ToString Console.WriteLine
      Console.WriteLine(myMusic);
    
      Console.WriteLine(myStream);

      Console.WriteLine(myBillboard);

      //Call method
      myMusic.GoatMethod();

      myStream.GoatMethod();

      myBillboard.GoatMethod();


    }
  }
}