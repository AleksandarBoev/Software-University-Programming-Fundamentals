using System;

namespace P15BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            byte openingBracketsCount = 0;
            byte closingBracketsCount = 0;
            string result = "BALANCED";

            for (int i = 0; i < numberOfStrings; i++)
            {
                string mathString = Console.ReadLine();

                if (mathString == "(")
                {
                    openingBracketsCount++;
                    if (openingBracketsCount > 1)
                    {
                        result = "UNBALANCED";
                    }
                }

                if (mathString == ")")
                {
                    closingBracketsCount++;
                    if (closingBracketsCount > 1 || openingBracketsCount == 0) // ne moje ") uravnenie..."
                    {
                        result = "UNBALANCED";
                    }
                }

                if (closingBracketsCount == 1 && openingBracketsCount == 1)
                {
                    closingBracketsCount--;
                    openingBracketsCount--;
                }

            }

            if (closingBracketsCount != 0 || openingBracketsCount != 0)
            {
                result = "UNBALANCED";
            }

            Console.WriteLine(result);

            //main ends here
        }
    }
}
