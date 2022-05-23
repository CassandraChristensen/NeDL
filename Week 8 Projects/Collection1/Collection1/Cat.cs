using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class Cat: Animal, IFood
    {
        //Create my attributes and property

        public bool LongHair { get; set; }

        
        //Create my constructors
        //Default constructor
        //Constructor with parameters

        public Cat (): base()
        {
            LongHair = false;
        }

        public Cat(string newBreed, bool newDomesticationStatus, bool newLongHair) : base(newBreed, newDomesticationStatus)
        {
            LongHair = newLongHair;
        }

        //abstract method override
        public override void animalSound()
        {
            Console.WriteLine("The " + Breed + " says meow meow");
        }

        //Interface method
        public void animalFood()
        {
            Console.WriteLine("The " + Breed + " eats pate and kibble.");
        }


        //tostring

        public override string ToString()
        {
            return base.ToString() + " | Long-hair: " + LongHair;
        }


    }
}
