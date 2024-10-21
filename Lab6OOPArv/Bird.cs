using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Bird : Animal
    {
        public int wings { get; set; }
        public Bird(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute, int _wings) : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            wings = _wings;
        }

        public override void Eat()
        {
            Console.WriteLine("Fågeln dricker äter");
        }

        public override void drink()
        {
            Console.WriteLine("Fågeln dricker");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Kvitter*");
        }

        public void Fly()
        {
            Console.WriteLine("Fågeln flyger");
        }
    }
}
