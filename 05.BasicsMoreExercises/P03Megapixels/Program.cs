using System;

namespace P03Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = (double)width * height / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(result, 1)}MP");

            //main ends here
        }
    }
}
