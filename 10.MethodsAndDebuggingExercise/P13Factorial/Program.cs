using System;
using System.Numerics;

namespace P13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(number));

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

        //class ends here
    }
}
