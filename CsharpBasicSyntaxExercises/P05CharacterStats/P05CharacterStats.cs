using System;

namespace P05CharacterStats
{
    class Program2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int hp = int.Parse(Console.ReadLine());
            int maxHp = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int missingHp = maxHp - hp;
            int missingEnergy = maxEnergy - energy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string ('|', hp), new string ('.', missingHp));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', missingEnergy));

            //main ends here
        }
    }
}
