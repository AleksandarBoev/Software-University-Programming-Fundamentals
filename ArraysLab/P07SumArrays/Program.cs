using System;
using System.Linq;
using System.Text;

namespace P07SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayOfNumbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int biggerLength = Math.Max(arrayOfNumbers1.Length, arrayOfNumbers2.Length);
            int[] arrayOfSums = new int[biggerLength];
            int smallerLength = Math.Min(arrayOfNumbers1.Length, arrayOfNumbers2.Length);

            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                if (arrayOfNumbers1.Length < arrayOfNumbers2.Length)
                {
                    arrayOfSums[i] = arrayOfNumbers1[i % smallerLength] + arrayOfNumbers2[i];
                }
                else if (arrayOfNumbers1.Length == arrayOfNumbers2.Length)
                {
                    arrayOfSums[i] = arrayOfNumbers1[i] + arrayOfNumbers2[i];
                }
                else
                {
                    arrayOfSums[i] = arrayOfNumbers1[i] + arrayOfNumbers2[i % smallerLength];
                }

            }

            //Console.WriteLine(string.Join(' ', arrayOfSums));
            Console.WriteLine(ArrayOfIntegersToString(' ', arrayOfSums));

            //main ends here
        }

        static string ArrayOfIntegersToString(char splitWith, int[] arrayOfIntegers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                sb.Append(arrayOfIntegers[i]);
                if (i != arrayOfIntegers.Length - 1)
                {
                    sb.Append(splitWith);
                }
            }

            return sb.ToString();
        }

        //class ends here
    }
}
