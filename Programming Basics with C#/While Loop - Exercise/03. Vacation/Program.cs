using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyOwned = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (moneyOwned < moneyNeeded)
            {
                daysCounter++;
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (input == "spend")
                {
                    spendingCounter++;
                    if (spendingCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                    moneyOwned -= money;
                    if (moneyOwned < 0)
                    {
                        moneyOwned = 0;
                    }
                }
                else if (input == "save")
                {
                    spendingCounter = 0;
                    moneyOwned += money;
                }


            }
            if (moneyOwned >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
