using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premiere = 12;
            const double normal = 7.5;
            const double discount = 5;

            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double total = 0;

            switch (typeOfMovie)
            {
                case "Premiere":
                    total = (rows * colums) * premiere;
                    break;
                case "Normal":
                    total = (rows * colums) * normal;
                    break;
                case "Discount":
                    total = (rows * colums) * discount;
                    break;

            }
            Console.WriteLine($"{total:f2} leva");
        }
    }
}
