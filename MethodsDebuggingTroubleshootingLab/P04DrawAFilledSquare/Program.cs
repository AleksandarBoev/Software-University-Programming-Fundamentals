using System;

namespace P04DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintAll(n);

            //main ends here
        }

        static string ReturnStr(string buildWith, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += buildWith;
            }

            return result;
        }

        static void PrintBorder(int count)
        {
            Console.WriteLine(ReturnStr("-", count * 2)); // ili ("--", count)
        }

        static void PrintInside(int count)
        {
            for (int row = 0; row < count - 2; row++)
            {
                Console.WriteLine($"-{ReturnStr("\\/", count - 1)}-");
            }
        }

        static void PrintAll(int count)
        {
            PrintBorder(count);
            PrintInside(count);
            PrintBorder(count);
        }

        //class ends here
    }
}
