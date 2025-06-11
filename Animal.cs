using System;

namespace PolyExample
{
    internal class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("챱챱"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
    }
}