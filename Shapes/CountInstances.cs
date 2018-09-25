using System;

namespace Shapes
{
    class CountInstances
    {
        static int count = 0;

        public CountInstances()
        {
            count++;
        }

        public void NumOfInstances()
        {
            Console.WriteLine("There are currently {0} instances", count);
        }
    }
}
