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


            //int i = arr.FindMajority(new int[] { 2, 6, 1, 4, 2, 2, 2 });
            //int i = arr.NumberOddOccurrence(new int[] { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2} );
            int[] input=new int[]{1,2,3,4,5,6};
            arr.ReverseArray(input);
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            //Console.WriteLine(input);


            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            
            Console.ReadLine();
        }


    }
}
