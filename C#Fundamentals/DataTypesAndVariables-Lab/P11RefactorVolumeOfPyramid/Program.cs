using System;

namespace P11RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double hight = double.Parse(Console.ReadLine());

            
            double volume = (length * width * hight) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");

        }
    }
}
