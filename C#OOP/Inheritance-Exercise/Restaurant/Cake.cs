using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DeffaultGrams = 250;
        private const double DeffaultCalories = 1000;
        private const decimal DeffaultPrice = 5M;
        public Cake(string name) : base(name, DeffaultPrice, DeffaultGrams, DeffaultCalories)
        {
        }
    }
}
