using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrackProblem
{
    class StackProblems
    {
        /// <summary>
        /// This Method returns true if for all open brackets in a string there is closed bracket
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public  int CheckBracket(string input)
        {
            char[] inputs = input.ToArray();
            Stack<char> openBracket = new Stack<char>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == '(' || inputs[i] == '{' || inputs[i] == '[')
                {
                    openBracket.Push(inputs[i]);
                }
                if (inputs[i] == ')' || inputs[i] == '}' || inputs[i] == ']')
                {
                    char inm = openBracket.Pop();
                    if (inputs[i] == ')' && inm == '(')
                    {

                    }
                    else if (inputs[i] == '}' && inm == '{')
                    {

                    }
                    else if (inputs[i] == ']' && inm == '[')
                    {

                    }
                    else
                    {
                        break;
                    }


                }
            }
            return openBracket.Count;







        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = "[[()]{}]";
            StackProblems sp = new StackProblems();
            int count = sp.CheckBracket(input);
           if (count > 0)
           {
               Console.WriteLine("False");
           }
           else
           {
               Console.WriteLine("True");
           }
            Console.ReadLine();
        }

        
    }
}
