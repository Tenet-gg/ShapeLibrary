using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius isn't a positive double number");
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
