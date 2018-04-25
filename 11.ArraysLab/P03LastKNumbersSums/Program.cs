using System;

namespace P03LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int numberOfElementsToBeSummed = int.Parse(Console.ReadLine()); //tupo ime

            long[] arrayOfNumbers = new long[arrayLength];
            arrayOfNumbers[0] = 1;

            for (int i = 1; i < arrayLength; i++)
            {
                if (numberOfElementsToBeSummed > i)
                {
                    arrayOfNumbers[i] = GetSumFromTo(0, i, arrayOfNumbers);
                } else
                {
                    arrayOfNumbers[i] = GetSumFromTo(i - numberOfElementsToBeSummed, i, arrayOfNumbers);
                }   
            }

            foreach (var item in arrayOfNumbers)
            {
                Console.Write(item + " ");
            }

            //main ends here
        }

        static long GetSumFromTo(int start, int end, long[] arrayOfNumbers)
        {
            long sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += arrayOfNumbers[i];
            }

            return sum;
        }

    }
}
