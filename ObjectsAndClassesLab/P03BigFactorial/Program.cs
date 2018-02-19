using System;
using System.Numerics;

namespace P03BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = new BigInteger();
            int n = int.Parse(Console.ReadLine());

            result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
            //main ends here
        }
    }
}
