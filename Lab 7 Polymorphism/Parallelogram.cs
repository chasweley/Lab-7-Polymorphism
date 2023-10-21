using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Parallelogram : Geometry //Creating subclass for Parallelogram inheriting from Geometry
    {
        public double Height { get; } //Setting fields
        public double Width { get; }

        public Parallelogram() //Constructor to assign variable value
        {
            Height = 8.0;
            Width = 9.0;
        }

        public override double Area() //Override of parent class method to calculate parallelogram area
        {
            return Height * Width;
        }
    }
}
