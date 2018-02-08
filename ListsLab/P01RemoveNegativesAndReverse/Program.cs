using System;
using System.Collections.Generic;
using System.Linq;

namespace P01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();

            string inputData = Console.ReadLine();

            listOfNumbers = inputData.Split(' ').Select(int.Parse).ToList();

            for (int index = listOfNumbers.Count - 1; index >= 0; index--)
            {
                if (listOfNumbers[index] < 0)
                {
                    listOfNumbers.RemoveAt(index);
                }
            }

            listOfNumbers.Reverse();

            Console.WriteLine(string.Join(" ", listOfNumbers));

            //main ends here
        }
    }
}
