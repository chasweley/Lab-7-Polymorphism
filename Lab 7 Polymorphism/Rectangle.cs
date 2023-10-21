using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public override double Area(double height, double width)
        {
            return height * width;
        }
    }
}
