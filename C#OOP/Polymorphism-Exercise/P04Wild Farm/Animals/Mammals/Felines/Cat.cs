using P04Wild_Farm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double BaseWeightModifier = 0.3;

        private static HashSet<string> catAllowedFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable)
        };
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, catAllowedFoods, BaseWeightModifier, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
