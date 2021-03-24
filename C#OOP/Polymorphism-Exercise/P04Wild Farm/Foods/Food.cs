using System;
using System.Collections.Generic;
using System.Text;

namespace P04Wild_Farm.Foods
{
    public class Food
    {
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; set; }
    }
}
