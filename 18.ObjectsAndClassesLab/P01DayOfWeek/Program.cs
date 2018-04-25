using System;
using System.Globalization;
using System.Linq;

namespace P01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // trqbva "input" i "format" da sa podobni na vid za da se poluchi programata

            //Solution 1:
            //string format = "d-M-yyyy";
            //DateTime date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture); // invariantCulture oznachava den->mesec->godina

            //Console.WriteLine(date.DayOfWeek);

            // Solution 2:
            int[] dateInfo = input.Split('-').Select(x => int.Parse(x)).ToArray();
            int day = dateInfo[0];
            int month = dateInfo[1];
            int year = dateInfo[2];

            DateTime dateTime = new DateTime(year, month, day); // v tozi red se chetat neshtata

            Console.WriteLine(dateTime.DayOfWeek);

            //main ends here
        }
    }
}
