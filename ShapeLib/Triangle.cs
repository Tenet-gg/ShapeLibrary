using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Triangle : Shape
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }

        public Triangle (double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("The side length isn't a positive double number");
            if (a > b + c || b > a + c || c > a + b)
                throw new ArgumentException("Impossible shape for a triangle");
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public override double Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public bool IsRight()
        {
            return (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) ||
                (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) ||
                (Math.Pow(SideC, 2) == Math.Pow(SideB, 2) + Math.Pow(SideA, 2));
        }
    }
}
