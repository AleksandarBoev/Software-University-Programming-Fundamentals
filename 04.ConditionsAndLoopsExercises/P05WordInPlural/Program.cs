using System;

namespace P05WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y")) //judge gurmi ako se napishe word.EndsWith('y') poradi nqkakva prichina
            {
                word = word.Remove(word.Length - 1);
                word = word.Insert(word.Length, "ies");
            }
            else if (word.EndsWith("o") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh"))
            {
                word = word.Insert(word.Length, "es");
            } else 
            {
                word = word.Insert(word.Length, "s");
            }

                Console.WriteLine(word);

            //main ends here
        }
    }
}
