using System;
using System.Collections.Generic;
using System.Linq;

namespace P07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            int currentNumberCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentNumberCount++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {currentNumberCount}");
                    currentNumberCount = 1;
                    if (i + 1 == numbers.Count - 1)
                    {
                        Console.WriteLine($"{numbers[i + 1]} -> {currentNumberCount}");
                    }
                }
            }

            //main ends here
        }

        //static int GetRecurrenceCount()

        //class
    }
}
