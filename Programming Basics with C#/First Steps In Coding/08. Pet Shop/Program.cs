using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogs = double.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());

            double dogFood = dogs * 2.5;
            int animalFood = animals * 4;


            Console.WriteLine(dogFood + animalFood + " lv.");
        }
    }
}
