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
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> currentCommand = Console.ReadLine().Split(' ').ToList();

                if (currentCommand[0] == "Delete")
                {
                    int removeValue = int.Parse(currentCommand[1]);
                    while (numbers.Contains(removeValue))
                    {
                        numbers.Remove(removeValue);
                    }
                }
                else if (currentCommand[0] == "Insert") 
                {
                    int insertValue = int.Parse(currentCommand[1]);
                    int insertIndex = int.Parse(currentCommand[2]);
                    numbers.Insert(insertIndex, insertValue);
                }
                else if (currentCommand[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write("" + numbers[i] + ' ');
                        }
                    }
                    return;
                }
                else if (currentCommand[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write("" + numbers[i] + ' ');
                        }
                    }
                    return;
                }

            }

            //main ends here
        }


        //class ends here
    }
}
