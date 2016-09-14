using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSProblem;

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
            //string check = "e";
            //while (check != "q")
            //{
            //    StringHelper shelp = new StringHelper();
            //    Console.WriteLine("Enter Input to test");
            //    string input5 = Console.ReadLine();
                
            //    Console.WriteLine("Is the input can be palindrom ? {0}", shelp.CanBePalindrom(input5));
            //    Console.WriteLine("Enter q to exit anyother character to continue for other input");
            //    check = Console.ReadLine();
            //}
            ArrayProblem arr = new ArrayProblem();
            int[] arr5 = new int[] { 1, 5, 1, 1, 3, 1, 5, 1, 1, 5 };
            
            int i=arr.FindMajority(new int[]{1,2,1,2,1,2,1,2,3,4,4,5,6,1,1,1,1,1 });



            Console.ReadLine();
        }


    }
}
