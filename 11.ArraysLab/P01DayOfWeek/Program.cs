using System;
using System.Linq;

namespace P01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int dayOfWeek = int.Parse(Console.ReadLine()) - 1;

            if (0 <= dayOfWeek && dayOfWeek <= 6)
            {
                Console.WriteLine(days[dayOfWeek]);
            } else
            {
                Console.WriteLine("Invalid Day!");
            }

            //main ends here
        }
    }
}
