using System;

namespace P03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double totalPrice = 0;

            bool smallHall = 0 <= groupSize && groupSize <= 50;
            bool terrace = 50 < groupSize && groupSize <= 100;
            bool greatHall = 100 < groupSize && groupSize <= 120;
            bool toManyPeople = groupSize > 120;

            if (toManyPeople)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            else if (smallHall)
            {
                hallName = "Small Hall";
                totalPrice = 2500.0;
            } else if (terrace)
            {
                hallName = "Terrace";
                totalPrice = 5000.0;
            } else if (greatHall)
            {
                hallName = "Great Hall";
                totalPrice = 7500.0;
            }

            double discount = 0;

            switch (package)
            {
                case "Normal":
                    discount = 0.05;
                    totalPrice += 500;
                    break;

                case "Gold":
                    discount = 0.1;
                    totalPrice += 750;
                    break;

                case "Platinum":
                    discount = 0.15;
                    totalPrice += 1000;
                    break;
            }

            totalPrice = totalPrice * (1.0 - discount);
            double pricePerPerson = (double) totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}" + System.Environment.NewLine + $"The price per person is {pricePerPerson:F2}$");

            //main ends here
        }
    }
}
