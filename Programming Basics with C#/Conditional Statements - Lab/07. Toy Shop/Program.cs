using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.6;
            double dollPrice = 3;
            double bearPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2;


            double vacationPrice = double.Parse(Console.ReadLine());
            int NumberOfPuzzles = int.Parse(Console.ReadLine());
            int NumberOfDolls = int.Parse(Console.ReadLine());
            int NumberOfBears = int.Parse(Console.ReadLine());
            int NumberOfMinions = int.Parse(Console.ReadLine());
            int NumberOfTrucks = int.Parse(Console.ReadLine());

            int allOfTheToys = NumberOfPuzzles + NumberOfDolls + NumberOfBears + NumberOfMinions + NumberOfTrucks;
            double sumOfTheToys = (puzzlePrice * NumberOfPuzzles) + (dollPrice * NumberOfDolls) + (bearPrice * NumberOfBears) + (minionPrice * NumberOfMinions) + (truckPrice * NumberOfTrucks);

            if (allOfTheToys >= 50)
            {
                sumOfTheToys *= 0.75;

            }

            //rent
            sumOfTheToys *= 0.9;

            if (sumOfTheToys >= vacationPrice)
            {
                Console.WriteLine($"Yes! {sumOfTheToys - vacationPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationPrice - sumOfTheToys:f2} lv needed.");
            }
        }
    }
}
