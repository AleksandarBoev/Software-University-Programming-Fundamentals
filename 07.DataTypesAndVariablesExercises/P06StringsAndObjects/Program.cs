using System;

namespace P06StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = Console.ReadLine();
            string world = Console.ReadLine();

            object concatStrings = hello + " " + world;

            string output = Convert.ToString(concatStrings);

            Console.WriteLine(output);

            //main ends here
        }
    }
}
