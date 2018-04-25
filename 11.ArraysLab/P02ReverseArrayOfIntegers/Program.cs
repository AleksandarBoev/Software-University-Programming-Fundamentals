using System;
using System.Linq;

namespace P02ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[arrayLength];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            arrayOfNumbers = arrayOfNumbers.Reverse().ToArray();

            foreach (var item in arrayOfNumbers)
            {
                Console.Write(item + " ");
            }

            //main ends here
        }
    }
}
