using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    abstract class Animal
    {
        //make attributes properties using get/set
        //Animal Species
        //Is the animal domesticated or wild 
        public string Breed
        { get; set; }

       public bool DomesticationStatus
        { get; set; }


        //constructors 

        //default constructor
        public Animal ()
        {
            Breed = "";
            DomesticationStatus = false;

        }

        //constructor with passing parameters.
        public Animal (string newBreed, bool newDomesticationStatus)
        {
            Breed = newBreed;
            DomesticationStatus = newDomesticationStatus;
        }

        //Abstract method
        public abstract void animalSound();

        public override string ToString()
        {
            return "Breed type: " + Breed + " | The animal is domesticated: " + DomesticationStatus;
        }
    }
}
