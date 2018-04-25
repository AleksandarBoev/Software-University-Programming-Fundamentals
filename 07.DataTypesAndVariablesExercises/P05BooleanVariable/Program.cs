using System;

namespace P05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string booleanStr = Console.ReadLine();
            if (Convert.ToBoolean(booleanStr))
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

            //main ends here
        }
    }
}
