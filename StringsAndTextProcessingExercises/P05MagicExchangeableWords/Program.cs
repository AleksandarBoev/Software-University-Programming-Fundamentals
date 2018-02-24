using System;
using System.Linq;

namespace P05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string input1 = String.Concat(input[0].Distinct());
            string input2 = String.Concat(input[1].Distinct());

            if (input1.Length == input2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //main ends here
        }
    }
}
