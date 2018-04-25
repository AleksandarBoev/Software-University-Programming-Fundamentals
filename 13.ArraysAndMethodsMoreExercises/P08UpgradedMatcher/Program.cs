using System;
using System.Linq;

namespace P08UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = new long[names.Length];
            long[] quantities2 = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            for (int index = 0; index < Math.Min(quantities.Length, quantities2.Length); index++)
            {
                quantities[index] = quantities2[index];
            }
            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); // ako ne stane taka moje s decimal

            while (true)
            {
                string[] currentOrder = Console.ReadLine().Split(' ').ToArray();
                if (currentOrder[0] == "done")
                {
                    break;
                }

                int index = GetIndex(names, currentOrder[0]);

                long orderQuantity = long.Parse(currentOrder[1]);
                if (orderQuantity > quantities[index])
                {
                    Console.WriteLine($"We do not have enough {names[index]}");
                }
                else
                {
                    double totalPrice = orderQuantity * prices[index];
                    Console.WriteLine($"{names[index]} x {orderQuantity} costs {totalPrice:F2}");
                    quantities[index] -= orderQuantity;
                }
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

        //class ends here
    }
}
