using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPArv
{
    abstract class Animal //sed abstract Class to prevent it to be initialized
    {
        public string name { get; set; } 
        public string eyeColor { get; set; }
        public string color { get; set; }
        public int numberOfLegs { get; set; }
        public bool isCute { get; set; }

        public Animal(string _name = "Kalle", string _eyeColor = "Svart", string _color = "Brun", int _numberOfLegs = 4, bool _isCute = true) //Default values for variables
        {
            name = _name;
            eyeColor = _eyeColor;
            color = _color;
            numberOfLegs = _numberOfLegs;
            isCute = _isCute;
        }
        //Empty virutal methods to be overridden by subclasses
        public virtual void Eat() { }
        public virtual void drink() { }
        public virtual void makeSound() { }
    }
}
