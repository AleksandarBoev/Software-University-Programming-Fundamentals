using System;
using System.Collections.Generic;
using System.Linq;

namespace P05ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int coordinateX, int coordinateY)
        {
            X = coordinateX;
            Y = coordinateY;
        }

        public Point()
        {

        }

        public static double GetDistanceBetweenPoints(Point point1, Point point2)
        {
            int side1 = Math.Abs(point1.X - point2.X);
            int side2 = Math.Abs(point1.Y - point2.Y);

            return Math.Sqrt(side1 * side1 + side2 * side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minX1 = int.MaxValue;
            int minX2 = int.MaxValue;
            int minY1 = int.MaxValue;
            int minY2 = int.MaxValue;
            double minDistance = double.MaxValue;

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Point currentPoint = new Point(input[0], input[1]);
                points.Add(currentPoint);
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double currentDistance = Point.GetDistanceBetweenPoints(points[i], points[j]);
                    if (currentDistance < minDistance)
                    {
                        minX1 = points[i].X;
                        minX2 = points[j].X;
                        minY1 = points[i].Y;
                        minY2 = points[j].Y;
                        minDistance = currentDistance;
                    }
                }
            }


            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({minX1}, {minY1})");
            Console.WriteLine($"({minX2}, {minY2})");

            //main ends here
        }
    }
}
