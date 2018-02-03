using System;

namespace P05WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                sbyte weather = sbyte.Parse(number);
                Console.WriteLine("Sunny");
            } catch
            {
                try
                {
                    int weather = int.Parse(number);
                    Console.WriteLine("Cloudy");
                }
                catch
                {
                    try
                    {
                        long weather = long.Parse(number);
                        Console.WriteLine("Windy");
                    }
                    catch
                    {
                        double weather = double.Parse(number);
                        Console.WriteLine("Rainy");
                    }

                }

            }

            //main ends here
        }
    }
}
