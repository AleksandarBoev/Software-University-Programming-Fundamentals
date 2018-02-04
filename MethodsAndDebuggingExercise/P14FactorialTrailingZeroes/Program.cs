using System;
using System.Numerics;

namespace P14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorialTrailingZeros(number));

            //main ends here
        }

        static BigInteger GetFactorial(int number)
        {
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static int GetFactorialTrailingZeros(int number)
        {
            string factorial = GetFactorial(number).ToString();
            int zeroCount = 0;

            for (int i = factorial.Length - 1; i >= 0; i--)
            {
                if (int.Parse(factorial[i] + "") == 0)
                {
                    zeroCount++;
                } else
                {
                    break;
                }

            }

            return zeroCount;
        }

        //class ends here
    }
}
