using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            int ticketPrice = 0;

            switch (dayOfTheWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    ticketPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    ticketPrice = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
