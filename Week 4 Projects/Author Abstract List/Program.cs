using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //Test my Fantasy object///list
      List<FantasyAuthor> fantasyAuthorList = new List<FantasyAuthor>();   //This instantiated my list, created a new object and called my default constructor to instantiate the new object


      //Input data into the list 
      fantasyAuthorList.Add(new FantasyAuthor ("Maas", "Sarah", "A Court of Silver Flames", "Bloomsbury Publishing", 2016, 2));


      //Output data to console.
      foreach (FantasyAuthor anAuthor in fantasyAuthorList)
      {
      Console.WriteLine(anAuthor);
      }

    }//main
  } //class program
} //application