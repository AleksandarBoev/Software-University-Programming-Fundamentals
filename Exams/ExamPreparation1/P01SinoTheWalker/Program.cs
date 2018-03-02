using System;
using System.Globalization;
using System.Numerics;

namespace P01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeFormat = "HH:mm:ss";
            DateTime leave = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

            int numberOfSteps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            BigInteger totalSeconds = ((BigInteger)numberOfSteps * secondsPerStep) % 86400; // ako ne stane probvai s BigInteger

            leave = leave.AddSeconds((double)totalSeconds);

            Console.WriteLine($"Time Arrival: {leave.Hour:D2}:{leave.Minute:D2}:{leave.Second:D2}");
            //main ends here
        }
    }
}
