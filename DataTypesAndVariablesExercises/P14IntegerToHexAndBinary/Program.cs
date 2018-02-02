using System;

namespace P14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNum = int.Parse(Console.ReadLine());

            string twoBase = Convert.ToString(decimalNum, 2);
            string sixteenBase = Convert.ToString(decimalNum, 16);
            
            Console.WriteLine(sixteenBase.ToUpper());
            Console.WriteLine(twoBase);
            //main ends here
        }
    }
}
