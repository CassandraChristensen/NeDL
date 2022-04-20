using System;

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
      //Create a single object to test that the class Music is working 
      Music myMusic = new Music("Taylor Swift", "Peace");
      Music myMusic2 = new Music("Eminem", "Stan"); 

      //Call the ToString Console.WriteLine
      Console.WriteLine(myMusic);
      Console.WriteLine(myMusic2);
      myMusic2.GoatMethod();

    }
  }
}