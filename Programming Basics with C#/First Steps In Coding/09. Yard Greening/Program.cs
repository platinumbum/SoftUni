using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSize = double.Parse(Console.ReadLine());
            double price = yardSize * 7.61;
            double discount = 0.18 * price;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is " + finalPrice + " lv.");
            Console.WriteLine("The discount is " + discount + " lv.");
        }
    }
}
