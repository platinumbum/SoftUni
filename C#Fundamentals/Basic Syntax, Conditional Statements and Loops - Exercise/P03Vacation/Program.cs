using System;

namespace P03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfHuman = Console.ReadLine();
            string typeOfDay = Console.ReadLine();
            double Totalprice = 0;

            switch (typeOfHuman)
            {
                case "Students":
                    if (typeOfDay == "Friday")
                    {
                        Totalprice = numberOfPeople * 8.45;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        Totalprice = numberOfPeople * 9.80;
                    }
                    else if (typeOfDay == "Sunday")
                    {
                        Totalprice = numberOfPeople * 10.46;
                    }
                    if (numberOfPeople >= 30)
                    {
                        Totalprice *= 0.85;
                    }

                    break;
                case "Business":
                    if (numberOfPeople >= 100)
                    {
                        numberOfPeople -= 10;
                    }
                    if (typeOfDay == "Friday")
                    {
                        Totalprice = numberOfPeople * 10.90;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        Totalprice = numberOfPeople * 15.60;
                    }
                    else if (typeOfDay == "Sunday")
                    {
                        Totalprice = numberOfPeople * 16;
                    }

                    break;
                case "Regular":
                    if (typeOfDay == "Friday")
                    {
                        Totalprice = numberOfPeople * 15;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        Totalprice = numberOfPeople * 20;
                    }
                    else if (typeOfDay == "Sunday")
                    {
                        Totalprice = numberOfPeople * 22.50;
                    }
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        Totalprice *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {Totalprice:f2}");
        }
    }
}
