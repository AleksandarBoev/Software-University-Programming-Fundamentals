using System;

namespace P02RectangleArea
{
    class P02RectangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            double result = width * length;

            Console.WriteLine($"{result:F2}");

            //main ends here
        }
    }
}
