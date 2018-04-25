using System;
using System.Collections.Generic;
using System.Linq;

namespace P06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> exactSquares = new List<int>();

            for (int i = 0; i < numbersInput.Length; i++)
            {
                double squareResult = Math.Sqrt(numbersInput[i]);
                if (squareResult == (int)squareResult)
                {
                    exactSquares.Add(numbersInput[i]);
                }
            }

            exactSquares.Sort();
            exactSquares.Reverse();

            Console.WriteLine(string.Join(" ", exactSquares));

            //main ends here
        }
    }
}
