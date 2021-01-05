using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());

            double bannanasWeight = double.Parse(Console.ReadLine());
            double orangesWeight = double.Parse(Console.ReadLine());
            double raspberryWeight = double.Parse(Console.ReadLine());
            double strawberryWeight = double.Parse(Console.ReadLine());

            double raspberryKilloPrice = strawberryPrice / 2;
            double orangesKilloPrice = raspberryKilloPrice - ((raspberryKilloPrice * 40) / 100);
            double banannasKilloPrice = raspberryKilloPrice - ((raspberryKilloPrice * 80) / 100);

            double raspberryFinalPrice = raspberryWeight * raspberryKilloPrice;
            double orangesFinalPrice = orangesKilloPrice * orangesWeight;
            double bannanasFinalPrice = banannasKilloPrice * bannanasWeight;
            double strawberryFinalPrice = strawberryPrice * strawberryWeight;

            double totalSum = raspberryFinalPrice + orangesFinalPrice + bannanasFinalPrice + strawberryFinalPrice;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
