using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthSpace = int.Parse(Console.ReadLine());
            int lengthSpace = int.Parse(Console.ReadLine());
            int heightSpace = int.Parse(Console.ReadLine());

            int volume = widthSpace * lengthSpace * heightSpace;
            bool hasVolume = true;

            string input = Console.ReadLine();

            while (!(input == "Done"))
            {
                int box = int.Parse(input);
                volume -= box;

                if (volume < 0)
                {
                    hasVolume = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (hasVolume)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
