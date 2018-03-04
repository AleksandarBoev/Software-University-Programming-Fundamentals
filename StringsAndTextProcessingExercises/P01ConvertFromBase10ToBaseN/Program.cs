using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P01ConvertFromBase10ToBaseN
{
    class Program
    {

        // 7 10 -> 13 => 10 % 7 == 3 -> 3 * 7 ^ 0 + 
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder remainders = new StringBuilder();

            BigInteger baseN = BigInteger.Parse(input[0]);
            BigInteger decimalNumber = BigInteger.Parse(input[1]);

            while (decimalNumber > 0)
            {
                remainders.Append(decimalNumber % baseN);
                decimalNumber /= baseN;
            }

            Console.WriteLine(string.Join("", remainders.ToString().Reverse()));

            //BigInteger result = new BigInteger();
            //result = 0;

            //for (int i = 0; i < remainders.Length; i++)
            //{
            //    BigInteger tempNumber = BigInteger.Parse("" + remainders[i]);
            //    result = result + (tempNumber * (BigInteger)Math.Pow(10, i));
            //}

            //Console.WriteLine(result);
            //main ends here
        }
    }
}
