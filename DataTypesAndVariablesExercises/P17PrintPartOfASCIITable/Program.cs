using System;

namespace P17PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int ascIIcode1 = int.Parse(Console.ReadLine());
            int ascIIcode2 = int.Parse(Console.ReadLine());

            for (int i = Math.Min(ascIIcode1, ascIIcode2); i <= Math.Max(ascIIcode1, ascIIcode2); i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
            Console.WriteLine();

            //main ends here
        }
    }
}
