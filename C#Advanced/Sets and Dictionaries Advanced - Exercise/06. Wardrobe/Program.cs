﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] allClothing = input.Skip(1).ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                Dictionary<string, int> currentColorClothing = wardrobe[color];

                foreach (var item in allClothing)
                {
                    if (!currentColorClothing.ContainsKey(item))
                    {
                        currentColorClothing.Add(item, 0);
                    }
                    currentColorClothing[item]++;
                }

            }

            string[] searchData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach ((string color, Dictionary<string, int> colorData) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach ((string clothing, int count) in colorData)
                {
                    if (searchData[0] == color && searchData[1] == clothing)
                    {
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing} - {count}");
                    }
                }

            }
        }
    }
}
