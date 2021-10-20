using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_grund
{
    public class Triangle
    {
        public int Base;
        public int Length;

        public void triArea()
        {
            Console.WriteLine("Triangelns area: " + Base * Length / 2);
        }
        public void triPerimeter()
        {
            Console.WriteLine("Triangelns omkrets: " + (Base + Base + Length));
        }
    }
}
