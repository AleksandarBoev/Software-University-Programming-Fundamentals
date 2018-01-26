using System;

namespace P02ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double drinkPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    drinkPrice = 0.7;
                    break;

                case "Businessman":
                case "Businesswoman":
                    drinkPrice = 1.00;
                    break;

                case "SoftUni Student":
                    drinkPrice = 1.7;
                    break;

                default:
                    drinkPrice = 1.2;
                    break;
            }

            double totalPrice = quantity * drinkPrice;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");

            //main ends here
        }
    }
}
