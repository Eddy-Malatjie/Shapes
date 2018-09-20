using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class CopyRectangle
    {
        
        public void MakeCopy()
        {
            Rectangle rectOriginal = new Rectangle();
            Rectangle rectCopy = rectOriginal;
        }
       public void MakeCopy(Rectangle rectOriginal)
        {
            Rectangle rectCopy = rectOriginal;        
        }
    }
}
