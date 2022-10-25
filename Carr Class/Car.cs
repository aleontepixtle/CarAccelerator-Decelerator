// Author: Andres Leon T
// Date: 07/23/22
// Class Name: Car.cs
// Purpose: this file creates a class named Car to be used as an object
// in the car class program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carr_Class
{
    class Car
    {
        // fields for Year, Make, Speed
        private int _year, _speed;
        private string _make;

        // Car constructor with values pre-assigned
        public Car ()
        {
            _speed = 0;
            _year = 1965;
            _make = "Ford Pinto";
        }

        // Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Speed property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        // methods for accelerate and brake
        public void Accelerate()
        {
            _speed += 5;
        }

        public void Brake()
        {
            _speed -= 5;
        }
    }
}
