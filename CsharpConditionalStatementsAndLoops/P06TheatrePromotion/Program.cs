using System;

namespace P06TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            bool young = 0 <= age && age <= 18;
            bool middleAged = 18 < age && age <= 64;
            bool old = 64 < age && age <= 122;
            int ticketPrice = 0;

            switch (dayType)
            {
                case "Weekday":
                    if (young || old)
                    {
                        ticketPrice = 12;
                    } else
                    {
                        ticketPrice = 18;
                    }
                    break;
                case "Weekend":
                    if (young || old)
                    {
                        ticketPrice = 15;
                    } else
                    {
                        ticketPrice = 20;
                    }

                    break;
                case "Holiday":
                    if (young)
                    {
                        ticketPrice = 5;
                    } else if (middleAged)
                    {
                        ticketPrice = 12;
                    } else if (old)
                    {
                        ticketPrice = 10;
                    }
                    break;
            }

            Console.WriteLine($"{ticketPrice}$");

            //main ends here
        }
    }
}
