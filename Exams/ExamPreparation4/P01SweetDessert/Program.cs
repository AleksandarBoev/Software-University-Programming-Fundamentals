using System;

namespace P01SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal pricePerBanana = decimal.Parse(Console.ReadLine());
            decimal pricePerEgg = decimal.Parse(Console.ReadLine());
            decimal pricePerKiloBerries = decimal.Parse(Console.ReadLine());

            int portionsNeeded = numberOfGuests / 6;
            if (numberOfGuests % 6 != 0)
            {
                portionsNeeded++;
            }
            decimal pricePerPortion = 2 * pricePerBanana + 4 * pricePerEgg + 0.2m * pricePerKiloBerries;
            decimal totalMoneyNeeded = pricePerPortion * portionsNeeded;

            decimal result = budget - totalMoneyNeeded;

            if (result < 0)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(result):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:F2}lv.");
            }

            //main ends here
        }
    }
}
