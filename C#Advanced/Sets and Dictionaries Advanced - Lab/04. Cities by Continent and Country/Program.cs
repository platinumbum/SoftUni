using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> allData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] continentCountryCity = Console.ReadLine().Split();
                string continent = continentCountryCity[0];
                string country = continentCountryCity[1];
                string city = continentCountryCity[2];

                if (!allData.ContainsKey(continent))
                {
                    allData.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!allData[continent].ContainsKey(country))
                {
                    allData[continent].Add(country, new List<string>());
                }

                allData[continent][country].Add(city);
            }

            foreach (var continent in allData)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");

                    for (int i = 0; i < country.Value.Count; i++)
                    {
                        if (i != 0)
                        {
                            Console.Write(", ");
                        }
                        Console.Write($"{country.Value[i]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
