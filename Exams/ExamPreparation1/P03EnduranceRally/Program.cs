using System;
using System.Linq;

namespace P03EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting fuel is not equal to fuel capacity, which means a person can have more fuel at some point than when he started off
            string[] names = Console.ReadLine().Split();
            double[] checkpointFuel = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
            int[] checkpointIndexes = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray(); //on these indexes instead of loosing fuel, it will be gained

            for (int nameIndex = 0; nameIndex < names.Length; nameIndex++)
            {
                double currentFuel = names[nameIndex][0]; //starting fuel
                bool finished = true;

                for (int currentCheckpoint = 0; currentCheckpoint < checkpointFuel.Length; currentCheckpoint++)
                {
                    if (checkpointIndexes.Contains(currentCheckpoint))
                    {
                        currentFuel += checkpointFuel[currentCheckpoint];
                    }
                    else
                    {
                        currentFuel -= checkpointFuel[currentCheckpoint];
                        if (currentFuel <= 0) // potencialen problem, moje da e samo <
                        {
                            Console.WriteLine($"{names[nameIndex]} - reached {currentCheckpoint}");
                            finished = false;
                            break;
                        }
                    }
                }
                if (finished)
                {
                    Console.WriteLine($"{names[nameIndex]} - fuel left {currentFuel:F2}");
                }
            }

            //main ends here
        }
    }
}
