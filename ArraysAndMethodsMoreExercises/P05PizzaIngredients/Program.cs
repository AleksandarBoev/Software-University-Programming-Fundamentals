using System;
using System.Linq;

namespace P05PizzaIngredients
{
    class Program
    {
        static void Main()
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int ingredientLettersCount = int.Parse(Console.ReadLine());

            int ingredientsCount = 0;
            string allIngredientsUsed = "";

            for (int index = 0; index < ingredients.Length; index++)
            {
                if (ingredients[index].Length == ingredientLettersCount)
                {
                    ingredientsCount++;
                    allIngredientsUsed += ingredients[index] + " ";
                    Console.WriteLine($"Adding {ingredients[index]}.");
                }

                if (ingredientsCount == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");

            allIngredientsUsed = allIngredientsUsed.Trim();
            string[] answer = allIngredientsUsed.Split(' ').ToArray();

            Console.WriteLine($"The ingredients are: {string.Join(", ", answer)}.");

            //main ends here
        }

    }
}
