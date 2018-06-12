using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    abstract class Element
    {
        static public ArrayList result_operation_ornot = new ArrayList();
        static public ArrayList result_operation_andnot = new ArrayList();
        public int input { get; set; }
        public char symbol_id { get; set; }
        public int number_elements { get; set; }
        public int[,] input_num = new int[10,10];
        public string[] input_id = new string[100];

    }
}
