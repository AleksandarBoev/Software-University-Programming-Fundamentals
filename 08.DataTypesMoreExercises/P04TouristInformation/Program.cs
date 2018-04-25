using System;

namespace P04TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            decimal value = decimal.Parse(Console.ReadLine());

            decimal result = 0m;
            string normalUnit = "";

            switch (imperialUnit)
            {
                case "miles":
                    normalUnit = "kilometers";
                    result = value * 1.6m;
                    break;

                case "inches":
                    normalUnit = "centimeters";
                    result = value * 2.54m;
                    break;

                case "feet":
                    normalUnit = "centimeters";
                    result = value * 30m;
                    break;

                case "yards":
                    normalUnit = "meters";
                    result = value * 0.91m;
                    break;

                case "gallons":
                    normalUnit = "liters";
                    result = value * 3.8m;
                    break;
            }

            Console.WriteLine($"{value} {imperialUnit} = {result:F2} {normalUnit}");

            //main ends here
        }
    }
}
