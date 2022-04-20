using System; 

namespace bookCollection
{
    class SignedBook
    {
        //Three pieces of data are being stored for each object. 
        //author is the author's name. To show the difference in how values can be stored, 
        //author will be an instance variable. 
        //title is the book title. Tos how the difference in how values can be stored, 
        //title will be an automatic property.
        private string author;
        public int yearPublished;

        //This is the automatic property variable. The get and set methods are being created too. 
        public string title
        {get; set; }


        //Create a default constructor when no values are being passed.
        public SignedBook ()
        {
            author = null;
            title = null;
            yearPublished = -1;

        }

         //Create a constructor passing 3 parameters 
        public SignedBook (string newAuthor, string newTitle, int yearBookPublished)
        {
            author = newAuthor;
            title = newTitle;
            yearPublished = yearBookPublished;
        }

        //Define author as a property 
        public string getAuthorName()
        {
            return author;
        }
        public void setAuthorName(string newAuthorName)
        {
            author = newAuthorName;
        }

        //This overrides ToString so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return "Book author: " + author + " | Book Title: " + title + " | Year Published: " + yearPublished; 
        }
    }//Class Restaurant
}