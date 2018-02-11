using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            bool equalsFound = false;

            int index = 0;
            while (index < numbers.Count - 1)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    numbers[index] += numbers[index];
                    numbers.RemoveAt(index + 1);
                    equalsFound = true;
                }

                if (equalsFound)
                {
                    index = 0;
                    equalsFound = false;
                }
                else
                {
                    index++;
                }

                if (numbers.Count == 1)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

            //main ends here
        }

       

        //class ends here
    }
}
