using P04Wild_Farm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double BaseWeightModifier = 0.4;

        private static HashSet<string> dogAllowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, dogAllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
