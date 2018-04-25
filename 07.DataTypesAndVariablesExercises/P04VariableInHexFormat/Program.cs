using System;

namespace P04VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalFormat = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(decimalFormat);


        }
    }
}
