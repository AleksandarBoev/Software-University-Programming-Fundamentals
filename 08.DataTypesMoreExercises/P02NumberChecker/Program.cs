using System;
using System.Numerics;

namespace P02NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BigInteger integerNumber = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }

            //main ends here
        }
    }
}
