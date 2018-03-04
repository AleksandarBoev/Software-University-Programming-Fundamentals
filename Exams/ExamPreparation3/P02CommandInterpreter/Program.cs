using System;
using System.Collections.Generic;
using System.Linq;

namespace P02CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            while (true)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "end")
                {
                    break;
                }

                string[] command = currentInput.Split();
                if (command[0] == "reverse")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if (IsValidData(start, count, input))
                    {
                        input = ReverseCommand(start, count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command[0] == "sort")
                {
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    if (IsValidData(start, count, input))
                    {
                        input = SortCommand(start, count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command[0] == "rollLeft")
                {
                    int count = int.Parse(command[1]);
                    if (IsValidData(count))
                    {
                        input = RollLeftCommand(count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (command[0] == "rollRight")
                {
                    int count = int.Parse(command[1]);
                    if (IsValidData(count))
                    {
                        input = RollRightCommand(count, input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    //if (IsValidData())
                }

            }

            Console.WriteLine("[" + string.Join(", ", input) + "]");

            //main ends here
        }

        static bool IsValidData(int start, int count, string[] input)
        {
            if (start < 0 || start >= input.Length || count < 0 || start + count > input.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsValidData(int count)
        {
            if (count < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static string[] ReverseCommand(int start, int count, string[] input)
        {
            string[] part1 = input.Take(start).ToArray();
            string[] part2 = input.Skip(start).Take(count).ToArray();
            string[] part3 = input.Skip(start + count).ToArray();
            
            part2 = part2.Reverse().ToArray();

            return part1.Concat(part2.Concat(part3)).ToArray();
        }

        static string[] SortCommand(int start, int count, string[] input)
        {
            string[] part1 = input.Take(start).ToArray();
            string[] part2 = input.Skip(start).Take(count).ToArray();
            string[] part3 = input.Skip(start + count).ToArray();

            Array.Sort(part2);

            return part1.Concat(part2.Concat(part3)).ToArray();
        }

        static string[] RollLeftCommand(int count, string[] input) // do it with a list and .add and .remove
        {
            count %= input.Length;
            List<string> temp = input.ToList();
            for (int i = 0; i < count; i++)
            {
                string save = temp[0];
                temp.RemoveAt(0);
                temp.Add(save);
            }

            return temp.ToArray();
        }

        static string[] RollRightCommand(int count, string[] input)
        {
            count %= input.Length;
            List<string> temp = input.ToList();
            for (int i = 0; i < count; i++)
            {
                string save = temp[temp.Count - 1];
                temp.RemoveAt(temp.Count - 1);
                temp.Insert(0, save);
            }

            return temp.ToArray();
        }


        //class ends here
    }
}
