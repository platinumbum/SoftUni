using System;
using System.Collections.Generic;
using System.Linq;

namespace P04BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] parts = input.Split();
                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    identifiables.Add(new Citizen(name, age, id));
                }
                else
                {
                    string model = parts[0];
                    string id = parts[1];
                    identifiables.Add(new Robot(model, id));
                }
            }
            string filterId = Console.ReadLine();

            var filtered = identifiables.Where(i => i.Id.EndsWith(filterId)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
