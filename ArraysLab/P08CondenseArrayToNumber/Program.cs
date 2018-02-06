using System;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayOfNumbersString = Console.ReadLine();
            int[] arrayOfNumbers = arrayOfNumbersString.Split(' ').Select(int.Parse).ToArray();

            if (arrayOfNumbers.Length == 1)
            {
                Console.WriteLine($"{arrayOfNumbersString} is already condensed to number");
                return;
            }

            while (arrayOfNumbersString.Contains(" "))
            {
                int[] condensedSumArray = new int[arrayOfNumbers.Length - 1];
                for (int i = 0; i < condensedSumArray.Length; i++)
                {
                    condensedSumArray[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                }

                arrayOfNumbers = condensedSumArray;
                arrayOfNumbersString = string.Join(" ", arrayOfNumbers);
            }

            Console.WriteLine(arrayOfNumbersString);

            //main ends here
        }
    }
}
