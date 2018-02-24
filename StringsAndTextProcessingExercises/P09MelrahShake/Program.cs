using System;
using System.Linq;
using System.Text;

namespace P09MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            //main ends here
        }

        static string Shake(string text, string pattern)
        {
            string reversedPattern = String.Concat(pattern.Reverse());
            int i1 = text.IndexOf(reversedPattern);
            int i2 = text.LastIndexOf(pattern);

            int i3 = text.IndexOf(pattern);
            int i4 = text.LastIndexOf(reversedPattern);

            if (i1 != i2)
            {

            }
            return "hello!";
        }

    }
}
