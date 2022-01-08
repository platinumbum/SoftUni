using System;
using System.Collections.Generic;
using System.Linq;
namespace P04ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();

                products.Add(currentProduct);
            }

            products.Sort();
            foreach (var item in products)
            {
                
                Console.WriteLine($"{number}.{item}");
                number += 1;

            }
        }
    }
}