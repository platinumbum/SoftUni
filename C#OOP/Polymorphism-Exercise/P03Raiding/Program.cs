using System;
using System.Collections.Generic;

namespace P03Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            while (heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero = CreateHero(type, name);

                if (hero == null)
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                heroes.Add(hero);
                
            }

            int bossHealth = int.Parse(Console.ReadLine());
            ;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                bossHealth -= hero.Power;
            }
            if (bossHealth <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string type, string name)
        {
            BaseHero hero = null;

            if (type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }

            return hero;
        }
    }
}
