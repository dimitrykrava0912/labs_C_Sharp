using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab
{
    public class Scheme
    {
        static public ArrayList result = new ArrayList();
        public int input { get; set; }
        public char symbol_id { get; set; }
        public int number_elements { get; set; }

        public Scheme(int Inputs, char Symbol_id, int Number_elements)
        {
            input = Inputs;
            symbol_id = Symbol_id;
            number_elements = Number_elements;
        }
        

        public override string ToString()
        {
                     
            return "Inputs" + "\t" + "Symbol id" + "\t" + "Number of elemnts" + "\n" +
                input.ToString() + "\t" + symbol_id.ToString() + "\t\t" + number_elements.ToString() + "\n" +
                "Your result";
        }

    }
}
