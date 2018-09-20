using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class EqualCircles
    {
        public bool EqualCircle(Circle circle1, Circle circle2)
        {
            if(circle1.Equals(circle2))
            {
                return true;
            }    
            else
            {
                return false;
            }
        }
    }
}
