using System;
using System.Collections.Generic;
using System.Linq;

namespace P02ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] commands = input.Split();
                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers = Exchange(numbers, index);
                }
                else if (commands[0] == "max")
                {
                    if (commands[1] == "odd")
                    {
                        PrintMaxOddIndex(numbers);
                    }
                    else if (commands[1] == "even")
                    {
                        PrintMaxEvenIndex(numbers);
                    }
                }
                else if (commands[0] == "min")
                {
                    if (commands[1] == "odd")
                    {
                        PrintMinOddIndex(numbers);
                    }
                    else if (commands[1] == "even")
                    {
                        PrintMinEvenIndex(numbers);
                    }
                }
                else if (commands[0] == "first")
                {
                    int count = int.Parse(commands[1]);
                    if (commands[2] == "odd")
                    {
                        PrintFirstOdd(numbers, count);
                    }
                    else if (commands[2] == "even")
                    {
                        PrintFirstEven(numbers, count);
                    }
                }
                else if (commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);
                    if (commands[2] == "odd")
                    {
                        PrintLastOdd(numbers, count);
                    }
                    else if (commands[2] == "even")
                    {
                        PrintLastEven(numbers, count);
                    }
                }

            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");

            //main ends here
        }

        static void PrintMaxOddIndex(int[] numbers)
        {
            int resultIndex = -1;
            int maxOdd = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 && numbers[i] >= maxOdd) // >= because we must return the rightmost element
                {
                    maxOdd = numbers[i];
                    resultIndex = i;
                }
            }
            if (resultIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(resultIndex);
        }

        static void PrintMinOddIndex(int[] numbers)
        {
            int resultIndex = -1;
            int minOdd = 1001; // array elements values are in [0..1000]
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 && numbers[i] <= minOdd) // >= because we must return the rightmost element
                {
                    minOdd = numbers[i];
                    resultIndex = i;
                }
            }
            if (resultIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(resultIndex);
        }

        static void PrintMaxEvenIndex(int[] numbers)
        {
            int resultIndex = -1;
            int maxEven = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] >= maxEven) 
                {
                    maxEven = numbers[i];
                    resultIndex = i;
                }
            }
            if (resultIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(resultIndex);
        }

        static void PrintMinEvenIndex(int[] numbers)
        {
            int resultIndex = -1;
            int minEven = 1001;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] <= minEven) 
                {
                    minEven = numbers[i];
                    resultIndex = i;
                }
            }
            if (resultIndex == -1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine(resultIndex);
        }

        static void PrintFirstEven(int[] numbers, int count)
        {
            if (count < 0 || count > numbers.Length) //potenicalen problem
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> result = new List<int>();
            if (count == 0)
            {
                Console.WriteLine("[]");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        static void PrintFirstOdd(int[] numbers, int count)
        {
            if (count < 0 || count > numbers.Length) //potenicalen problem
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> result = new List<int>();
            if (count == 0)
            {
                Console.WriteLine("[]");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    result.Add(numbers[i]);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        static void PrintLastEven(int[] numbers, int count)
        {
            if (count < 0 || count > numbers.Length) //potenicalen problem
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> result = new List<int>();
            if (count == 0)
            {
                Console.WriteLine("[]"); ;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }
            result.Reverse();
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        static void PrintLastOdd(int[] numbers, int count)
        {
            if (count < 0 || count > numbers.Length) //potenicalen problem
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> result = new List<int>();
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1)
                {
                    result.Add(numbers[i]);
                    if (result.Count == count)
                    {
                        break;
                    }
                }
            }
            result.Reverse();
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        static int[] Exchange(int[] numbers, int index)
        {
            int[] firstPart = numbers.Take(index + 1).ToArray();
            int[] secondPart = numbers.Skip(index + 1).ToArray();
            int[] result = secondPart.Concat(firstPart).ToArray(); // test it
            return result;
        }

        //class ends here
    }
}
