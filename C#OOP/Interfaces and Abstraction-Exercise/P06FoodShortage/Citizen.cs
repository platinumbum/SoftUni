using System;
using System.Collections.Generic;
using System.Text;

namespace P06FoodShortage
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string birthday, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
            this.Id = id;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthday { get; private set; }

        public string Id { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
