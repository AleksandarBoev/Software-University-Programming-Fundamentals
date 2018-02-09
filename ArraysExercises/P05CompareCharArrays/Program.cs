using System;
using System.Linq;

namespace P05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] input2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int index = 0; index < Math.Min(input1.Length, input2.Length); index++)
            {
                if (input1[index] < input2[index])
                {
                    Console.WriteLine(string.Join("", input1));
                    Console.WriteLine(string.Join("", input2));
                    return;
                }
                else if (input1[index] > input2[index])
                {
                    Console.WriteLine(string.Join("", input2));
                    Console.WriteLine(string.Join("", input1));
                    return;
                }

            }

            if (input1.Length < input2.Length)
            {
                Console.WriteLine(string.Join("", input1));
                Console.WriteLine(string.Join("", input2));
            }
            else
            {
                Console.WriteLine(string.Join("", input2));
                Console.WriteLine(string.Join("", input1));
            }

            //main ends here
        }
    }
}
