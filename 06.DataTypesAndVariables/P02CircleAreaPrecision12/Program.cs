using System;

namespace P02CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double result = r * r * Math.PI;

            Console.WriteLine($"{result:F12}");

            //main ends here
        }
    }
}
