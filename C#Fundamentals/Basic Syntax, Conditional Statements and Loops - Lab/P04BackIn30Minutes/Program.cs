using System;

namespace P04BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int futureMinutes = minutes + 30;
            if (futureMinutes > 59)
            {
                hours++;
                futureMinutes = futureMinutes - 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (futureMinutes < 10)
            {
                Console.WriteLine($"{hours}:0{futureMinutes}");
            }
            else
            { 
                Console.WriteLine($"{hours}:{futureMinutes}");
            }
        }
    }
}
