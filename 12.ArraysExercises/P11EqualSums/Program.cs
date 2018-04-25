using System;
using System.Linq;

namespace P11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int index = 0; index < numbers.Length; index++)
            {
                int sumLeft = GetSumOfElements(numbers, 0, index - 1);
                int sumRight = GetSumOfElements(numbers, index + 1, numbers.Length - 1);

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(index);
                    return;
                }
            }

            if (numbers.Length == 1) 
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("no");
            }

            //main ends here
        }

        

        static int GetSumOfElements(int[] arrayOfNumbers, int startIndex, int endIndex)
        {
            int sum = 0;

            for (int index = startIndex; index <= endIndex; index++)
            {
                sum += arrayOfNumbers[index];
            }

            return sum;
        }

        //class ends here
    }
}
