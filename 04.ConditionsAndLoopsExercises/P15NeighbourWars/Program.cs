using System;

namespace P15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int round = 0;
            int peshoHp = 100;
            int goshoHp = 100;
            string winnerName = "";

            while (peshoHp > 0 && goshoHp > 0)
            {
                round++;

                if (round % 2 == 1)
                {
                    goshoHp -= peshoDamage;
                    
                    if (goshoHp <= 0)
                    {
                        winnerName = "Pesho";
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                }
                else
                {
                    peshoHp -= goshoDamage;

                    if (peshoHp <= 0)
                    {
                        winnerName = "Gosho";
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                }

                if (round % 3 == 0)
                {
                    goshoHp += 10;
                    peshoHp += 10;
                }

            }

            Console.WriteLine($"{winnerName} won in {round}th round.");

            //main ends here
        }
    }
}
