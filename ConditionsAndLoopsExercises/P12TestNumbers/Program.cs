using System;

namespace P12TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int countCombinations = 0;
            int currentSum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    currentSum += i * j * 3;
                    countCombinations++;

                    if (currentSum >= maxSum)
                    {
                        Console.WriteLine($"{countCombinations} combinations" + System.Environment.NewLine + $"Sum: {currentSum} >= {maxSum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{countCombinations} combinations" + System.Environment.NewLine + $"Sum: {currentSum}");

            //main ends here
        }
    }
}
