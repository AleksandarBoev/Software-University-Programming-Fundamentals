using System;

namespace P19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPicturesTaken = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine()); //in seconds
            int percentageOfGoodPictures = int.Parse(Console.ReadLine());
            int uploadTimePerPicture = int.Parse(Console.ReadLine()); //in seconds

            ulong filteredPictures = (ulong)Math.Ceiling(numberOfPicturesTaken * (percentageOfGoodPictures / 100.0));
            ulong totalSeconds = (ulong)numberOfPicturesTaken * (ulong)filterTimePerPicture;
            totalSeconds += filteredPictures * (ulong)uploadTimePerPicture;

            int seconds = (int)(totalSeconds % 60); //copy pasted from googlesearch result for "seconds in days hours minutes"
            int minutes = (int)(totalSeconds % 3600) / 60;
            int hours = (int)(totalSeconds % 86400) / 3600;
            //int days = (int)(totalSeconds % (86400 * 30)) / 86400;
            int days = (int)(totalSeconds / (60 * 60 * 24));

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

            //main ends here
        }
    }
}
