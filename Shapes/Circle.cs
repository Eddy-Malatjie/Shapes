using System;

namespace Shapes
{
    class Circle
    {
        private double _radius;
        private double PI = 3.14159;

        public Circle(double Radius)
        {
            this._radius = Radius;
        }

        public double Area()
        {
            return PI * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * PI * _radius;
        }

        public bool Equals(Circle c)
        {
            if(this._radius == c._radius)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void CompareCircle(Circle C)
        {
            if (this.Area() == C.Area())
            {
                Console.WriteLine("The area of the rectangles are equal");
            }
            else
            {
                Console.WriteLine("The area of the rectangles are not equal");
            }

            if (this.Perimeter() == C.Perimeter())
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
