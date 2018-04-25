using System;

namespace P11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int miles = distanceInMeters * 1609;
            int kilometers = distanceInMeters * 1000;

            int totalSeconds = minutes * 60 + hours * 60 * 60 + seconds;

            float metersPerSecond = (float)(distanceInMeters) / totalSeconds;
            float kilometersPerHour = metersPerSecond * 3.6f;
            double milesPerHour = metersPerSecond * 2.2374142690926605669119232161438; //2.2374142690926605669119232161


            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine($"{milesPerHour:F7}");

            //main ends here
        }
    }
}
