using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    static class DateTimeHelper
        {
       static double _time;
       static string now = DateTime.Now.ToString(); 
       public static DateTime Tomorrow
            {
                get { return DateTime.Now.AddDays(1); }
            }
        public static double Second(string format)
        {
            if (format == "seconds")
            {
              _time = TimeSpan.Parse(now).TotalSeconds;
            }
            else if (format == "milliseconds")
            {
                _time = TimeSpan.Parse(now).TotalMilliseconds;
            }

            return _time;
        }
     
    }
 }
