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
            //string input = "[[()]{}]";
            //StackProblems sp = new StackProblems();
            //int count = sp.CheckBracket(input);
            //if (count > 0)
            //{
            //    Console.WriteLine("False");
            //}
            //else
            //{
            //    Console.WriteLine("True");
            //}
            string check = "e";
            while (check != "q")
            {
                StringHelper shelp = new StringHelper();
                Console.WriteLine("Enter Input to test");
                string input2 = Console.ReadLine();
                
                Console.WriteLine("Is the input can be palindrom ? {0}", shelp.CanBePalindrom(input2));
                Console.WriteLine("Enter q to exit anyother character to continue for other input");
                check = Console.ReadLine();
            }



            Console.ReadLine();
        }


    }
}
