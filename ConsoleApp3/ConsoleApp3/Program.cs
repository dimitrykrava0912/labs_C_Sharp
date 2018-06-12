using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelope[] envelops = { new Envelope(5, 1), new Envelope(5, 1), new Envelope(5, 1), new Envelope(5, 1) };
            Letter[] letters = { new Letter(5, 1), new Letter(6, 3), new Letter(4.3, 4.3), new Letter(4, 1) };
            for (int i = 0; i < envelops.Length; i++) 
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j].Is_Placed)
                    {
                        continue;
                    }
                    envelops[i].IsOkey(letters[j]);
                    if (envelops[i].IsOkey(letters[j]))
                    {
                        break;
                    }
                }
               
            }
            for (int i = 0; i < envelops.Length; i++)
            {
                try
                {
                    Console.WriteLine("#Конверт № "+i+Environment.NewLine
                        +"Мiстить лист "+envelops[i].nested_letter.Is_Placed+
                        Environment.NewLine+"Кут повороту листа:"+envelops[i].nested_letter.Angle + Environment.NewLine);
                }
                catch (Exception)
                {
                    Console.WriteLine("#Конверт № " + i + Environment.NewLine
                        + "Мiстить лист :NO LIST"  +
                        Environment.NewLine + "Кут повороту листа: FAULSE" + Environment.NewLine );
                }
            }
            Console.ReadKey();
        }
    }
}
