using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square
    {
        public double CalculateArea(double length)
        {
            return length * length;
        }
        public double CalculatePerimeter(double length)
        {
            return 4 * length;
        }
    }
}
