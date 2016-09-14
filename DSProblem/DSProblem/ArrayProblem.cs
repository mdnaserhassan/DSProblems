using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblem
{
    class ArrayProblem
    {

        public int FindMajority(int[] input)
        {
            int length = input.Length;
            int atmost = (length / 2) + 1;
            
            for (int i = 0; i < input.Length; i++)
            {
                int count = 1;    
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i]==input[j])
                    {
                        count++;
                    }
                    
                    if (atmost==count)
                    {
                        return input[i];
                    }

                   
                }
                Console.WriteLine(count);
             
            }
            
            return -1;
        }
    }
}
