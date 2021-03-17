using System;
using System.Collections.Generic;
using System.Linq;

namespace P05BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] parts = input.Split();
                string type = parts[0];
                if (type == nameof(Citizen))
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthday = parts[4];

                    birthables.Add(new Citizen(name, age, id, birthday));
                }
                else if (type == nameof(Pet))
                {
                    string name = parts[1];
                    string birthday = parts[2];

                    birthables.Add(new Pet(name, birthday));
                }

            }

            string filterYear = Console.ReadLine();

            List<IBirthable> filtered = birthables.Where(b => b.Birthday.EndsWith(filterYear)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Birthday);
            }
        }
    }
}
