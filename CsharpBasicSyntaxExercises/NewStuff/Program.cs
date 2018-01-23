using System;

namespace NewStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine($"{number:00.00}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                number += i;
            }
        }
    }
}
