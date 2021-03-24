using System;
using System.Collections.Generic;
using System.Text;

namespace P02VehiclesExtension
{
    public abstract class Vehicle
    {
        private double truckAirConditionerModifier;
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double airConditionerModifier)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionareModifier = airConditionerModifier;
            
        }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double truckAirConditionerModifier)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.truckAirConditionerModifier = truckAirConditionerModifier;
        }

        public double FuelQuantity { get => this.fuelQuantity; 
            protected set 
            {
                if (value > TankCapacity )
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            } 
        }

        public double FuelConsumption { get; private set; }

        protected double AirConditionareModifier { get; set; }

        public double TankCapacity { get; private set; }

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
            if (litersFueled <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + litersFueled > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {litersFueled} fuel in the tank");
            }
            FuelQuantity += litersFueled;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
