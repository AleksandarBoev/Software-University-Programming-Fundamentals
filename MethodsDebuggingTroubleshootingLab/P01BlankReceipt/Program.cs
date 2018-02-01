using System;

namespace P01BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();

            //main ends here
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT" + System.Environment.NewLine + "------------------------------");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------" + Environment.NewLine + "\u00A9 SoftUni");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        //class ends here
    }
}
