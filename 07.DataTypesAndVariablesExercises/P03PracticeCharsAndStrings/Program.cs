using System;

namespace P03PracticeCharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            char character3 = Console.ReadLine()[0];
            string str2 = Console.ReadLine();

            Console.WriteLine(str1);
            Console.WriteLine(character1);
            Console.WriteLine(character2);
            Console.WriteLine(character3);
            Console.WriteLine(str2);

            //main ends here
        }
    }
}
