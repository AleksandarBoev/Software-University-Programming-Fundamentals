using System;

namespace P06CatchTheThief
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
            } else if (dataType == "int")
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
            } else if (dataType == "long")
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

            Console.WriteLine(largestIdNumber);

            //main ends here
        }
    }
}
