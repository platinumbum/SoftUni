using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, string food)
        {
            this.Name = name;
            this.FavouriteFood = food;
        }

        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
