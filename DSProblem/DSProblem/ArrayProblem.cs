using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSProblem
{
    class ArrayProblem
    {

        //public int FindMajority(int[] input)
        //{
        //    int length = input.Length;
        //    int atmost = (length / 2) + 1;
            
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        int count = 1;    
        //        for (int j = 0; j < input.Length; j++)
        //        {
        //            if (input[i]==input[j])
        //            {
        //                count++;
        //            }
                    
        //            if (atmost==count)
        //            {
        //                return input[i];
        //            }

                   
        //        }
        //        Console.WriteLine(count);
             
        //    }
            
        //    return -1;
        //}
        /// <summary>
        /// This method uses  Moore’s Voting Algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int FindMajority(int[] input)
        {
            int count = 1;
            int Max_Index = 0;
            for (int i = 1; i < input.Length; i++)
            {
                //{1,2,1,2,1,2,1,1,3,1,1,5,6,1,1,1,1,1 }
                if (input[Max_Index]==input[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                if (count==0)
                {
                    Max_Index = i;
                    count = 1;
                }
            }
            count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[Max_Index]==input[i])
                {
                    count++;
                }
              
            }
            if (count >= input.Length / 2)
            {
                return input[Max_Index];
            }
            return -1;
        }
    }
}
