using System;

namespace P03MilesToKilometers
{
    class P03MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double milesToKilometers = 1.60934;
            double kilometers = miles * milesToKilometers;

            Console.WriteLine($"{kilometers:F2}");
            
            //main ends here
        }
    }
}
