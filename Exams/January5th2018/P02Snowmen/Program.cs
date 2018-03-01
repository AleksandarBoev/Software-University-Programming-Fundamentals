using System;
using System.Collections.Generic;
using System.Linq;

namespace P02Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            if (snowmen.Count == 1)
            {
                return;
            }

            while (true)
            {
                bool oneSnowmanLeft = false;
                for (int i = 0; i < snowmen.Count; i++)
                {
                    int attackerIndex = i;
                    int defenderIndex = snowmen[i] % snowmen.Count;
                    if (defenderIndex == -1) // ako na atakuvasht, indexut koito iska da atakuva e -1, znachi che e bil pobeden i ne moje da atakuva
                    {
                        continue;
                    }
                   
                    if (attackerIndex == defenderIndex)
                    {
                        snowmen[attackerIndex] = -1;
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                    }
                    else if (Math.Abs(attackerIndex - defenderIndex) % 2 == 0)
                    {
                        snowmen[defenderIndex] = -1;
                        Console.WriteLine($"{attackerIndex} x {defenderIndex} -> {attackerIndex} wins");
                    }
                    else if (Math.Abs(attackerIndex - defenderIndex) % 2 == 1)
                    {
                        snowmen[attackerIndex] = -1;
                        Console.WriteLine($"{attackerIndex} x {defenderIndex} -> {defenderIndex} wins");
                    }

                    int snowMenLeft = snowmen.Count(x => x != -1);
                    if (snowMenLeft == 1)
                    {
                        oneSnowmanLeft = true;
                        break;
                    }
                }

                snowmen = snowmen.Where(x => x != -1).ToList();

                if (oneSnowmanLeft)
                {
                    break;
                }
            }


            //main ends here
        }
    }
}
