using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Square : Geometry //Creating subclass for Square inheriting from Geometry
    {
        public double Side { get; } //Setting field
        public Square() //Constructor to assign variable value
        {
            Side = 7.4;
        }

        public override double Area() //Override of base class method to calculate square area
        {
            return Side * 2;
        }
    }
}
