using System;

namespace P07SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            int numberOfIds = int.Parse(Console.ReadLine());

            long largestIdNumber = long.MinValue;

            if (dataType == "sbyte")
            {
                sbyte id = 0;
                for (int count = 0; count < numberOfIds; count++)
                {
                    try
                    {
                        id = sbyte.Parse(Console.ReadLine());
                        if (id > largestIdNumber)
                        {
                            largestIdNumber = id;
                        }
                    }
                    catch { }

                }
            }
            else if (dataType == "int")
            {
                int id = 0;
                for (int count = 0; count < numberOfIds; count++)
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                        if (id > largestIdNumber)
                        {
                            largestIdNumber = id;
                        }
                    }
                    catch { }
                }
            }
            else if (dataType == "long")
            {
                long id = 0;
                for (int count = 0; count < numberOfIds; count++)
                {
                    try
                    {
                        id = long.Parse(Console.ReadLine());
                        if (id > largestIdNumber)
                        {
                            largestIdNumber = id;
                        }
                    }
                    catch { };
                }
            }

            long yearsSentence = 0;

            if (largestIdNumber < 0)
            {
                yearsSentence = (long)Math.Ceiling(largestIdNumber / -128m);
            }
            else if (largestIdNumber > 0)
            {
                yearsSentence = (long)Math.Ceiling(largestIdNumber / 127m);
            }
            else // ==0
            {
                yearsSentence = 0;
            }

            string answer = $"Prisoner with id {largestIdNumber} is sentenced to {yearsSentence} year";
            if (yearsSentence > 1)
            {
                answer += 's';
            }

            Console.WriteLine(answer);

            //main ends here
        }
    }
}
