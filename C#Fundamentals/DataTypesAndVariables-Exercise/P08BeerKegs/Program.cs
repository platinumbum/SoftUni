using System;

namespace P08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                
                
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double currentVolume = Math.PI * (Math.Pow(radius, 2)) * height;
                if (currentVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentVolume;
                    biggestKeg = model;

                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
