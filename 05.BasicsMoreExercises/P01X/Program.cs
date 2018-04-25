using System;

namespace P01X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numberOfSpaces = n - 2;

            //upper half:
            int i = 0;
            for (i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}", new string(' ', i), 'x', new string(' ', numberOfSpaces - 2 * i));
            }

            //half:
            Console.WriteLine(new string(' ', i) + 'x');

            //lower half:
            for (int j = i - 1; j >= 0; j--)
            {
                Console.WriteLine("{0}{1}{2}{1}", new string(' ', j), 'x', new string(' ', numberOfSpaces - 2 * j));
            }

            //main ends here
        }
    }
}
