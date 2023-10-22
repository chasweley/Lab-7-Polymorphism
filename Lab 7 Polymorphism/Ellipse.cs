using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Ellipse : Geometry //Creating subclass for Ellipse inheriting from Geometry
    {
        public double Radius1 { get; set; } //Setting properties
        public double Radius2 { get; set; }

        public Ellipse() //Constructor to assign variables value
        {
            Radius1 = 4.7;
            Radius2 = 6.0;
        }

        public override double Area() //Override of base class method to calculate ellipse area
        {
            return Radius1 * Radius2 * Math.PI;
        }

    }
}
