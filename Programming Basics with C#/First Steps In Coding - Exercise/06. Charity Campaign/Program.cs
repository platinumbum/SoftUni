using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakePrice = 45;
            double wafflePrice = 5.8;
            double pancakePrice = 3.2;

            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfChefs = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());


            int cakesSold = numberOfCakes * cakePrice;
            double wafflesSold = numberOfWaffles * wafflePrice;
            double pancakeSold = numberOfPancakes * pancakePrice;

            double moneyRaisedForDay = (cakesSold + wafflesSold + pancakeSold) * numberOfChefs;
            double moneyRaisedOverall = moneyRaisedForDay * numberOfDays;

            double moneyRaisedAfterTax = moneyRaisedOverall - (moneyRaisedOverall / 8);

            Console.WriteLine(moneyRaisedAfterTax);
        }
    }
}
