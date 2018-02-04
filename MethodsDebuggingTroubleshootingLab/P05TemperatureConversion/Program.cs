using System;

namespace P05TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celcius = FahrenheitToCelcius(fahrenheit);

            Console.WriteLine($"{celcius:F2}");

            //main ends here
        }

        static double FahrenheitToCelcius(double degreesInFahrenheit)
        {
            return (degreesInFahrenheit - 32) * 5 / 9;
        }

        //class ends here
    }
}
