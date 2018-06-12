using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab
{
    class OR_NOT: Element
    {
        
        public OR_NOT()
        {

        }
       
        static public ArrayList operation(int Index_j, int Index_i, int[,] input_nums)
        {

            
            for (int i = 0; i < Index_i; i++)
            {
                int res = 1;
                for (int j = 0; j < Index_j; j++)
                {

                    if ((input_nums[i, j] == 0) && (input_nums[i, j + 1] == 0))
                    {
                        res = 1;
                    }
                    else if ((input_nums[i, j] == 1) && (input_nums[i, j + 1] == 1))
                    {
                        res = 0;
                    }

                }

                result_operation_ornot.Add(res);

            }
            
            return result_operation_ornot;
        }
        

    }
}
