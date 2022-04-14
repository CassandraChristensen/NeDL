using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string writeText = "Hello NeDL again!";  // Create a text string
      File.WriteAllText("HelloNEDL.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("HelloNEDL.txt"); // Read the contents of the file
      Console.WriteLine(readText); // Output the content
    }
  }
}
