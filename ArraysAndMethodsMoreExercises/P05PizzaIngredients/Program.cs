using System;
using System.Linq;

namespace P05PizzaIngredients
{
    class Program
    {
        static void Main()
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            int ingredientNameLength = int.Parse(Console.ReadLine());

            string allIngredients = "";
            bool atLeastOneValidIngredient = false; // ne dava dopulnitelni tochki...

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (i > 9)
                {
                    break;
                }
                if (ingredients[i].Length == ingredientNameLength) 
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    allIngredients = allIngredients + ingredients[i] + " ";
                    atLeastOneValidIngredient = true;
                }
            }

            allIngredients = allIngredients.Trim();
            string[] output = allIngredients.Split(' ').ToArray();
            //output = output.Distinct().ToArray(); // trqbva da ima duplikati i pri printirane "Adding" i pri printirane "The ingredients are "
            int numberOfIngredientsUsed = 0;
            if (atLeastOneValidIngredient)
            {
                numberOfIngredientsUsed = output.Length;
                Console.WriteLine($"Made pizza with total of {numberOfIngredientsUsed} ingredients.");
                Console.WriteLine("The ingredients are: " + string.Join(", ", output) + '.');
            }


            //main ends here
        }

       

    }
}
