using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Fish : Animal
    {
        public bool huntsFish { get; set; }
        public Fish(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute, bool _huntsFish) : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            huntsFish = _huntsFish;
        }

        public override void Eat()
        {
            Console.WriteLine("Fisken hittade en mindre fisk att sätta tänderna i");
        }

        public override void drink()
        {
            Console.WriteLine("Fisken dricker(?).. hmmm...");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Blub blub*");
        }

        public void Swim()
        {
            Console.WriteLine("Fisken simmar snabbt!");
        }
    }
}
