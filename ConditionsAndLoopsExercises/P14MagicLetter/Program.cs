using System;

namespace P14MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = Console.ReadLine()[0];
            char character2 = char.Parse(Console.ReadLine());
            char exclude = char.Parse(Console.ReadLine());

            for (char i = character1; i <= character2; i++)
            {
                if (i == exclude)
                {
                    continue;
                }

                for (char j = character1; j <= character2; j++)
                {
                    if (j == exclude)
                    {
                        continue;
                    }

                    for (char k = character1; k <= character2; k++)
                    {
                        if (k == exclude)
                        {
                            continue;
                        }

                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }

            //main ends here
        }
    }
}
