using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Cat : Animal
    {
        public bool isFriendly { get; set; }
        public Cat(string _name = "Gustaf", string _eyeColor = "Gröna", string _color = "Orange", int _numberOfLegs = 4, bool _isCute = true, bool _isFriendly =false)
            : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            isFriendly = _isFriendly;
        }

        public override void Eat()
        {
            if(name == "Gustaf")
            {
                Console.WriteLine($"{name} mumsar på lite lasagne");
            }
            {
                Console.WriteLine($"{name} mumsar på lite kattmat");
            }
        }

        public override void drink()
        {
            Console.WriteLine($"{name} dricker vatten");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Mjau!*");
        }

        public void Play()
        {
            Console.WriteLine($"{name} busar");
        }
    }
}
