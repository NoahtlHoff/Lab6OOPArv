using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Bird : Animal
    {
        public string name { get; set; }
        public string eyeColor { get; set; }
        public string color { get; set; }
        public int numberOfLegs { get; set; }
        public bool isCute { get; set; }
        public int wings { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Fågeln dricker äter");
        }
        public override void drink()
        {
            Console.WriteLine("Fågeln dricker");
        }
        public Bird(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute, int _wings) : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            wings = _wings;
        }
        public void Fly()
        {
            Console.WriteLine("Fågeln flyger");
        }
        public override void makeSound()
        {
            Console.WriteLine("Fågeln kvittrar");
        }
    }
}
