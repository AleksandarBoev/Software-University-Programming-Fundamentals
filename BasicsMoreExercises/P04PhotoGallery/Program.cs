using System;

namespace P04PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            long bytesMemory = long.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");

            double result = bytesMemory;
            string sizeType = "B";
            
            if (1000 <= bytesMemory && bytesMemory < 1000000)
            {
                result =(double)bytesMemory / 1000;
                sizeType = "KB";
            } else if (bytesMemory >= 1000000)
            {
                result = (double)bytesMemory / 1000000;
                sizeType = "MB";
            }

            Console.WriteLine($"Size: {result}{sizeType}");

            Console.Write($"Resolution: {width}x{height} ");
            if (width > height)
            {
                Console.Write("(landscape)");
            } else if (width < height)
            {
                Console.Write("(portrait)");
            } else
            {
                Console.Write("(square)");

            }

            //main ends here
        }
    }
}
