using System;
using System.Collections.Generic;
using System.Linq;

namespace P02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> nameNumber = new SortedDictionary<string, string>();

            string command = "";

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                command = input[0];

                if (command == "A")
                {
                    string contactName = input[1];
                    string contactNumber = input[2];

                    if (nameNumber.ContainsKey(contactName) == false)
                    {
                        nameNumber.Add(contactName, contactNumber);
                    }
                    else
                    {
                        nameNumber[contactName] = contactNumber;
                    }
                }
                else if (command == "S")
                {
                    string contactName = input[1];
                    if (nameNumber.ContainsKey(contactName))
                    {
                        Console.WriteLine($"{contactName} -> {nameNumber[contactName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contactName} does not exist.");
                    }
                }
                else if (command == "END")
                {
                    break;
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in nameNumber)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
            }

            //main ends here
        }
    }
}
