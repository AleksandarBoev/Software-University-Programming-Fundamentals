using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool equalsFound = false;

            for (int index = 0; index < numbers.Count - 1; index++)
            {
                if (equalsFound)
                {
                    index = 0;
                    equalsFound = false;
                }

                if (numbers[index] == numbers[index + 1])
                {
                    numbers[index] += numbers[index];
                    numbers.RemoveAt(index + 1);
                    equalsFound = true;
                    index--;
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
