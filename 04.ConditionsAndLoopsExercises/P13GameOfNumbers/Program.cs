using System;

namespace P13GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int answer1 = 0;
            int answer2 = 0;
            int combinationCount = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinationCount++;
                    if (i + j == magicalNumber)
                    {
                        answer1 = i;
                        answer2 = j;
                    }
                }
            }

            if (answer1 != 0 && answer2 != 0)
            {
                Console.WriteLine($"Number found! {answer1} + {answer2} = {magicalNumber}");
            } else
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicalNumber}");
            }

            //main ends here
        }
    }
}
