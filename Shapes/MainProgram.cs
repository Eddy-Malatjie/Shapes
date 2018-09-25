using System;

namespace Shapes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            /* CountInstances count1 = new CountInstances();
             CountInstances count2 = new CountInstances();
             CountInstances count3 = new CountInstances();
             CountInstances count4 = new CountInstances();
             CountInstances count5 = new CountInstances();
             CountInstances count6 = new CountInstances();
             count1.NumOfInstances();*/

            //Circle C1 = new Circle(3.5);
            //Circle C2 = new Circle(3.5);
            //double CircleArea = C1.Area();
            //double CirclePerimeter = C1.Perimeter();
            //Console.WriteLine("The area of the circle is {0} and the perimeter is equal {1}", CircleArea, CirclePerimeter);
            //Console.WriteLine(C1.Equals(C2));

            //Square S1 = new Square(3.5);
            //double SquareArea = S1.Area();
            //double SquarePerimeter = S1.Perimeter();
            //Console.WriteLine("The area of the circle is {0} and the perimeter is equal {1}", SquareArea, SquarePerimeter);

            //Rectangle R1 = new Rectangle(4, 5);
            //Rectangle R2 = new Rectangle(5, 4);
            //R1.rectangleCopy(R2);
            //Console.WriteLine("The area of the circle is {0} and the perimeter is equal {1}", R2.Area(), R2.Perimeter());
            //R1.CompareRects(R2);

            //double RectangleArea = R1.Area();
            //double RectanglePerimeter = R1.Perimeter();
            //Console.WriteLine("The area of the circle is {0} and the perimeter is equal {1}", RectangleArea, RectanglePerimeter);

            LogFileReader FR = new LogFileReader(1);
            FR.ReadFiles();

            Console.ReadKey();
        }
    }
}