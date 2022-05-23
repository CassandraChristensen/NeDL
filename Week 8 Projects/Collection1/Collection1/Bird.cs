using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class Bird: Animal
    {
        //attributes/properties
        public bool FlyingAbility
            { get; set; }

        //Constructor

        public Bird ()
        {
            FlyingAbility = false;
        }

        public Bird (string newBreed, bool newDomesticationStatus, bool newFlyingAbility): base(newBreed, newDomesticationStatus)
        {
           FlyingAbility = newFlyingAbility;
        }

        //abstract override method
        public override void animalSound()
        {
            Console.WriteLine("The" + Breed + " says chirp chirp.");
        }

        //tostring
        public override string ToString()
        {
            return base.ToString() + " | Ability to Fly: " + FlyingAbility;
        }
    }
}
