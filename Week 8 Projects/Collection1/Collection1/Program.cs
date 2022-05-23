using System;
using System.Collections.Generic;

namespace Collection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Hardcode data
            Cat myCat = new Cat();
            myCat.Breed = "Tabby";
            myCat.LongHair = true;
            myCat.DomesticationStatus = true;
            myCat.animalSound();
            myCat.animalFood();
            

            Bird myBird = new Bird();
            myBird.Breed = "Chicken";
            myBird.DomesticationStatus = true;
            myBird.FlyingAbility = false;
            myBird.animalSound();
            


            //Print hardcoded data to screen 
            Console.WriteLine(myCat);
            Console.WriteLine(myBird);

            //Create two lists: One for cat and one for bird 
            List<Cat> catList = new List<Cat>();
            List<Bird> birdList = new List<Bird>();

            //initialize my flag for looping
            bool loopFlag = true;

            string userChoice;

            while(loopFlag)
            {
                Console.WriteLine("1. Add an animal to the list");
                Console.WriteLine("2. Print the list");
                Console.WriteLine("3. Quit");
                Console.WriteLine("Please enter a 1, 2 or 3: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("Which list would you like to add to?");
                    Console.WriteLine("1. Cat");
                    Console.WriteLine("2. Bird");
                    string listType = Console.ReadLine();

                    if (listType == "1")
                    {
                        Console.WriteLine("What is the cat's breed?");
                        string newBreed = Console.ReadLine();

                        Console.WriteLine("Is the cat long-hair?");
                        bool longHair = Convert.ToBoolean(Console.ReadLine());

                        Console.WriteLine("Is the cat domesticated?");
                        bool domestication = Convert.ToBoolean(Console.ReadLine());

                        catList.Add(new Cat(newBreed, domestication, longHair));
                    }
                    else
                    {
                        Console.WriteLine("What is the bird's breed?");
                        string newBreed = Console.ReadLine();

                        Console.WriteLine("Is the bird domesticated?");
                        bool domestication = Convert.ToBoolean(Console.ReadLine());

                        Console.WriteLine("Is the bird able to fly?");
                        bool flying = Convert.ToBoolean(Console.ReadLine());

                        birdList.Add(new Bird(newBreed, domestication, flying));

                  

                    }
                } //end userChoice 1
                else if (userChoice == "2")
                {
                    foreach (Cat aCat in catList)
                    {
                        Console.WriteLine(aCat);
                    }

                    foreach (Bird aBird in birdList)
                    {
                        Console.WriteLine(aBird);
                    }
                } //end userChoic 2
                else if (userChoice == "3")
                {
                    Console.WriteLine("Goodbye!");
                    loopFlag = false;
                }
                else
                {
                    Console.WriteLine("Error please enter in an option on the user menu.");
                }

            }//end while loop
            




        }
    }
}
