using System;
using System.Text;

namespace P03TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder multipleStringOperations = new StringBuilder();
            multipleStringOperations.Append(Console.ReadLine());

            for (int i = 0; i < bannedWords.Length; i++)
            {
                multipleStringOperations.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(multipleStringOperations.ToString());
            //main ends here
        }
    }
}
