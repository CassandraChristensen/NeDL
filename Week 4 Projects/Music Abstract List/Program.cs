using System;
using System.Collections.Generic;  //need this to be able to create my lists

namespace MyApplication
{
  class Program
  { 
    static void Main(string[] args)
    {
      //Create an object list for Stream
      List<Stream> streamList = new List<Stream>();

      //Create an object list for Billboard
      List<Billboard> billboardList = new List<Billboard>();

      //Input data into them 
      streamList.Add(new Stream ("Eminem", "Stan", "MMLP", 100));
      billboardList.Add(new Billboard("Taylor Swift", "All Too Well", 45));


      //Print the info 
      foreach (Stream aStream in streamList)
      {
          Console.WriteLine(aStream);
      }

      foreach (Billboard aBillboard in billboardList)
      {
          Console.WriteLine(aBillboard);
      }

    }
  }
}
