using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double precentege = double.Parse(Console.ReadLine());

            double literOfWater = 0.001;

            double sizeOfTank = length * width * height;
            double litersInTank = sizeOfTank * literOfWater;
            double percentegeTank = precentege * 0.01;

            double littersNeeded = litersInTank * (1 - percentegeTank);

            Console.WriteLine(littersNeeded);
        }
    }
}
