using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_grund
{
    public class Circle
    {
        public float pi = 3.1415f;
        public int Radius;

        public void getArea()
        {
            Console.WriteLine("Cirkelns area: " + Radius * Radius * pi);
        }
        public void getPerimeter()
        {
            Console.WriteLine("Cirkelns omkrets: " + (Radius + Radius) * pi);
        }
    }
}
