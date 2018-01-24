using System;

namespace P08SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNumber = 0;

            for (int i = 0; i < n; i++)
            {
                oddNumber = 2 * i + 1;
                Console.WriteLine(oddNumber);
                sum += oddNumber;
            }
            Console.WriteLine($"Sum: {sum}");

            //main ends here
        }
    }
}
