using System;
using System.Collections.Generic;
using System.Linq;

namespace P02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] initialIndexesOfLadybugs = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            List<int> realInitialIndexes = new List<int>();
            for (int i = 0; i < initialIndexesOfLadybugs.Length; i++)
            {
                if (initialIndexesOfLadybugs[i] <= sizeOfField || initialIndexesOfLadybugs[i] > 0)
                {
                    realInitialIndexes.Add(initialIndexesOfLadybugs[i]);
                }
            }

            int[] spotsTaken = new int[sizeOfField]; // default values = 0 (0 sushto si oznachava che ne e zaeto)
            for (int i = 0; i < realInitialIndexes.Count; i++)
            {
                spotsTaken[realInitialIndexes[i]] = 1;
            }


            // now until end you receive flyght lengths untill u get "end"

            while (true)
            {
                string[] input = Console.ReadLine().Split(); // ladybugIndex(the bug which will moove) -> direction (right/left) -> flyLength
                if (input[0] == "end")
                {
                    break;
                }

                int ladyBugIndex = int.Parse(input[0]);
                if (spotsTaken[ladyBugIndex] == 0) // if there is not ladybug there, it cant do anything...
                {
                    continue;
                }

                string direction = input[1]; // left ( -flighLenght) or right ( +flightLength)

                int flightLength = int.Parse(input[2]);
                if (flightLength > sizeOfField || flightLength < 0)
                {
                    continue;
                }

                spotsTaken[ladyBugIndex] = 0; // sega kakvoto i da stava se maha ot tozi index
                if (direction == "left")
                {
                    flightLength *= -1;
                } // ako puk si e right si ostava taka

                int actualFlightLength = flightLength;
                while (true)
                {
                    int sum = actualFlightLength + ladyBugIndex;
                    if (sum < 0 || sum > sizeOfField)
                    {
                        break; // mqstoto po-rano be osvobodeno, a sega drugo mqsto ne biva zaeto i kalinkata si zaminava
                    }
                    if (spotsTaken[sum] == 1) //t.e. ako e zaeto
                    {
                        actualFlightLength += flightLength;
                    }
                }
            }
            //main ends here
        }
    }
}
