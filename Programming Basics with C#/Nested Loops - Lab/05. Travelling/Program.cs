using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string country = Console.ReadLine();

                if (country == "End")
                {
                    break;
                }


                double moneyNeeded = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < moneyNeeded)
                {
                    double input = double.Parse(Console.ReadLine());

                    savedMoney += input;
                }
                Console.WriteLine($"Going to {country}!");
            }
        }
    }
}
