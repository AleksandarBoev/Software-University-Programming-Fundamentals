using System;

namespace P11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            PrintFigureArea(figureType);

            //main ends here
        }

        static double GetTriangleArea(double side, double height)
        {
            return side * height / 2.0;
        }

        static double GetSquareArea(double side)
        {
            return side * side;
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * (radius * radius);
        }

        static void PrintFigureArea(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetTriangleArea(side, height):F2}");
                    break;

                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetSquareArea(squareSide):F2}");
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetRectangleArea(width, rectangleHeight):F2}");
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetCircleArea(radius):F2}");
                    break;
            }


        }

        //class ends here
    }
}
