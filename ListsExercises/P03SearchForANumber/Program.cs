using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int takeUntilIndex = commands[0];
            int deleteUntilIndex = commands[1];
            int checkForThisValue = commands[2];

            List<int> numbersUpdate = new List<int>();

            for (int index = 0; index < takeUntilIndex; index++)
            {
                numbersUpdate.Add(numbers[index]);
            }

            for (int count = 0; count < deleteUntilIndex; count++)
            {
                numbersUpdate.RemoveAt(0);
            }

            if (numbersUpdate.Contains(checkForThisValue))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            //main ends here
        }
    }
}
