using System;

namespace P06CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double area = GetTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine(area);

            //main ends here
        }

        static double GetTriangleArea(double triangleBase, double triangleHeight)
        {
            return triangleBase * triangleHeight / 2.0;
        }

        //class ends here
    }
}
