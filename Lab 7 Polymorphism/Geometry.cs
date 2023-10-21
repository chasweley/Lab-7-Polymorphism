using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    public class Geometry //Creating base class
    {
        public virtual double Area() //Creating virtual method for subclasses to override
        {
            return 0; //return value zero since no specific shape to calculate area exists in this class
        }
    }
}
