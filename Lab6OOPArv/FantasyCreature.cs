using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6OOPArv
{
    class FantasyCreature : Animal //subclass of Animal
    {
        public bool isScary { get; set; }
        public FantasyCreature(string _name = "Shrek", string _eyeColor = "Svart", string _color = "Grön", int _numberOfLegs = 2, bool _isCute = true, bool _isScary = false)
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            isScary = _isScary;
        }
        //overridden methods from Animal Class
        public override void Eat()
        {
            Console.WriteLine($"{name} äter");
        }

        public override void drink()
        {
            Console.WriteLine($"{name} dricker");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Rawr*");
        }
        //new method for this class, virutal so it can be overridden
        public virtual void Dance()
        {
            Console.WriteLine($"{name} Dansar!");
        }
    }
}
