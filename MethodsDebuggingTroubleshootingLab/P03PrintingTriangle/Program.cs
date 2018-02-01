using System;

namespace P03PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            PrintTriangle(size);

            //main ends here
        }

        static void PrintTriangle(int triangleSize)
        {
            for (int row = 1; row <= triangleSize; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            //lower part
            for (int row = triangleSize - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

        }

        //class ends here
    }
}
