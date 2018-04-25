using System;
using System.Linq;

namespace P03MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] arrayOfNums = new int[numberOfInputs];

            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                arrayOfNums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {arrayOfNums.Sum()}");
            Console.WriteLine($"Min = {arrayOfNums.Min()}");
            Console.WriteLine($"Max = {arrayOfNums.Max()}");
            Console.WriteLine($"Average = {arrayOfNums.Average()}");

            //main ends here
        }
    }
}
