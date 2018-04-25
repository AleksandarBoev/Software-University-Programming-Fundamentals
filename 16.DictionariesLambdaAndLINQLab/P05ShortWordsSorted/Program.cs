using System;
using System.Linq;

namespace P05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лявата страна на ламбда оператора => определя входните параметри на анонимната функция, а дясната страна представлява 
            //израз или последователност от оператори, която работи с входните параметри и евентуално връща някакъв резултат.
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                
                .Where(x => x.Length < 5)
                .ToArray();
            // прочети стринг от конзолата -> превърни го в lowercase -> раздели го, използвайки масив от чарове и премахни празните клетки ->
            // -> липсва .Select(), защото вече си е стринг -> приеми само тези, отговарящи на условието... -> върни масив
            input = input.OrderBy(x => x).ToArray(); // трябва да се подаде функция (метод, който връща стойност). В този случай просто се подава и връща елемент
            input = input.Distinct().ToArray();

            Console.WriteLine(string.Join(", ", input));

            //main ends here
        }
    }
}
