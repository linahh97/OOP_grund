using System;

namespace OOP_grund
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 5;
            myCircle.getArea();
            myCircle.getPerimeter();
            Console.WriteLine("");
           
            Circle myCircle2 = new Circle();
            myCircle2.Radius = 6;
            myCircle2.getArea();
            myCircle2.getPerimeter();
            Console.WriteLine("");

            Triangle myTriangle = new Triangle();
            myTriangle.Base = 4;
            myTriangle.Length = 3;
            myTriangle.triArea();
            Triangle myTriangle2 = new Triangle();
            myTriangle2.Base = 4;
            myTriangle2.Length = 3;
            myTriangle2.triPerimeter();
        }
    }
}
