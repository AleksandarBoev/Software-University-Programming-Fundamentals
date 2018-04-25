using System;

namespace P04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int count = 0;
            while (numberOfPeople > 0)
            {
                numberOfPeople -= elevatorCapacity;
                count++;
            }

            Console.WriteLine(count);

            //main ends here
        }
    }
}
