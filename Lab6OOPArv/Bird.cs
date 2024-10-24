using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Bird : Animal //subclass of animal
    {
        public int wings { get; set; } //new variable for this class
        public Bird(string _name = "Pingu", string _eyeColor = "Svart", string _color = "Svart/vit", int _numberOfLegs = 2, bool _isCute = true, int _wings = 2) //new default values
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute) //base variables
        {
            wings = _wings;
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
            Console.WriteLine("*Kvitter*");
        }
        //new methid for this class
        public void Fly()
        {
            Console.WriteLine($"{name} flyger");
        }
    }
}
