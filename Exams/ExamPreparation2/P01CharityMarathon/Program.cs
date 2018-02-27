using System;

namespace P01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDayCount = int.Parse(Console.ReadLine());
            int runnerCount = int.Parse(Console.ReadLine());
            int averageNumberOfLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maxAllowedParticipants = trackCapacity * marathonDayCount;
            long actualParticipants = Math.Min(maxAllowedParticipants, runnerCount);
            long totalMeters = actualParticipants * lapLength * averageNumberOfLaps;
            long totalKilometers = totalMeters / 1000;
            decimal moneyMade = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyMade:F2}");
            //main ends here
        }
    }
}
