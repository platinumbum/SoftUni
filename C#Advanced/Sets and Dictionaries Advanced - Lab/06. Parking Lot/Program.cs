using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (input != "END")
            {
                string[] command = input.Split(", ");
                string inOrOut = command[0];
                string car = command[1];

                if (inOrOut == "IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }

                input = Console.ReadLine();
            }

            if (cars.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
