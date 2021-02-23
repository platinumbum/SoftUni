using System;

namespace P09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double startMoney = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalPriceOfLightSabers = Math.Ceiling(numberOfStudents * 1.1) * priceOfLightsaber;
            double totalPriceOfRobes = numberOfStudents * priceOfRobe;
            double totalPriceOfBelts = (numberOfStudents - (Math.Floor((double)numberOfStudents / 6))) * priceOfBelt; ;

            double totalPrice = totalPriceOfLightSabers + totalPriceOfRobes + totalPriceOfBelts;
            if (totalPrice <= startMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - startMoney:f2}lv more.");
            }
        }
    }
}
