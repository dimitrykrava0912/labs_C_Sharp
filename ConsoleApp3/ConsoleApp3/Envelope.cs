using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Envelope:Rectangle
    {
        
        public
            Letter nested_letter
        { get; set; }

        public bool IsOkey (Letter ltr)
        {
            double letter_width_equivalent;
            double letter_heighth_equivalent;
            double alpha_step = 1;
            double betta;
            for (double alpha = 0; alpha < 90; alpha+=alpha_step)
            {
                betta = 90 - alpha;
                letter_width_equivalent = ltr.Width * Math.Cos(Deg_to_Rad(alpha)) + ltr.Heighth * Math.Cos(Deg_to_Rad(betta));
                letter_heighth_equivalent = ltr.Width * Math.Sin(Deg_to_Rad(alpha)) + ltr.Heighth * Math.Sin(Deg_to_Rad(betta));

                if (Width>=letter_width_equivalent && Heighth>=letter_heighth_equivalent)
                {
                    ltr.Angle = alpha;
                    nested_letter = ltr;
                    ltr.Is_Placed = true;
                    return true;
                }
            }
            return false;
        }

        public double Deg_to_Rad(double dec)
        {
            
                return dec*Math.PI/180;
        }

        public Envelope(double width,double heighth)
        {
            Width = width;
            Heighth = heighth;
        }
    }
}
