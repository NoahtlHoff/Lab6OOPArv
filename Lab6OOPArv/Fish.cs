using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Fish : Animal //subclass to animal
    {
        public bool isPredator { get; set; }
        public Fish(string _name = "Doris", string _eyeColor = "Gul", string _color = "Blå", int _numberOfLegs = 0, bool _isCute = true, bool _isPredator = true) //change default values from animal
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute) //base variables
        {
            isPredator = _isPredator;
        }

        public override void Eat()
        {
            if (isPredator)
            {
                Console.WriteLine($"{name} hittade en mindre fisk att sätta tänderna i");
            }
            else
            {
                Console.WriteLine($"{name} åt lite växter");
            }

        }
        //override methods frombaseclass
        public override void drink()
        {
            Console.WriteLine($"{name} dricker.. dricker fiskar verkligen?");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Blub blub*");
        }
        //new method for this class
        public void Swim()
        {
            Console.WriteLine($"{name} simmar snabbt!");
        }
    }
}
