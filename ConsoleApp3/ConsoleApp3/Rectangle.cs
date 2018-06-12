using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Rectangle
    {
        double width;
        double heighth;
        public
            double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value>0)
                {
                    width = value;
                    return;
                }
                throw new ArgumentOutOfRangeException("width");
            }
        }
        
          public double Heighth
        {
            get
            {
                return heighth;
            }
            set
            {
                if (value > 0)
                {
                    heighth = value;
                    return;
                }
                throw new ArgumentOutOfRangeException("heighth");
            }
        }
    }
}
