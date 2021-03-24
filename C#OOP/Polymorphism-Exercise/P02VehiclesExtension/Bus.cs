using System;
using System.Collections.Generic;
using System.Text;

namespace P02VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double BusAirConditionerModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption,tankCapacity, BusAirConditionerModifier)
        {
        }

        public void TurnOnAirConditioner()
        {
            this.AirConditionareModifier = BusAirConditionerModifier;
        }

        public void TurnOffAirConditioner()
        {
            this.AirConditionareModifier = 0;
        }
    }
}
