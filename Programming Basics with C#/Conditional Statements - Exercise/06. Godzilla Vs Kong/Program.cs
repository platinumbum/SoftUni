using System;

namespace _06._Godzilla_Vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceForClothesPerExtra = double.Parse(Console.ReadLine());

            double totalPriceForClothes = extras * priceForClothesPerExtra;
            double decor = budget * 0.1;

            if (extras > 150)
            {
                totalPriceForClothes *= 0.9;
            }

            if (decor + totalPriceForClothes > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(decor + totalPriceForClothes) - budget:f2} leva more.");
            }
            else if (decor + totalPriceForClothes <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - (decor + totalPriceForClothes):f2} leva left.");
            }
        }
    }
}
