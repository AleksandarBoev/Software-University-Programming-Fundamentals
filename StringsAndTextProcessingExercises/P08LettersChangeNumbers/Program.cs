using System;

namespace P08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', '\t'} , StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0m;

            for (int i = 0; i < input.Length; i++)
            {
                char firstChar = input[i][0];
                char lastChar = input[i][input[i].Length - 1];
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));

                if (Char.IsUpper(firstChar))
                {
                    int divider = firstChar - 64;
                    number /= divider;
                }
                else
                {
                    int multiplier = firstChar - 96;
                    number *= multiplier;
                }

                if (Char.IsUpper(lastChar))
                {
                    int substracter = lastChar - 64;
                    number -= substracter;
                }
                else
                {
                    int adder = lastChar - 96;
                    number += adder;
                }
                sum += number;

            }

            Console.WriteLine($"{sum:F2}");
            //main ends here
        }
    }
}
