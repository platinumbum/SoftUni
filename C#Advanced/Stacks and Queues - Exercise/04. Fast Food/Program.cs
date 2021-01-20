using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queuedOrders = new Queue<int>(orders);

            while (true)
            {
                if (queuedOrders.Peek() <= foodQuantity)
                {
                    foodQuantity -= queuedOrders.Dequeue();
                    if (queuedOrders.Count == 0)
                    {
                        Console.WriteLine(orders.Max());
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else if (queuedOrders.Peek() > foodQuantity)
                {
                    Console.WriteLine(orders.Max());
                    Console.WriteLine($"Orders left: {string.Join(" ", queuedOrders)}");
                    break;
                }
            }
        }
    }
}
