﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P05BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bomb = bombInfo[0];
            int power = bombInfo[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int curentNum = numbers[i];
                if (curentNum == bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}