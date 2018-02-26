using System;
using System.Collections.Generic;
using System.IO;

namespace P01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("readThis.txt");
            List<string> oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("writeToThis.txt", oddLines);
            //main ends here
        }
    }
}
