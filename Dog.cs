﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    internal class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("멍멍"); }
    }
}
