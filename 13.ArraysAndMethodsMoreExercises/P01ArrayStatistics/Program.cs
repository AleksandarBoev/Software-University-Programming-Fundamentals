using System;
using System.Linq;

namespace P01ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {GetMin(numbers)}");
            Console.WriteLine($"Max = {GetMax(numbers)}");
            Console.WriteLine($"Sum = {GetSum(numbers)}");
            Console.WriteLine($"Average = {GetAverage(numbers)}");

            //main ends here
        }

        static int GetMin(int[] numbers)
        {
            int minValue = int.MaxValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] < minValue)
                {
                    minValue = numbers[index];
                }
            }

            return minValue;
        }

        static int GetMax(int[] numbers)
        {
            int maxValue = int.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > maxValue)
                {
                    maxValue = numbers[index];
                }
            }

            return maxValue;
        }

        static long GetSum(int[] numbers)
        {
            long sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                sum += numbers[index];
            }

            return sum;
        }

        static double GetAverage(int[] numbers)
        {
            return (double)GetSum(numbers) / numbers.Length;
        }

        //class ends here
    }
}
