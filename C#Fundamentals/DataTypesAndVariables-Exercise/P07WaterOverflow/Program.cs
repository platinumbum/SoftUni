using System;

namespace P07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentCharge = int.Parse(Console.ReadLine());
                tankCapacity += currentCharge;

                if (tankCapacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    tankCapacity -= currentCharge;
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
