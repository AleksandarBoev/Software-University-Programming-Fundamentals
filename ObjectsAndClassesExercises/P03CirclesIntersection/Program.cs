using System;
using System.Linq;

namespace P03CirclesIntersection
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }

        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public static double CalculateDistance(int x1, int x2, int y1, int y2)
        {
            int side1 = Math.Abs(x1 - x2);
            int side2 = Math.Abs(y1 - y2);

            return Math.Sqrt(side1 * side1 + side2 * side2);
        }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            double distance = CalculateDistance(circle1.X, circle2.X, circle1.Y, circle2.Y);

            if (distance <= circle1.R + circle2.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Circle circle1 = new Circle(input[0], input[1], input[2]);
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle2 = new Circle(input[0], input[1], input[2]);

            if (Circle.Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //main ends here
        }
    }
}
