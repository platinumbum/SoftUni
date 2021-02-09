using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveled)
        {
            double neededFuel = distanceTraveled * FuelConsumptionPerKilometer;

            if (neededFuel > FuelAmount)
            {
                return false;
            }

            FuelAmount -= neededFuel;
            TravelledDistance += distanceTraveled;
            return true;
        }
    }
}
