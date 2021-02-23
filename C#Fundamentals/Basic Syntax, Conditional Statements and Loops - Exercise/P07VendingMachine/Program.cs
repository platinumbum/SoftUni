using System;

namespace P07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;
            double nuts = 2.0;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1.0;

            while (input != "Start")
            {
                double moneyAdded = double.Parse(input);
                if (moneyAdded == 0.1 || 
                    moneyAdded == 0.2 ||
                    moneyAdded == 0.5 || 
                    moneyAdded == 1 || 
                    moneyAdded == 2)
                {
                    totalMoney += moneyAdded;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyAdded}");
                }

                input = Console.ReadLine();
            }

            string buy = Console.ReadLine();
            while (buy != "End")
            {
                if (buy == "Nuts")
                {
                    if (nuts > totalMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= nuts;
                        Console.WriteLine("Purchased nuts");
                    }

                }
                else if (buy == "Water")
                {
                    if (water > totalMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= water;
                        Console.WriteLine("Purchased water");
                    }
                }
                else if (buy == "Crisps")
                {
                    if (crisps > totalMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= crisps;
                        Console.WriteLine("Purchased crisps");
                    }
                }
                else if (buy == "Soda")
                {
                    if (soda > totalMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= soda;
                        Console.WriteLine("Purchased soda");
                    }
                }
                else if (buy == "Coke")
                {
                    if (coke > totalMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= coke;
                        Console.WriteLine("Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                buy = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
