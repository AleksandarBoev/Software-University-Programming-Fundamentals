using System;
using System.Collections.Generic;
using System.Linq;

namespace P07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> uniqueNumbers = BuildUniqueNumbersList(numbers);

            uniqueNumbers.Sort();

            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                int value = uniqueNumbers[i];
                int valueRepeated = GetRecurrenceCount(numbers, value);
                Console.WriteLine($"{value} -> {valueRepeated}");
            }

            //main ends here
        }

        static int GetRecurrenceCount(int[] numbers, int value)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    count++;
                }
            }

            return count;
        }

        static List<int> BuildUniqueNumbersList(int[] numbers)
        {
            List<int> result = new List<int>();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result.Contains(numbers[i]) == false)
                {
                    result.Add(numbers[i]);
                }
            }

            return result;
        }

        //class
    }
}
