using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rosesPrice = 5;
            const double dahliasPrice = 3.8;
            const double tulipsPrice = 2.8;
            const double narcissusPrice = 3;
            const double gladiolusPrice = 2.5;

            string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;


            if (flowerType == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    price -= rosesPrice * numberOfFlowers * 0.10;
                }
                price += rosesPrice * numberOfFlowers;
            }
            else if (flowerType == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    price -= dahliasPrice * numberOfFlowers * 0.15;
                }
                price += dahliasPrice * numberOfFlowers;
            }
            else if (flowerType == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    price -= numberOfFlowers * tulipsPrice * 0.15;
                }
                price += numberOfFlowers * tulipsPrice;
            }
            else if (flowerType == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    price += numberOfFlowers * narcissusPrice * 0.15;
                }
                price += numberOfFlowers * narcissusPrice;
            }
            else
            {
                if (numberOfFlowers < 80)
                {
                    price += numberOfFlowers * gladiolusPrice * 0.20;
                }
                price += numberOfFlowers * gladiolusPrice;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");

            }
        }
    }
}
