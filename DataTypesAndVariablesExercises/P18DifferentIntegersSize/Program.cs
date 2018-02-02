using System;
using System.Numerics;
using System.Text;

namespace P18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //(sbyte < byte < short < ushort < int < uint < long).
            bool isParsed = false;

            string number = Console.ReadLine();
            StringBuilder answer = new StringBuilder();
            answer.Append(number + " can fit in:\n");

            try
            {
                sbyte sbyteNumber = sbyte.Parse(number);
                answer.Append("* sbyte\n");
                isParsed = true;
            } 
            catch
            {

            }

            try
            {
                byte byteNumber = byte.Parse(number);
                answer.Append("* byte\n");
                isParsed = true;
            }
            catch
            {

            }

            try
            {
                short shortNumber = short.Parse(number);
                answer.Append("* short\n");
                isParsed = true;
            }
            catch
            {

            }

            try
            {
                ushort ushortNumber = ushort.Parse(number);
                answer.Append("* ushort\n");
                isParsed = true;
            }
            catch
            {

            }

            try
            {
                int intNumber = int.Parse(number);
                answer.Append("* int\n");
                isParsed = true;
            }
            catch
            {

            }

            try
            {
                uint uintNumber = uint.Parse(number);
                answer.Append("* uint\n");
                isParsed = true;
            }
            catch
            {

            }

            try
            {
                long longNumber = long.Parse(number);
                answer.Append("* long\n");
                isParsed = true;
            }
            catch
            {

            }

            if (!isParsed)
            {
                Console.WriteLine($"{number} can't fit in any type");
            } else
            {
                Console.WriteLine(answer);
            }
            //main ends here
        }
    }
}
