using System;
using System.Linq;
using System.Numerics;

namespace P02ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            BigInteger baseN = BigInteger.Parse(input[0]);
            string n = string.Join("", input[1].Reverse());
            BigInteger result = 0;

            for (int i = 0; i < n.Length; i++)
            {
                result += int.Parse("" + n[i]) * GetPower(baseN, i);
            }

            Console.WriteLine(result);

            //main ends here
        }

        static BigInteger GetPower(BigInteger aBigNumber, int toPower) // Math.Pow ne priema BigInteger za parametur
        {
            BigInteger result = 1;
            for (int i = 1; i <= toPower; i++)
            {
                result *= aBigNumber;
            }
            return result;
        }

        //class ends here
    }
}

