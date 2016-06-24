using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrackProblem
{
    
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
            StringHelper shelp = new StringHelper();
            string input2 = Console.ReadLine();
            Console.WriteLine(input2);
            Console.WriteLine("Is the input palindrom ? {0}",shelp.CheckPalindrom(input2));
            Console.ReadLine();
        }

        
    }
}
