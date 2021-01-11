using System;

namespace _03._Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int numOfMonths = int.Parse(Console.ReadLine());

            double pricePerMonth = 0;
            double totalPrice = 0;
            if (contract == "one")
            {
                if (typeOfContract == "Small")
                {
                    pricePerMonth = 9.98;
                }
                else if (typeOfContract == "Middle")
                {
                    pricePerMonth = 18.99;
                }
                else if (typeOfContract == "Large")
                {
                    pricePerMonth = 25.98;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    pricePerMonth = 35.99;
                }
                if (internet == "yes")
                {

                    if (pricePerMonth <= 10)
                    {
                        pricePerMonth += 5.50;
                    }
                    else if (pricePerMonth <= 30 && pricePerMonth > 10)
                    {
                        pricePerMonth += 4.35;
                    }
                    else if (pricePerMonth > 30)
                    {
                        pricePerMonth += 3.85;
                    }
                }
                totalPrice = numOfMonths * pricePerMonth;
            }
            else if (contract == "two")
            {
                if (typeOfContract == "Small")
                {
                    pricePerMonth = 8.58;
                }
                else if (typeOfContract == "Middle")
                {
                    pricePerMonth = 17.09;
                }
                else if (typeOfContract == "Large")
                {
                    pricePerMonth = 23.59;
                }
                else if (typeOfContract == "ExtraLarge")
                {
                    pricePerMonth = 31.79;
                }
                if (internet == "yes")
                {

                    if (pricePerMonth <= 10)
                    {
                        pricePerMonth += 5.50;
                    }
                    else if (pricePerMonth <= 30 && pricePerMonth > 10)
                    {
                        pricePerMonth += 4.35;
                    }
                    else if (pricePerMonth > 30)
                    {
                        pricePerMonth += 3.85;
                    }
                }
                totalPrice = (numOfMonths * pricePerMonth) * 0.9625;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
