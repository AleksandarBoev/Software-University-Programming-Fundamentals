using System;

namespace P12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());

            double perimeter = 2 * side1 + 2 * side2;
            double area = side1 * side2;
            double diagonal = Math.Sqrt(side1 * side1 + side2 * side2);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

            //main ends here
        }
    }
}
