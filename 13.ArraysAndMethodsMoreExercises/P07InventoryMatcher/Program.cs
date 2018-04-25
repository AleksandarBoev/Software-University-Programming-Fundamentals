using System;
using System.Linq;

namespace P07InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split(' ').ToArray();

            string currentProductName = "";

            while (true)
            {
                currentProductName = Console.ReadLine();
                if (currentProductName == "done")
                {
                    break;
                }

                int index = GetIndex(names, currentProductName);
                Console.WriteLine($"{names[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

            }

            //main ends here
        }

        static int GetIndex(string[] names, string name)
        {
            int result = -1;
            for (int index = 0; index < names.Length; index++)
            {
                if (names[index] == name)
                {
                    result = index;
                    break;
                }
            }

            return result;
        }

        // class ends here
    }
}
