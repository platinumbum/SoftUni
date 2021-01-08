using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int springRent = 3000;
            const int summerAndFallRent = 4200;
            const int winterRent = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());
            double totalPrice = 0;


            if (season == "Spring")
            {
                if (numberOfFisherman <= 6)
                {
                    totalPrice = springRent - (springRent * 0.10);
                }
                else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                {
                    totalPrice = springRent - (springRent * 0.15);
                }
                else if (numberOfFisherman > 12)
                {
                    totalPrice = springRent - (springRent * 0.25);
                }
            }
            if (season == "Summer" || season == "Autumn")
            {
                if (numberOfFisherman <= 6)
                {
                    totalPrice = summerAndFallRent - (summerAndFallRent * 0.10);
                }
                else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                {
                    totalPrice = summerAndFallRent - (summerAndFallRent * 0.15);
                }
                else if (numberOfFisherman > 12)
                {
                    totalPrice = summerAndFallRent - (summerAndFallRent * 0.25);
                }
            }
            if (season == "Winter")
            {
                if (numberOfFisherman <= 6)
                {
                    totalPrice = winterRent - (winterRent * 0.10);
                }
                else if (numberOfFisherman >= 7 && numberOfFisherman <= 11)
                {
                    totalPrice = winterRent - (winterRent * 0.15);
                }
                else if (numberOfFisherman > 12)
                {
                    totalPrice = winterRent - (winterRent * 0.25);
                }
            }
            if (numberOfFisherman % 2 == 0 && season != "Autumn")
            {
                totalPrice -= totalPrice * 0.05;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - totalPrice):f2} leva left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget):f2} leva.");
            }
        }
    }
}
