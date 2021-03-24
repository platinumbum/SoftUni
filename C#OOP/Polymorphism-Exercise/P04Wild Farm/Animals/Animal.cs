using P04Wild_Farm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight, int foodEaten, HashSet<string> allowedFoods, double weightModifier)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
            this.AllowedFoods = allowedFoods;
            this.WeightModifier = weightModifier;
        }

        protected Animal(string name, double weight, HashSet<string> allowedFoods, double weightModifier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFoods;
            WeightModifier = weightModifier;
        }

        private HashSet<string> AllowedFoods { get; set; }

        public double WeightModifier { get; set; }
        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            if (!AllowedFoods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;

            this.Weight += this.WeightModifier * food.Quantity;
        }
    }
}
