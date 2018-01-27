using System;

namespace P11FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a < 5)
            {
                Console.WriteLine("No");
                return;
            }

            int n1 = a;
            int n2 = a + 1;
            int n3 = a + 2;
            int n4 = a + 3;
            int n5 = a + 4;

            for (n1 = a; n1 < n2; n1++)
            {
                for (n2 = n1 + 1; n2 < n3; n2++)
                {
                    for (n3 = n2 + 1; n3 < n4; n3++)
                    {
                        for (n4 = n3 + 1; n4 <= b; n4++)
                        {
                            for (n5 = n4 + 1; n5 <= b; n5++)
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", n1, n2, n3, n4, n5);
                            }
                        }
                    }
                }
            }

            //main ends here
        }
    }
}
