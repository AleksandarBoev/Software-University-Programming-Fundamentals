using System;
using System.Linq;

namespace P04DistanceBetweenPoints
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
            int[] input1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Point point1 = new Point(input1[0], input1[1]);
            Point point2 = new Point(input2[0], input2[1]);

            Console.WriteLine($"{Point.GetDistanceBetweenPoints(point1, point2):F3}");

            //main ends here
        }
    }
}
