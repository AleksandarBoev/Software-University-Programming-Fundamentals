using System;

namespace P14BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            int firstBoatDistanceCovered = 0;
            char secondBoat = char.Parse(Console.ReadLine());
            int secondBoatDistanceCovered = 0;
            int numberOfMoves = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfMoves; i++)
            {
                string randomString = Console.ReadLine();
                if (randomString == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }

                if (i % 2 == 1)
                {
                    firstBoatDistanceCovered += randomString.Length;
                    if (firstBoatDistanceCovered >= 50)
                    {
                        break;
                    }
                } else
                {
                    secondBoatDistanceCovered += randomString.Length;
                    if (secondBoatDistanceCovered >= 50)
                    {
                        break;
                    }
                }

            }

            //Console.WriteLine(firstBoatDistanceCovered);
            //Console.WriteLine(secondBoatDistanceCovered);

            if (firstBoatDistanceCovered > secondBoatDistanceCovered)
            {
                Console.WriteLine(firstBoat);
            } else
            {
                Console.WriteLine(secondBoat);
            }

            //main ends here
        }
    }
}
