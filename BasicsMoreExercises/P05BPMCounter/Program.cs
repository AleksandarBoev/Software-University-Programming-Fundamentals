using System;

namespace P05BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            int time = (int)((double)beats / beatsPerMinute * 60);
            int minutes = time / 60;
            int seconds = time % 60;
            double bars = Math.Round((double)beats / 4, 1);

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");

            //main ends here
        }
    }
}
