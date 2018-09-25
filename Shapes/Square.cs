using System;

namespace Shapes
{
    class Square
    {
        private double _length;
        
        public Square(double Length)
        {
            _length = Length;
        }

        public double Area()
        {
            return _length * _length;
        }
        
        public double Perimeter()
        {
            return 4 * _length;
        }
        public void CompareSquare(Square S)
        {
            if (this.Area() == S.Area())
            {
                Console.WriteLine("The area of the rectangles are equal");
            }
            else
            {
                Console.WriteLine("The area of the rectangles are not equal");
            }

            if (this.Perimeter() == S.Perimeter())
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
