using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6OOPArv
{
    class FantasyCreature : Animal
    {
        public bool hasGlasses { get; set; }
        public FantasyCreature(string _name = "Shrek", string _eyeColor = "Svart", string _color = "Grön", int _numberOfLegs = 2, bool _isCute = true, bool hasGlasses = false)
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            wings = _wings;
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} dricker äter");
        }

        public override void drink()
        {
            Console.WriteLine($"{name} dricker");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Kvitter*");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} flyger");
        }
    }
}
