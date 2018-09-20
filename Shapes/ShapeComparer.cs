using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeComparer
    {
        public void CompareArea<ObjType>(ObjType objectArea1, ObjType objectArea2)
        {

            bool compareArea = objectArea1.Equals(objectArea2);

            if(compareArea)
            {
                Console.WriteLine("The areas are equal");
            }
            else
            {
                Console.WriteLine("The areas are not equal");
            }
        }

        public void ComparePerimeter<ObjType>(ObjType objectPerimeter1, ObjType objectPerimeter2)
        {

            bool comparePerimeter = objectPerimeter1.Equals(objectPerimeter2);

            if (comparePerimeter)
            {
                Console.WriteLine("The Perimeters are equal");
            }
            else
            {
                Console.WriteLine("The Perimeters are not equal");
            }
        }


    }
}
