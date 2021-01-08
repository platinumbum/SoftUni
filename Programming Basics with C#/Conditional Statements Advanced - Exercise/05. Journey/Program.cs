using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string campOrHotel = "";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    campOrHotel = "Camp";
                    price = budget * 0.30;
                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    campOrHotel = "Hotel";
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    campOrHotel = "Camp";
                    price = budget * 0.40;
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    campOrHotel = "Hotel";
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                campOrHotel = "Hotel";
                price = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrHotel} - {price:f2}");
        }
    }
}
