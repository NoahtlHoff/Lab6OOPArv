﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    abstract class Animal
    {

        public string name { get; set; }
        public string eyeColor { get; set; }
        public string color { get; set; }
        public int numberOfLegs { get; set; }
        public bool isCute { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("djuret äter");
        }
        public virtual void drink()
        {
            Console.WriteLine("Djuret dricker");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("Djuret gör ett läte");
        }

        public Animal(string _name, string _eyeColor, string _color, int _numberOfLegs, bool _isCute)
        {
            name = _name;
            eyeColor = _eyeColor;
            color = _color;
            numberOfLegs = _numberOfLegs;
            isCute = _isCute;
        }
    }
}