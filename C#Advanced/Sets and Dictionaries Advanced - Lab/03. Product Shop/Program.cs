using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> foodShops = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] cmdArg = command.Split(", ");
                string shop = cmdArg[0];
                string product = cmdArg[1];
                double price = double.Parse(cmdArg[2]);

                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                }

                if (!foodShops[shop].ContainsKey(product))
                {
                    foodShops[shop].Add(product, price);
                }


                command = Console.ReadLine();
            }

            foodShops = foodShops.OrderBy(s => s.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var shop in foodShops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
