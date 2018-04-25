using System;
using System.Linq;

namespace P04TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayString = Console.ReadLine();

            long[] arrayOfNumbers = arrayString.Split(' ').Select(long.Parse).ToArray();

            bool oneSum = false;

            for (int number1 = 0; number1 < arrayOfNumbers.Length - 1; number1++)
            {
                for (int number2 = number1 + 1; number2 < arrayOfNumbers.Length; number2++)
                {
                    long sum = arrayOfNumbers[number1] + arrayOfNumbers[number2];

                    if (arrayOfNumbers.Contains(sum))
                    {
                        Console.WriteLine($"{arrayOfNumbers[number1]} + {arrayOfNumbers[number2]} == {sum}");
                        oneSum = true;
                    }

                    //for (int i = 0; i < arrayOfNumbers.Length; i++)
                    //{
                    //    if (sum == arrayOfNumbers[i])
                    //    {
                    //        Console.WriteLine($"{arrayOfNumbers[number1]} + {arrayOfNumbers[number2]} == {sum}");
                    //        oneSum = true;
                    //    }
                    //}
                }
            }

            if (!oneSum)
            {
                Console.WriteLine("No");
            }

            //main ends here
        }

        //class ends here
    }
}


