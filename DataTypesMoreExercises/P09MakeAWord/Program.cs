using System;
using System.Text;

namespace P09MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());

            StringBuilder word = new StringBuilder();

            for (int i = 0; i < numberOfCharacters; i++)
            {
                word.Append(Console.ReadLine());
            }

            Console.WriteLine("The word is: " + word);

            //main ends here
        }
    }
}
