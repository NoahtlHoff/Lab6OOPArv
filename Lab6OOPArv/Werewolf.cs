using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6OOPArv
{
    internal class Werewolf : FantasyCreature //subclass of FantasyCreature, ''grandchild'' of Animal
    {
        //new variables for this class:
        public bool huntsHumans { get; set; }
        public bool fullMoonUp { get; set; }
        public Werewolf(string _name = "Remus", string _eyeColor = "Grön", string _color = "Vit/brun", int _numberOfLegs = 2, bool _isCute = false, bool _isScary = false, bool _huntsHumans = false, bool _fullMoonUp = true) //new default values
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute, _isScary) //base variables
        {
            huntsHumans = _huntsHumans;
            fullMoonUp = _fullMoonUp;
        }
        //overridden methods from Dragon FantasyCreature Class (some originally from Animal Class)
        public override void Eat()
        {
            if (huntsHumans)
            {
                Console.WriteLine($"{name} jagar en människa svälja hel");
            }
            else
            {
                Console.WriteLine($"{name} äter vanlig människomat");
            }
        }

        public override void drink()
        {
            Console.WriteLine($"{name} dricker");
        }

        public override void makeSound()
        {
            Console.WriteLine("*howl*");
        }

        public override void Dance()
        {
            Console.WriteLine($"{name} dansar i månskenet");
        }
        //new method for this class, uses one of the new variables
        public void turnToMan()
        {
            if (fullMoonUp)
            {
                Console.WriteLine($"Fullmånen skiner och {name} blir en varulv igen!");
            }
            else
            {
                Console.WriteLine($"{name} verkar vara en vanlig människa?");
            }

        }

    }
}
