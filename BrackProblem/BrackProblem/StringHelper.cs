using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrackProblem
{
    class StringHelper
    {
        public bool CheckPalindrom(string input)
        {
            char[] inputs = input.ToArray();
            int left =0;
            int right = inputs.Length - 1;
            while (left<=right)
            {
                if (inputs[left] == inputs[right])
                {
                    left++;
                    right--;
                    
                }
                else
                 return false;
               
            }
            return true;
        
        }
    }
}
