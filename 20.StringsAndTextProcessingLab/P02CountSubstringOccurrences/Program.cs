using System;

namespace P02CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int occurenceCount = 0;
            int index = text.IndexOf(word); // vrushta indexa na purvata bukva na dumata
            while(index != -1) // funkciqta vrushta indeks ili -1 ako ne e namereno nishto
            {
                occurenceCount++;
                index = text.IndexOf(word, index + 1); // tursi indeksa na dumata SLED indeksa na purvata bukva na namerenata duma
            }

            Console.WriteLine(occurenceCount);
            //main ends here
        }
    }
}
