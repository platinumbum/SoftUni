using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kittens : Cat
    {
        private const string DeffaultGender = "Female";
        public Kittens(string name, int age) : base(name, age, DeffaultGender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
