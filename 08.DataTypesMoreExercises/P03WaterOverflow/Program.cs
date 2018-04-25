using System;

namespace P03WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte tankLiters = 0;

            for (int i = 0; i < n; i++)
            {
                
                try
                {
                    byte fill = byte.Parse(Console.ReadLine());
                    checked
                    {
                        tankLiters += fill;
                    }
                    
                }
                catch 
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(tankLiters);

            //main ends here
        }
    }
}
