using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Printer
    {
      public virtual void Print(DateTime date)
        {
            Console.WriteLine(date);
        }
        
    }
    class ChangeFormat:Printer
    {
       public override void Print(DateTime date)
        {
            string date1 = date.ToString("ddd dd MMM yyyy hh:mm:ss");

            Console.WriteLine(date1);
        }
    }
}
