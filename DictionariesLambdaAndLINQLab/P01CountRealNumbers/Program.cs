using System;
using System.Collections.Generic;
using System.Linq;

namespace P01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> doubleCount = new SortedDictionary<double, int>();
            double[] doublesInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double value in doublesInput)
            {
                if (doubleCount.ContainsKey(value) == false)
                {
                    doubleCount.Add(value, 1);
                }
                else
                {
                    doubleCount[value] = doubleCount[value] + 1;
                }
            }

            foreach (var kvp in doubleCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            //main ends here
        }
    }
}
