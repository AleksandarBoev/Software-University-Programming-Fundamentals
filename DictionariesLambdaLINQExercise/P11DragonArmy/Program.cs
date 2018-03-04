using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P11DragonArmy
{
    class DragonStats
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public DragonStats(int damage, int health, int armor)
        {
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public DragonStats()
        {

        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, DragonStats>> typeDragonName = new Dictionary<string, Dictionary<string, DragonStats>>();
            // type -> name -> stats
            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0].Trim();
                string name = input[1].Trim();
                string damageInput = input[2].Trim();
                string healthInput = input[3].Trim();
                string armorInput = input[4].Trim();

                int damage = 45; //defaults
                int health = 250;
                int armor = 10;

                if (damageInput != "null")
                {
                    damage = int.Parse(damageInput);
                }

                if (healthInput != "null")
                {
                    health = int.Parse(healthInput);
                }

                if (armorInput != "null")
                {
                    armor = int.Parse(armorInput);
                }



                if (typeDragonName.ContainsKey(type) == false) // ako nqma takuv tip drakon
                {
                    DragonStats dragonStats = new DragonStats(damage, health, armor);
                    Dictionary<string, DragonStats> nameStats = new Dictionary<string, DragonStats>();
                    nameStats.Add(name, dragonStats);
                    typeDragonName.Add(type, nameStats);
                }
                else // ako tozi tip drakoni veche sushtestvuva => to moje i da sushtestvuva drakon s takova ime
                {
                    if (typeDragonName[type].ContainsKey(name) == false) // ako nqma drakon s takova ime
                    {
                        DragonStats dragonStats = new DragonStats(damage, health, armor);
                        typeDragonName[type].Add(name, dragonStats);
                    }
                    else // ako ima drakon s takova ime
                    {
                        DragonStats dragonStats = new DragonStats(damage, health, armor);
                        typeDragonName[type][name] = dragonStats;
                    }

                }
            }


            foreach (var kvp in typeDragonName)
            {
                double[] averageStats = GetAverageStats(kvp.Value); 
                Console.WriteLine($"{kvp.Key}::({averageStats[0]:F2}/{averageStats[1]:F2}/{averageStats[2]:F2})");
                foreach (var kvp2 in kvp.Value.OrderBy(name => name.Key)) // kvp.Value = Dictionary<dragonName, dragonStats>
                {
                    Console.WriteLine($"-{kvp2.Key} -> damage: {kvp2.Value.Damage}, health: {kvp2.Value.Health}" +
                        $", armor: {kvp2.Value.Armor}");
                }
            }

            //main ends here
        }

        static double[] GetAverageStats(Dictionary<string, DragonStats> dragonNameStats)
        {
            double[] result = new double[3]; // [0] -> averageDamage, [1] -> averageHealth, [2] -> averageArmor

            int sumDamage = 0;
            int sumHealth = 0;
            int sumArmor = 0;

            foreach (var kvp in dragonNameStats)
            {
                sumDamage += kvp.Value.Damage;
                sumHealth += kvp.Value.Health;
                sumArmor += kvp.Value.Armor;
            }

            result[0] = (double)sumDamage / dragonNameStats.Count;
            result[1] = (double)sumHealth / dragonNameStats.Count;
            result[2] = (double)sumArmor / dragonNameStats.Count;

            return result;
        }

    }
}
