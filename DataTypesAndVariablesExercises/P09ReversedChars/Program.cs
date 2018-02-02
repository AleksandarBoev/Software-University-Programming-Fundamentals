using System;
using System.Text;

namespace P09ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder reverse = new StringBuilder();
            reverse.Append(Console.ReadLine());
            reverse.Append(Console.ReadLine());
            reverse.Append(Console.ReadLine());

            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                Console.Write(reverse[i]);
            }

            //main ends here
        }
    }
}
