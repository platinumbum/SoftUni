using System;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string nameOfProduct = Console.ReadLine();
            int numOfProducts = 0;
            bool isEnough = false;
            double moneySpend = 0;
            while (nameOfProduct != "Stop")
            {
                double priceOfProduct = double.Parse(Console.ReadLine());
                numOfProducts++;
                if (numOfProducts % 3 == 0)
                {
                    priceOfProduct = priceOfProduct / 2;
                }
                if (budget - priceOfProduct < 0)
                {
                    double moneyNeeded = priceOfProduct - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    break;
                }

                budget -= priceOfProduct;
                moneySpend += priceOfProduct;
                


                nameOfProduct = Console.ReadLine();
                if (nameOfProduct == "Stop")
                {
                    isEnough = true;
                }
            }
            if (isEnough)
            {
                Console.WriteLine($"You bought {numOfProducts} products for {moneySpend:f2} leva.");
            }
        }
    }
}
