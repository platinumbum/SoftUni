using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

            double timeSwimmed = distanceInMeters * timeInSecondsForOneMeter;
            double lenghts = Math.Floor(distanceInMeters / 15);
            double totalTime = timeSwimmed + lenghts * 12.5;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }
        }
    }
}
