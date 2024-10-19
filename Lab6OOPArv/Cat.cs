using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Cat : Animal
    {
        public string name { get; set; }
        public string eyeColor { get; set; }
        public string color { get; set; }
        public int numberOfLegs { get; set; }
        public bool isCute { get; set; }
        public bool isFriendly { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Katten mumsar på lite kattmat");
        }
        public override void drink()
        {
            Console.WriteLine("Katten dricker vatten");
        }
        public Cat(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute, bool _isFriendly) : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            isFriendly = _isFriendly;
        }
        public void Play()
        {
            Console.WriteLine("Katten busar");
        }
        public override void makeSound()
        {
            Console.WriteLine("*Mjau!*");
        }
    }
}
