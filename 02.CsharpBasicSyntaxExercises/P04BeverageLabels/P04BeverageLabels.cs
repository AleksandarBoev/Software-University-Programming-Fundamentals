using System;

namespace P04BeverageLabels
{
    class P04BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            var calories = (double) volume * energyContent / 100;
            var sugar = (double) volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugar}g sugars");
            //main ends here
        }
    }
}
