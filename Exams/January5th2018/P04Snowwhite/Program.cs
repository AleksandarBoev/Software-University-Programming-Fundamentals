using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Snowwhite
{
    class Dwarf // dali nqma da e po-dobre Dictionary(string, Dwarf) no dwarf da nqma Color
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physic { get; set; }
        public int ColorCount{ get; set; }

        public Dwarf(string name, string color, int physic)
        {
            Name = name;
            Color = color;
            Physic = physic;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }

                string[] dwarfInfo = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physic = int.Parse(dwarfInfo[2]);

                if (GetColorCount(color, dwarfs) == 0) // ako nqma takuv cvqt
                {
                    Dwarf currentDwarf = new Dwarf(name, color, physic);
                    dwarfs.Add(currentDwarf);
                }
                else // ako ima takuv cvqt
                {
                    if (GetDwarfIndex(color, name, dwarfs) == -1) // cvetut go ima, no nqma djudje s takuv cvqt i takova ime
                    {
                        Dwarf currentDwarf = new Dwarf(name, color, physic);
                        dwarfs.Add(currentDwarf);
                    }
                    else // ako ima takova djudje s cvqt i ime
                    {
                        int index = GetDwarfIndex(color, name, dwarfs);
                        dwarfs[index].Physic = Math.Max(dwarfs[index].Physic, physic);
                    }
                }
            }

            for (int i = 0; i < dwarfs.Count; i++)
            {
                int colorCount = 0;
                string currentColor = dwarfs[i].Color;
                colorCount = GetColorCount(currentColor, dwarfs);
                dwarfs[i].ColorCount = colorCount;
            }

            foreach (var dwarf in dwarfs.OrderByDescending(p => p.Physic).ThenByDescending(c => c.ColorCount))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physic}");
            }

            //main ends here
        }

        static int GetDwarfIndex(string color, string name, List<Dwarf> dwarfs)
        {
            for (int i = 0; i < dwarfs.Count; i++)
            {
                if (dwarfs[i].Name == name && dwarfs[i].Color == color)
                {
                    return i;
                }
            }
            return -1; // ako nqma takova djudje
        }

        static int GetColorCount(string color, List<Dwarf> dwarfs)
        {
            int result = 0;
            for (int i = 0; i < dwarfs.Count; i++)
            {
                if (dwarfs[i].Color == color)
                {
                    result++;
                }
            }
            return result; // ako e 0 znachi nqma takuv cvqt
        }
        //program class ends here
    }
}
