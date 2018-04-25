using System;

namespace P09CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    count++;
                }
                catch
                {
                    Console.WriteLine(count);
                    break;
                }
            }

            //main ends here
        }
    }
}
