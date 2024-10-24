using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    internal class Dragon : FantasyCreature //subclass of FantasyCreature, ''grandchild'' of Animal
    {
        public int treasureValue { get; set; } //new veriable for this class
        public Dragon(string _name = "Smaug", string _eyeColor = "Röd", string _color = "Röd", int _numberOfLegs = 2, bool _isCute = false, bool _isScary = true, int _treasureValue = 1000) //new default values
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute, _isScary)
        {
            treasureValue = _treasureValue;
        }
        //overridden from Animal:
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
        //overridden from FantasyCreature
        public override void Dance()
        {
            Console.WriteLine($"{name} dansar på alla skatter den samlat ihop!");
        }
    }
}
