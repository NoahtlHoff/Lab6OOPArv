﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    class Bird : Animal
    {
        public int wings { get; set; }
        public Bird(string _name = "Pingu", string _eyeColor = "Svart", string _color = "Svart/vit", int _numberOfLegs = 2, bool _isCute = true, int _wings = 2) 
             : base(_name, _eyeColor, _color, _numberOfLegs, _isCute)
        {
            wings = _wings;
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} dricker äter");
        }

        public override void drink()
        {
            Console.WriteLine($"{name} dricker");
        }

        public override void makeSound()
        {
            Console.WriteLine("*Kvitter*");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} flyger");
        }
    }
}
