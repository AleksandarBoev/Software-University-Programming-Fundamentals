using System;

namespace P10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareSide = double.Parse(Console.ReadLine());
            string squareProperty = Console.ReadLine();

            PrintSquareProperty(squareProperty, squareSide);

            //main ends here
        }

        static double GetSquareFaceDiagonal(double squareSide)
        {
            return Math.Sqrt(2 * (squareSide * squareSide));
        }

        static double GetSquareSpaceDiagonal(double squareSide)
        {
            return Math.Sqrt(3 * (squareSide * squareSide));
        }

        static double GetSquareVolume(double squareSide)
        {
            return Math.Pow(squareSide, 3);
        }

        static double GetSquareSurfaceArea(double squareSide)
        {
            return (squareSide * squareSide * 6);
        }

        static void PrintSquareProperty(string property, double squareSide)
        {
            switch (property)
            {
                case "face":
                    Console.WriteLine($"{GetSquareFaceDiagonal(squareSide):F2} ");
                    break;

                case "space":
                    Console.WriteLine($"{GetSquareSpaceDiagonal(squareSide):F2}");
                    break;

                case "volume":
                    Console.WriteLine($"{GetSquareVolume(squareSide):F2} ");
                    break;

                case "area":
                    Console.WriteLine($"{GetSquareSurfaceArea(squareSide):F2}");
                    break;
            }
        }

        //class ends here
    }
}
