using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDays = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string review = Console.ReadLine();

            double room = 0;
            double total = 0;
            double discount = 0;
            

            if (typeOfRoom == "room for one person")
            {
                room = 18.00;
                total = vacationDays * room;
            }
            else if (typeOfRoom == "apartment")
            {
                room = 25.00;
                if (vacationDays < 10)
                {
                    total = (vacationDays * room)*0.70;
                }
                else if (vacationDays >= 10 && vacationDays <= 15)
                {
                    total = (vacationDays * room) * 0.65;
                }
                else if (vacationDays > 15)
                {
                    total = (vacationDays * room) * 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                room = 35.00;
                if (vacationDays < 10)
                {
                    total = (vacationDays * room) * 0.90;
                }
                else if (vacationDays >= 10 && vacationDays <= 15)
                {
                    total = (vacationDays * room) * 0.85;
                }
                else if (vacationDays > 15)
                {
                    total = (vacationDays * room) * 0.80;
                }
            }

            if (review == "positive")
            {
                discount = total * 0.25;
                total += discount;
            }
            else if (review == "negative")
            {
                discount = total * 0.10;
                total -= discount;
            }
            Console.WriteLine($"{total:f2}");
        }
        
    }
}
