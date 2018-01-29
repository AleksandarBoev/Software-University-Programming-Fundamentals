using System;

namespace P07TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            sbyte numberOfItems = sbyte.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (sbyte i = 1; i <= numberOfItems; i++)
            {
                string item = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                {
                    item = item + "s";
                }

                Console.WriteLine($"Adding {itemCount} {item} to cart." );
                totalPrice += itemCount * itemPrice;
            }

            Console.WriteLine($"Subtotal: ${totalPrice:F2}");
            if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough. We need ${(totalPrice - budget):F2} more.");
            } else
            {
                Console.WriteLine($"Money left: ${(budget - totalPrice):F2}");
            }

            //main ends here
        }
    }
}
