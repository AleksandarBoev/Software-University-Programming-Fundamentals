using System;

namespace P16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;  // double chisla ne mogat da se sravnqvat s decimal chisla..

            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            bool areEqual = Math.Abs(number1 - number2) <= eps;
            Console.WriteLine(areEqual);

            //main ends here
        }
    }
}
