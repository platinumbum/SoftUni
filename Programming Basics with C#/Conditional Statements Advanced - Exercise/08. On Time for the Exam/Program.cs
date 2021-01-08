using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            minutesOfExam += hourOfExam * 60;
            minutesOfArrival += hourOfArrival * 60;

            if (minutesOfArrival > minutesOfExam)
            {
                Console.WriteLine("Late");
                difference = minutesOfArrival - minutesOfExam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (minutesOfArrival < minutesOfExam - 30)
            {
                Console.WriteLine("Early");
                difference = minutesOfExam - minutesOfArrival;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On Time");
                difference = minutesOfExam - minutesOfArrival;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
