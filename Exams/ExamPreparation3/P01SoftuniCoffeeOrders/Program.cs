using System;
using System.Globalization;

namespace P01SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = "d/M/yyyy";

            int countOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;
            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
                int days = DateTime.DaysInMonth(date.Year, date.Month);
                long capsulesCount = long.Parse(Console.ReadLine());

                decimal orderPrice = days * capsulesCount * pricePerCapsule;
                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");

            //main ends here
        }
    }
}
