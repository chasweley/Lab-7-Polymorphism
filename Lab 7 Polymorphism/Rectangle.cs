using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Rectangle : Geometry //Creating subclass for Rectangle inheriting from Geometry
    {
        public double Height { get; } //Setting properties
        public double Width { get; }

        public Rectangle() //Constructor to assign variable value
        {
            Height = 5.2;
            Width = 10.1;
        }
        public override double Area() //Override of base class method to calculate rectangle area
        {
            return Height * Width;
        }
    }
}
