using System;
using System.Linq;

namespace P06Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int priceJewels = prices[0];
            int priceGold = prices[1];

            string heist = "";
            int heistTotalExpenses = 0; // kazano e ot 1...200000 , no ne e spomenato che shte e 100% integer
            int heistTotalEarnings = 0;

            while (true)
            {
                heist = Console.ReadLine();
                if (heist == "Jail Time")
                {
                    break;
                }

                string[] heistInfo = heist.Split(' ').ToArray();
                int currentHeistExpenses = int.Parse(heistInfo[1]);
                heistTotalExpenses += currentHeistExpenses;
                // jewels = % , gold = $
                int numberOfJewels = GetCharacterRecurrence(heistInfo[0], '%');
                int numberOfGoldBricks = GetCharacterRecurrence(heistInfo[0], '$');

                heistTotalEarnings += numberOfJewels * priceJewels + numberOfGoldBricks * priceGold;

            }

            if (heistTotalEarnings >= heistTotalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {heistTotalEarnings - heistTotalExpenses}.");
            } 
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {heistTotalExpenses - heistTotalEarnings}.");
            }

            //main ends here
        }

        static int GetCharacterRecurrence(string word, char character)
        {
            int count = 0;
            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == character)
                {
                    count++;
                }
            }

            return count;
        }

        //class ends here
    }
}
