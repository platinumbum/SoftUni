using System;
using System.Collections.Generic;
using System.Text;

namespace P01Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double airConditionerModifier)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionareModifier = airConditionerModifier;
        }
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        private double AirConditionareModifier { get; set; }

        public void Drive(double distance)
        {
            double needetFuel = (FuelConsumption + AirConditionareModifier) * distance;
            if (needetFuel > FuelQuantity)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= needetFuel;
        }

        public virtual void Refuel(double litersFueled)
        {
             FuelQuantity += litersFueled;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
