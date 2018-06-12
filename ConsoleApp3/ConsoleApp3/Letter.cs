using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Letter:Rectangle
    {
        double angle;
        public double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                if (value>=0 && value<=90)
                {
                    angle = value;
                    return;
                }
               
                throw new ArgumentOutOfRangeException("angle");
            }
        }
        public bool Is_Placed { get; set; }
        public Letter(double width, double heighth)
        {
            Width = width;
            Heighth = heighth;
            Is_Placed = false;
        }

    }
}
