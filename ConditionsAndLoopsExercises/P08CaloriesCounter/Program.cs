using System;

namespace P08CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());

            int totalCalories = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;

                    case "tomato sauce":
                        totalCalories += 150;
                        break;

                    case "salami":
                        totalCalories += 600;
                        break;

                    case "pepper":
                        totalCalories += 50;
                        break;

                    case "Pineapple":
                        Console.WriteLine("Shame on you");
                        return;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");

            //main ends here
        }
    }
}
