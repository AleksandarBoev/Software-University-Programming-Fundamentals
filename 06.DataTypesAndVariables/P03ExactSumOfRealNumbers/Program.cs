using System;

namespace P03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal exactSum = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal exactNumber = decimal.Parse(Console.ReadLine());
                exactSum += exactNumber;
            }

            Console.WriteLine(exactSum);

            //main ends here
        }
    }
}
