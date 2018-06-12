using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = false;
            do
            {

                try
                {
                    AND_NOT and_not = new AND_NOT();
                    OR_NOT or_not = new OR_NOT();
                    
                    Console.WriteLine("Please enter number of inputs");
                    and_not.input = Int32.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Please enter inputs id({and_not.input})");
                    for (int i = 0; i < and_not.input; i++)
                    {
                        and_not.input_id[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Please enter number of values");
                    and_not.number_elements = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Please enter your numbers({and_not.number_elements*and_not.input})");
                    for (int i = 0; i < and_not.number_elements; i++)
                    {
                        for (int j = 0; j < and_not.input; j++)
                        {
                            Console.Write($"[{i}] ");
                            and_not.input_num[i, j] = Int32.Parse(Console.ReadLine());
                            if ((and_not.input_num[i,j] != 1)&&(and_not.input_num[i, j] != 0))
                            {
                                throw new Exception();
                            }
                            
                        }
                    }                
                    Console.WriteLine("Please enter operation(press &(AND_NOT) or 1(OR_NOT)");
                    and_not.symbol_id = Console.ReadKey().KeyChar;


                    Console.WriteLine();
                    Console.WriteLine();
                    if (and_not.symbol_id == '&')
                    {
                        Element.result_operation_andnot = AND_NOT.operation(and_not.input, and_not.number_elements, and_not.input_num);
                                               
                        
                    }
                    else if(and_not.symbol_id == '1')
                    {
                        Element.result_operation_ornot = OR_NOT.operation(and_not.input, and_not.number_elements, and_not.input_num);
                      
                    }
                    else
                    {
                        throw new Exception();
                    }

                   
                    flag = true;
                    Scheme result_obj = new Scheme(and_not.input, and_not.symbol_id, and_not.number_elements);
                    Scheme.result.Add(result_obj);
                    Scheme.result.AddRange(Element.result_operation_andnot);
                    Scheme.result.AddRange(Element.result_operation_ornot);
                    foreach (var item in Scheme.result)
                    {
                        Console.WriteLine(item);
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong number or operation");
                }

            } while (flag != true);


            Console.ReadKey();


        }
    }
}
