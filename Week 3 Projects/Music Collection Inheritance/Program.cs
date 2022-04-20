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

      //Create single objects to test that the class Music is working. Use get/set method though. Both short and long hand. 
      Music myMusic = new Music();
      myMusic.SongTitle = "Goodnight My Angel";
      myMusic.setName("Billy Joel");

      Music myMusic2 = new Music();
      myMusic2.setName("Eminem");
      myMusic2.SongTitle = "Stan";

      //Call the ToString Console.WriteLine
      Console.WriteLine(myMusic);
      Console.WriteLine(myMusic2);

      //Call method
      myMusic2.GoatMethod();

    }
  }
}