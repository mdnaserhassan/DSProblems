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
            int left = 0;
            int right = inputs.Length - 1;
            while (left <= right)
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
        public bool CanBePalindrom(string input)
        {
            string input2 = "";
            string input1 = "";
            if (CheckPalindrom(input))
            {
                return true;
            }
            input1=input.Remove(input.Length / 2, 1);
            input2=input.Remove(input.Length / 2+1, 1);
            if (CheckPalindrom(input1)||CheckPalindrom(input2))
            {
               return true;
            }
            //input = input.Replace(input.Substring(input.Length/2,1),"");
           
            else
            {
                return false;
            }

        }
    }
}
