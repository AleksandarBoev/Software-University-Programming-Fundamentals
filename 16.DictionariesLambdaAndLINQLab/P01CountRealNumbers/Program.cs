using System;
using System.Collections.Generic;
using System.Linq;

namespace P01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> doublesCount = new SortedDictionary<double, int>(); // v momenta v koito se dobavqt elementi stava sortiraneto
            double[] input = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray(); // var/return x = double.Parse(x) -> mini method

            foreach (double value in input)
            {
                if (doublesCount.ContainsKey(value) == false)
                {
                    doublesCount.Add(value, 1);
                }
                else
                {
                    doublesCount[value]++;
                }
            }

            foreach (var key in doublesCount.Keys)
            {
                Console.WriteLine($"{key} -> {doublesCount[key]}");
            }

            //main ends here
        }
    }
}
