using System;

namespace P10SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                totalSum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: " + totalSum);

            //main ends here
        }
    }
}
