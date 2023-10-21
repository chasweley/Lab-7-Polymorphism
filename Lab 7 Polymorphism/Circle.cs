using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Circle : Geometry //Creating subclass for circle inheriting from Geometry
    {
        public double Radius { get; } //Setting field
        public Circle() //Constructor to assign variable value
        {
            Radius = 4;
        }
        public override double Area() //Override of base class method to calculate circle area
        {
            return Radius * Radius * Math.PI;
        }
    }
}
