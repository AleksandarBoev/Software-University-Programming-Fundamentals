using System;

namespace P02AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int numberOfFakeMessages = int.Parse(Console.ReadLine());

            Random randomIndex = new Random();

            for (int i = 0; i < numberOfFakeMessages; i++)
            {
                int randomPhrase = randomIndex.Next(0, phrases.Length);
                int randomEvent = randomIndex.Next(0, events.Length);
                int randomAuthor = randomIndex.Next(0, authors.Length);
                int randomCity = randomIndex.Next(0, cities.Length);

                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomAuthor]} - {cities[randomCity]}");
            }

            //main ends here
        }
    }
}
