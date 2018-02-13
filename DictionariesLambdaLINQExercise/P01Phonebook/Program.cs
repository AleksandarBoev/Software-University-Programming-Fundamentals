using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameNumber = new Dictionary<string, string>();

            string command = "";

            while (true) // moje while(input = Console.ReadLine() != "END")
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
            }

            //main ends here
        }
    }
}
