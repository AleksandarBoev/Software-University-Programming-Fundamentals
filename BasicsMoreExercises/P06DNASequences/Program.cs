using System;

namespace P06DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaCode = int.Parse(Console.ReadLine());

            string nucleoidAcidSequence = "ACGT";
            sbyte count = 0; //max = 4

            for (int i = 0; i < nucleoidAcidSequence.Length; i++)
            {
                for (int j = 0; j < nucleoidAcidSequence.Length; j++)
                {
                    for (int k = 0; k < nucleoidAcidSequence.Length; k++)
                    {
                        char specialChar;

                        if (i + 1 + j + 1 + k + 1 >= dnaCode) // ACGT -> [0][1][2][3] -> A = 1, C = 2, G = 3, T = 4 points
                        {
                            specialChar = 'O';
                        } else
                        {
                            specialChar = 'X';
                        }

                        Console.Write($"{specialChar}{nucleoidAcidSequence[i]}{nucleoidAcidSequence[j]}{nucleoidAcidSequence[k]}{specialChar} ");
                        count++;

                        if (count == 4)
                        {
                            Console.WriteLine();
                            count = 0;
                        }

                    }
                }
            }

            //main ends here
        }
    }
}
