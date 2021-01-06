using System;

namespace _06._Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometricShape = Console.ReadLine();

            if (geometricShape == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = squareSide * squareSide;
                Console.WriteLine($"{squareArea:f3}");
            }

            else if (geometricShape == "rectangle")
            {
                double rectangleSideA = double.Parse(Console.ReadLine());
                double rectangleSideB = double.Parse(Console.ReadLine());

                Console.WriteLine($"{rectangleSideA * rectangleSideB:f3}");
            }
            else if (geometricShape == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());

                Console.WriteLine($"{circleRadius * circleRadius * Math.PI:f3}");
            }
            else if (geometricShape == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());

                Console.WriteLine($"{triangleSide * triangleHeight / 2:f3}");
            }
        }
    }
}
