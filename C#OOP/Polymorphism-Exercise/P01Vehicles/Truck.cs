using System;
using System.Collections.Generic;
using System.Text;

namespace P01Vehicles
{
    public class Truck : Vehicle
    {
        private const double TruckAirConditionerModifier = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption, TruckAirConditionerModifier)
        {
        }

        public override void Refuel(double litersFueled)
        {
            base.Refuel(litersFueled * 0.95);
        }
    }
}
