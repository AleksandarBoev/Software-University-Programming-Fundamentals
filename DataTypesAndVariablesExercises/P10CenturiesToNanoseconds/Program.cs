using System;
using System.Numerics;

namespace P10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte centuries = sbyte.Parse(Console.ReadLine());
            ushort years = (ushort) (centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            long minutes = (long)(hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds" +
                $" = {microseconds} microseconds = {nanoseconds} nanoseconds");
            //main ends here
        }
    }
}
