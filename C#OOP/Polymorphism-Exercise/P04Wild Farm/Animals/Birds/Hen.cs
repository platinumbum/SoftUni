using P04Wild_Farm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Animals.Birds
{
    public class Hen : Bird
    {
        private const double BaseWeightModifier = 0.35;

        private static HashSet<string> henAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, henAllowedFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
