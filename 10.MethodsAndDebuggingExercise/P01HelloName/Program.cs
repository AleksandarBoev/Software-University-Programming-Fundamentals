using System;

namespace P01HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
            //main ends here
        }

        static void PrintGreeting(string aName)
        {
            Console.WriteLine($"Hello, {aName}!");
        }

        //class ends here
    }
}
