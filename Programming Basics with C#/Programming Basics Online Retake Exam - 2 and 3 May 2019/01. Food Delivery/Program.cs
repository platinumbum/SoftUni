using System;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfChikenMenus = int.Parse(Console.ReadLine());
            int numOfFishMenus = int.Parse(Console.ReadLine());
            int numOfVegetarianMenus = int.Parse(Console.ReadLine());

            double chikenMenuPrice = (numOfChikenMenus * 10.35);
            double fishMenuPrice = (numOfFishMenus * 12.40);
            double vegeterianMenuPrice =(numOfVegetarianMenus * 8.15);
            double desert = (chikenMenuPrice + fishMenuPrice + vegeterianMenuPrice) * 0.20;
            double total = chikenMenuPrice + fishMenuPrice + vegeterianMenuPrice + desert + 2.50;
            Console.WriteLine($"Total: {total:f2}");


        }
    }
}
