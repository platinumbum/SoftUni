using System;
using System.Collections.Generic;
using System.Text;

namespace P02VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerModifier = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity, TruckAirConditionerModifier)
        {
        }

        public override void Refuel(double litersFueled)
        {
            
            if (litersFueled <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + litersFueled > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {litersFueled} fuel in the tank");
            }
            FuelQuantity += litersFueled * 0.95;
        }
    }
}
