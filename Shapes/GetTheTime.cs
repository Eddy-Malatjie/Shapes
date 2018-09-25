using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class GetTheTime
    {
       void GetTime(string format, string date)
        {

            if(format == "seconds")
            {
                Console.WriteLine(TimeSpan.Parse(date).TotalSeconds);
            }
            else if(format == "milliseconds")
            {
                Console.WriteLine(TimeSpan.Parse(date).TotalMilliseconds);
            }
        }
        
    }
}
