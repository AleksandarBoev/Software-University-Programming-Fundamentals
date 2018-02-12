using System;
using System.Collections.Generic;
using System.Linq;

namespace P07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //moje double/long
            int[] bombAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNumber = bombAndPower[0];
            int bombPower = bombAndPower[1];

            int i = 0;
            while (i < numbers.Count)
            {
                if (numbers[i] == bombNumber)
                {
                    int bombIndex = i;
                    int startIndex;
                    int endIndex;

                    if (bombIndex - bombPower < 0)
                    {
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex = bombIndex - bombPower;
                    }

                    if (bombIndex + bombPower > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    else
                    {
                        endIndex = bombIndex + bombPower;
                    }

                    int range = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, range);
                    i = 0;
                    continue;
                }
                i++;
            }

            //Console.WriteLine(string.Join(" ", numbers));
            int totalSum = 0;
            for (int index = 0; index < numbers.Count; index++)
            {
                totalSum += numbers[index];
            }

            Console.WriteLine(totalSum);
            //main ends here
        }
    }
}
