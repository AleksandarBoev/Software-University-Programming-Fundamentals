using System;

namespace P08CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloserCoordinates(x1, y1, x2, y2);

            //main ends here
        }

        static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y); // suzdava se pravougulnik s koordinatite i se namira diagonalut (t.e.) osnovata na pravougulen triugulnik
        }

        static void PrintCloserCoordinates(double x1, double y1, double x2, double y2)
        {
            double distance1 = DistanceToCenter(x1, y1);
            double distance2 = DistanceToCenter(x2, y2);
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        //class ends here
    }
}
