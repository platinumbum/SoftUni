using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesOfTheBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hoursPerDay = (pagesOfTheBook / pagesPerHour) / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
