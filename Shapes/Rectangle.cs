using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle
    {
        public double CalculateArea(double length,double breadth)
        {
            return length * breadth;
        }
        public double CalculatePerimeter(double length, double breadth)
        {
            return 2 * (length + breadth);
        }

        
    }
}
