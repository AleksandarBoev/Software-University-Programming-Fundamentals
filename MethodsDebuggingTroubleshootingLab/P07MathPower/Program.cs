using System;

namespace P07MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RaiseToPower(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            //main ends here
        }

        static double RaiseToPower(double number, int raiseTo)
        {
            double result = 1;
            for (int i = 0; i < raiseTo; i++)
            {
                result *= number;
            }

            return result;

        }

        //class ends here
    }
}
