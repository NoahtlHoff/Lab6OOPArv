using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Cat : Animal //subclass of animal
    {
        public bool isFriendly { get; set; } //new variable for this class
        public Cat(string _name = "Gustaf", string _eyeColor = "Gröna", string _color = "Orange", int _numberOfLegs = 4, bool _isCute = true, bool _isFriendly =false) //new default values
            : base(_name, _eyeColor, _color, _numberOfLegs, _isCute) //base variables
        {
            isFriendly = _isFriendly;
        }
        //overridden methods from Animal Class
        public override void Eat()
        {
            if(name == "Gustaf")
            {
                Console.WriteLine($"{name} mumsar på lite lasagne");
            }
            else
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
        //new method for this class
        public void Play()
        {
            Console.WriteLine($"{name} busar");
        }
    }
}
