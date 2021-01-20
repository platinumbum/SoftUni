using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int boxCapacity = int.Parse(Console.ReadLine());
            Stack<int> allClothes = new Stack<int>(clothesInput);
            int boxCount = 1;
            int currentBox = boxCapacity;

            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();
                currentBox -= clothes;

                if (currentBox < 0)
                {
                    boxCount++;
                    currentBox = boxCapacity;
                    currentBox -= clothes;
                }
            }
            Console.WriteLine(boxCount);
        }
    }
}
