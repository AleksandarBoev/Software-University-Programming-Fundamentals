using System;
using System.Collections.Generic;
using System.Linq;

namespace P01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> nonNegativeNumbers = new List<int>();

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] >= 0)
                {
                    nonNegativeNumbers.Add(numbers[index]);
                }
            }

            nonNegativeNumbers.Reverse();

            if (nonNegativeNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", nonNegativeNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

            //main ends here
        }
    }
}
