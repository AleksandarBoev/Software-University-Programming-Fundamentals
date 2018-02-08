using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = "";

            while (command != "Odd" && command != "Even")
            {
                string[] userInput = Console.ReadLine().Split(' ').ToArray();
                command = userInput[0]; //vinagi purviq element na masiva e komandata
                
                switch (command)
                {
                    case "Delete":
                        int deleteThisValue = int.Parse(userInput[1]);
                        while (numbers.Remove(deleteThisValue))
                        {

                        }
                            break;
                    case "Insert":
                        int index = int.Parse(userInput[1]);
                        int value = int.Parse(userInput[2]);
                        numbers.Insert(index, value);
                        break;

                    case "Odd":
                        foreach (var item in numbers)
                        {
                            if (item % 2 == 1)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                    case "Even":
                        foreach (var item in numbers)
                        {
                            if (item % 2 == 1)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        break;
                }

                
            }

            //main ends here
        }


        //class ends here
    }
}
