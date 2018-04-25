using System;

namespace P05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = 1; i <= int.Parse(number); i++)
            {
                int sum = 0;
                foreach (var character in i.ToString())
                {
                    sum += character - '0';
                }
                Console.Write($"{i} -> ");
                Console.WriteLine(sum == 5 || sum == 7 || sum == 11);
                
            }


            //main ends here
        }
    }
}
