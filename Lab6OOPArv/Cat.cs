﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Cat : Animal
    {
        public bool isFriendly { get; set; }
        public Cat(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute, bool _isFriendly) : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            isFriendly = _isFriendly;
        }

        public override void Eat()
        {
            Console.WriteLine("Katten mumsar på lite kattmat");
        }

        public override void drink()
        {
            Console.WriteLine("Katten dricker vatten");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Mjau!*");
        }

        public void Play()
        {
            Console.WriteLine("Katten busar");
        }
    }
}
