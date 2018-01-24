using System;

namespace P05ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "unknown";

            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
            }

            Console.WriteLine(language);

            //main ends here
        }
    }
}
