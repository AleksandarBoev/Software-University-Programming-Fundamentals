using System;

namespace P09LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            
            if (GetLineLength(x1, y1, x2, y2) >= GetLineLength(x3, y3, x4, y4))
            {
                PrintCloserCoordinates2(x1, y1, x2, y2);
            } else
            {
                PrintCloserCoordinates2(x3, y3, x4, y4);
            }
            //main ends here
        }

        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double triandleSide1 = Math.Abs(x1) + Math.Abs(x2);
            double triandleSide2 = Math.Abs(y1) + Math.Abs(y2);

            return Math.Sqrt(triandleSide1 * triandleSide1 + triandleSide2 * triandleSide2);
        }

        static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y); // suzdava se pravougulnik s koordinatite i se namira diagonalut (t.e.) osnovata na pravougulen triugulnik
        }

        static void PrintCloserCoordinates2(double x1, double y1, double x2, double y2)
        {
            double distance1 = DistanceToCenter(x1, y1);
            double distance2 = DistanceToCenter(x2, y2);
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        //class ends here
    }
}
