using System;
using System.Text;

namespace P13DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfCharacters = int.Parse(Console.ReadLine());

            StringBuilder decryptedMessage = new StringBuilder();

            for (int character = 0; character < numberOfCharacters; character++)
            {
                char currentCharacter = char.Parse(Console.ReadLine());
                currentCharacter = (char)(currentCharacter + key);
                decryptedMessage.Append(currentCharacter);
            }

            Console.WriteLine(decryptedMessage);

            //main ends here
        }
    }
}
