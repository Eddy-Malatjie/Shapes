using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle
    {
        private double _length;
        private double _breadth;

        public Rectangle(double Length,double Breadth)
        {
            _length = Length;
            _breadth = Breadth;
        }

        public double Area()
        {
            return _length * _breadth;
        }
        public double Perimeter()
        {
            return 2 * ( _length + _breadth);
        }

        public void rectangleCopy(Rectangle RCopy)
        {
            this._length = RCopy._length;
            this._breadth = RCopy._breadth;
        }

        public void CompareRects(Rectangle R)
        {
            if(this.Area() == R.Area())
            {
                Console.WriteLine("The area of the rectangles are equal");
            }
            else
            {
                Console.WriteLine("The area of the rectangles are not equal");
            }

            if(this.Perimeter() == R.Perimeter())
            {
                Console.WriteLine("The perimeter of the rectangles are equal");
            }
            else
            {
                Console.WriteLine("The perimeter of the rectangles are not equal");
            }
        }
      
    }
}
