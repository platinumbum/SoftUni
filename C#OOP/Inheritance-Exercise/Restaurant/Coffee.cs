using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DeffaultMilliliters = 50;
        private const decimal DeffaultPrice = 3.50M;
        
        public Coffee(string name, double caffeine) : base(name, DeffaultPrice, DeffaultMilliliters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine { get; set; }

         
    }
}
