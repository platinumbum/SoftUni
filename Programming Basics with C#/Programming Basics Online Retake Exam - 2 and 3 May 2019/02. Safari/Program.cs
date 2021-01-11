using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double litersNeeded = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            int guidePrice = 100;
            double pricePerLitre = 2.10; 
            double total = (litersNeeded * pricePerLitre) + guidePrice;
            

            if (day == "Saturday")
            {
                total *= 0.90;
            }
            else if (day == "Sunday")
            {
                total *= 0.80;
            }

            if (total <= budget)
            {
                double moneyLeft = budget - total;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }

        }
    }
}
