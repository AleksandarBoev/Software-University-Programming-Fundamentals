using System;
using System.Linq;

namespace P05RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string doubleVariables = Console.ReadLine();

            double[] arrayOfDoubles = doubleVariables.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                int roundedNumber = (int)Math.Round(arrayOfDoubles[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arrayOfDoubles[i]} => {roundedNumber}");
            }

            //main ends here
        }
    }
}
