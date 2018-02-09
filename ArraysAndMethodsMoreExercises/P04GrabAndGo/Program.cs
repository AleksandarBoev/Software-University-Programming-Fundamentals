using System;
using System.Linq;

namespace P04GrabAndGo
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            string wat = "hello  ";
            wat = wat.Trim();

            if (CheckForValue(numbers, number))
            {
                Console.WriteLine(GetSumBeforeLastOccurence(numbers, number));
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

            //main ends here
        }

        static bool CheckForValue(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        static long GetSumBeforeLastOccurence(int[] numbers, int number)
        {
            int endIndex = 0;
            long sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    endIndex = i;
                }
            }

            for (int i = 0; i < endIndex; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        //class ends here
    }
}
