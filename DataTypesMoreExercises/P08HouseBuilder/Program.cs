using System;
using System.Numerics;

namespace P08HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteNumber = 0;
            int intNumber = 0;

            string number = Console.ReadLine();

            try
            {
                sbyteNumber = sbyte.Parse(number);
                intNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                intNumber = int.Parse(number);
                sbyteNumber = sbyte.Parse(Console.ReadLine());
            }

            BigInteger price = (4 * sbyteNumber) + (10 * (BigInteger)intNumber); //sigurno shte stane i s "long"
            Console.WriteLine(price);

            //main ends here
        }
    }
}
