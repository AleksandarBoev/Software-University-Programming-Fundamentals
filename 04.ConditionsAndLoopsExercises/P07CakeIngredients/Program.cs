using System;

namespace P07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();

            int count = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");

            //main ends here
        }
    }
}
