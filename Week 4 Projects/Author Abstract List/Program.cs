using System;
using System.Collections.Generic;

namespace MyApplication
{
  class Program
  {
    //GetValidIntMethod
    static int GetValidIntMethod(int lowValue, int highValue)
    {
        int value; 
        do
        {
        Console.WriteLine("Please enter a value that equal to or more than: " + lowValue + " and equal to or less than: " + highValue );
        value = Convert.ToInt32(Console.ReadLine());
        }
        while (value < lowValue || value > highValue);
        return value;
    } 

    static void Main(string[] args)
    {
      /* //Test my Fantasy object///list
      List<FantasyAuthor> fantasyAuthorList = new List<FantasyAuthor>();   //This instantiated my list, created a new object and called my default constructor to instantiate the new object
      List<ContemporaryAuthor> contemporaryAuthorList = new List<ContemporaryAuthor>();
      //Formula: List<Class> nameOfList = new List<Class>(); 

      //Input data into the list 
      fantasyAuthorList.Add(new FantasyAuthor ("Maas", "Sarah", "A Court of Silver Flames", "Bloomsbury Publishing", 2016, 1));
      contemporaryAuthorList.Add(new ContemporaryAuthor("Dessen", "Sarah", "Along for the Ride", "Penguin Random House", 2009, .5));
      //Forumula: nameOFList.Add(new Class (parameters being initialized and passed));


      //Output data to console.
      foreach (FantasyAuthor anAuthor in fantasyAuthorList)
      {
        Console.WriteLine(anAuthor);
      }

      foreach (ContemporaryAuthor anAuthor in contemporaryAuthorList)
      {
        Console.WriteLine(anAuthor);
      } */


      //Great these all work. Now Build a Crud App. 

       // Declare variables
        bool userChoice;
        string userChoiceString;
        List<FantasyAuthor> fantasyAuthorList = new List<FantasyAuthor>();
        List<ContemporaryAuthor> contemporaryAuthorList = new List<ContemporaryAuthor>();

      // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What's your pleasure? ");
                Console.WriteLine("L: Load the data file into an list.");
                Console.WriteLine("S: Save the list to the data file.");
                Console.WriteLine("C: Add a name to the list.");
                Console.WriteLine("R: Read a name from the list.");
                Console.WriteLine("U: Update a name in the list.");
                Console.WriteLine("D: Delete a name from the list.");
                Console.WriteLine("Q: Quit the program.");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "S" || userChoiceString == "s" ||
                            userChoiceString == "C" || userChoiceString == "c" ||
                            userChoiceString == "R" || userChoiceString == "r" ||
                            userChoiceString == "U" || userChoiceString == "u" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
                using (StreamReader sr = File.OpenText("authors.txt"))
                {
                    //create my variables
                    string addAuthorLastName;
                    string addAuthorFirstName;
                    char addAuthorGenre;
                    string addBookTitle;
                    string addPublishingCompany;
                    double addAnnualBooksPublished;
                    int addGoodreadsBestFantasy;
                    int addGoodreadsBestYA;

                    //Using a while loop, want to read lines while the line is not employ
                    while ((addAuthorLastName = sr.ReadLine()) != null)
                    {
                        addAuthorFirstName = sr.ReadLine();
                        addAuthorGenre = Convert.ToChar(sr.ReadLine());
                        addBookTitle = sr.ReadLine();
                        addPublishingCompany = sr.ReadLine();
                        addAnnualBooksPublished = Convert.ToDouble(sr.ReadLine());
                        addGoodreadsBestFantasy = Convert.ToInt32(sr.ReadLine());
                        addGoodreadsBestYA = Convert.ToInt32(sr.ReadLine());

                        //Create if statement to determine if Fantasy or Contemporary author
                        if (addAuthorGenre == 'F')
                        {
                            fantasyAuthorList.Add(new FantasyAuthor(addAuthorLastName, addAuthorFirstName, addAuthorGenre, addBookTitle, addPublishingCompany, addGoodreadsBestFantasy, addAnnualBooksPublished));
                        }
                        else 
                        {
                            contemporaryAuthorList.Add(new ContemporaryAuthor(addAuthorLastName, addAuthorFirstName, addAuthorGenre, addBookTitle, addPublishingCompany, addGoodreadsBestYA, addAnnualBooksPublished));
                        }

                    }
                   
                    foreach (FantasyAuthor anAuthor in fantasyAuthorList)
                    {
                        if (!(fantasyAuthorList != null))
                        Console.WriteLine(anAuthor);
                    }

                    foreach (ContemporaryAuthor anAuthor in contemporaryAuthorList)
                    {
                        if (!(contemporaryAuthorList != null))
                        Console.WriteLine(anAuthor);
                    }

                }
            }

        //  TODO: Else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");
            }

        //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

            else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
                //Prompt the user for the info to enter. 
                

                //Enter default variables that way i can validate user input
                string addAuthorLastName = "";
                string addAuthorFirstName = "";
                char addAuthorGenre = '\0';
                string addBookTitle = "";
                string addPublishingCompany = "";
                double addAnnualBooksPublished = 0;
                int addGoodreadsBestFantasy = 0;
                int addGoodreadsBestYA = 0;

                //Prompt the user for Last Name
                do
                {
                    Console.WriteLine("Please enter the author's last name.");
                    addAuthorLastName = Console.ReadLine();
                    if (addAuthorLastName == "")
                    {
                        Console.WriteLine("Entry was not valid, please enter author's last name.");
                    }
                } while (addAuthorLastName == "");


                //Prompt the user for First Name 
                do
                {
                    Console.WriteLine("Please enter the author's first name.");
                    addAuthorFirstName = Console.ReadLine();
                    if (addAuthorFirstName == "")
                    {
                        Console.WriteLine("Entry was not valid, please enter author's first name.");
                    }
                } while (addAuthorFirstName == "");


                //Prompt the user for Author's Genre (Either, F for Fantasy or C for Contemporary) This will be a char.
                do 
                {
                    Console.WriteLine("Please enter the author's Genre. Either, 'F' for Fantasy or 'C' for Contemporary. ");
                    addAuthorGenre = Convert.ToChar(Console.ReadLine());
                    if (addAuthorGenre != 'F' && addAuthorGenre != 'C')
                    {
                        Console.WriteLine("Entry was not valid. Please enter the author's Genre. Either, 'F' for Fantasy or 'C' for Contemporary.");
                    }
                } while (addAuthorGenre != 'F' && addAuthorGenre != 'C');


                //Prompt the user to enter a book title by the author
                do
                {
                    Console.WriteLine("Please enter a book title by the author.");
                    addBookTitle = Console.ReadLine();
                    if (addBookTitle == "")
                    {
                        Console.WriteLine("Entry was not valid, please a book title by the author.");
                    }
                } while (addBookTitle == "");


                //Prompt the user to enter the author's publishing company 
                do
                {
                    Console.WriteLine("Please enter the author's publishing company.");
                    addPublishingCompany = Console.ReadLine();
                    if (addPublishingCompany == "")
                    {
                        Console.WriteLine("Entry was not valid, please enter the author's publishing company.");
                    }
                } while (addPublishingCompany == ""); 


                //Prompt the user for average annual books published. This is a double
                
                Console.WriteLine("Please enter the average numbers of book's published by the author annually.");
                addAnnualBooksPublished = Convert.ToDouble(GetValidIntMethod(0,25));
               


                //Prompt the user for year of goodreads choice award. Using if loop because it will be different based on the author's genre.
                if (addAuthorGenre == 'F')
                {
                    Console.WriteLine("Please enter the Year the author won a Goodreads Choice award for Best Fantasy");
                    addGoodreadsBestFantasy = Convert.ToInt32(GetValidIntMethod(1999, 2023));
                    fantasyAuthorList.Add(new FantasyAuthor (addAuthorLastName, addAuthorFirstName, addAuthorGenre, addBookTitle, addPublishingCompany, addGoodreadsBestFantasy, addAnnualBooksPublished));
                    Console.WriteLine("This author has been added to the Fantasy Author List.");
                }
                else 
                {
                    Console.WriteLine("Please enter the Year the author won a Goodreads Choice award for best YA fiction award.");
                    addGoodreadsBestYA = Convert.ToInt32(GetValidIntMethod(1999,2023));
                    contemporaryAuthorList.Add(new ContemporaryAuthor(addAuthorLastName, addAuthorFirstName, addAuthorGenre, addBookTitle, addPublishingCompany, addGoodreadsBestYA, addAnnualBooksPublished));
                    Console.WriteLine("This author has been added to the Contemporary Author List.");
                }
                
            }  //else if

        //  TODO: Else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                foreach (FantasyAuthor anAuthor in fantasyAuthorList)
                {
                    if (!(fantasyAuthorList != null))
                    Console.WriteLine(anAuthor);
                }

                foreach (ContemporaryAuthor anAuthor in contemporaryAuthorList)
                {
                    if (!(contemporaryAuthorList != null))
                    Console.WriteLine(anAuthor);
                }
                
            }
        //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
            }

        //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
            }
        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));

    }//main
  } //class program
} //application