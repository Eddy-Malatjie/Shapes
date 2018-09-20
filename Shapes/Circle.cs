using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle
    {
        private double PI = 3.14;
        // private double radius;

        public double CalculateRadius(double radius)
        {
            return ( PI *(radius * radius));
        }

        public double CalculateCircle(double radius)
        {
            return (2 * PI * radius);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle();
                       
            string rad = Console.ReadLine();
            double radius = Convert.ToInt32(rad);
            Console.WriteLine(C.CalculateRadius(radius));            
            Console.ReadKey();
        }  
    }
}
