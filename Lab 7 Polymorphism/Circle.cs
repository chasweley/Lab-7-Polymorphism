using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle() 
        {
            Radius = 4;
        }
        public override double Area(double radius, double y)
        {
            return radius * radius * Math.PI;
        }
    }
}
