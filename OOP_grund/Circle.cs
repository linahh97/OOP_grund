using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_grund
{
    class Circle
    {
        public float pi = 3.1415f;
        public int Radius;
        public float area;

        public float getArea()
        {
            area = Radius * Radius * pi;
            Console.WriteLine("Cirkelns area: {0}", area);
            return area;
        }
        public void getPerimeter()
        {
            Console.WriteLine("Cirkelns omkrets: " + (Radius + Radius) * pi);
        }
    }
}
