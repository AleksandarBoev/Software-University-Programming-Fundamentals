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

            int baseN = int.Parse(input[0]);
            string n = string.Join("", input[1].Reverse());
            BigInteger result = 0;

            for (int i = 0; i < n.Length; i++)
            {
                result += int.Parse("" + n[i]) * (BigInteger)Math.Pow(baseN, i);
            }

            Console.WriteLine(result);

            //main ends here
        }
    }
}
