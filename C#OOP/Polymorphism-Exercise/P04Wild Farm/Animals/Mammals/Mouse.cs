using P04Wild_Farm.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifier = 0.1;

        private static HashSet<string> mouseAllowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, mouseAllowedFoods, BaseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
