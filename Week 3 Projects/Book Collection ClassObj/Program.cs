using System; 

namespace bookCollection
{
    class Program
    {
        static void Main (string[] args)
        {
            //Declare and instantiate the array of Book Objects. This is only creting the array, not actually instantiating the objects.
            SignedBook [] signedBooks = new SignedBook [20];

            //Now, loop through each array element and instantiate a Book object for each
            //Note that the constructor with no parameters will be used. 
            for (int index = 0; index < signedBooks.Length; index++)
            {
                signedBooks[index] = new SignedBook();  //This is the defaul constructor and is instantiating each Book object.
            }

            //Load in some test data to test both ways to assign values
            signedBooks[0].setAuthorName("Sarah J Maas");
            signedBooks[0].title = ("ACOMAF");
            signedBooks[0].yearPublished = 2016;
            signedBooks[5].setAuthorName("V.E. Schwab");
            signedBooks[5].title = ("The Invisible Life of Addie LaRue");
            signedBooks[5].yearPublished = 2020;
            signedBooks[10].setAuthorName("Cassandra Clare");
            signedBooks[10].title = ("City of Bones");
            signedBooks[10].yearPublished = 2007;
            signedBooks[15] = new SignedBook ("Sarah J Maas", "HOSAB", 2022);
            signedBooks[19] = new SignedBook ("Melissa Marr", "Wicked Lovely", 2007);
            

            for (int index = 0; index < signedBooks.Length; index++)
            {
                if (!(((signedBooks[index]).getAuthorName())==null))
                    Console.WriteLine(signedBooks[index]);
            }
             
        } //Main
    } //program class
} //namespace
