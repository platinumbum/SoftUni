using System;

namespace P11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int bestQuality = 0;
            int bestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;

            for (int i = 0; i < count; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());


                int snowballValue = (int)Math.Pow(snowballSnow / snowballTime, (int)snowballQuality);
                if (snowballValue > bestValue)
                {
                    bestQuality = snowballQuality;
                    bestValue = snowballValue;
                    bestTime = snowballTime;
                    bestSnow = snowballSnow;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
