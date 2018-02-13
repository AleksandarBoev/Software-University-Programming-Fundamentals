using System;
using System.Collections.Generic;
using System.Linq;

namespace P04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameEmail = new Dictionary<string, string>();

            int count = 1;
            string lastEnteredName = "";

            while (true)
            {
                
                string input = Console.ReadLine().Trim();
                if (input == "stop")
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    lastEnteredName = input;
                    nameEmail.Add(lastEnteredName, "");
                }
                else
                {
                    string email = input;
                    nameEmail[lastEnteredName] = email;
                }

                count++;
            }

            foreach (var kvp in nameEmail)
            {
                string checkNationality = string.Join("", kvp.Value.Skip(kvp.Value.Length - 2)).ToLower();
                if (checkNationality != "us" && checkNationality != "uk") // .EndsWith(" ") shteshe da e po-lesno...
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }

            //main ends here
        }
    }
}
