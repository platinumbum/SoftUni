using System;
using System.Collections.Generic;
using System.Text;

namespace P06FoodShortage
{
    public interface IBuyer
    {
        public int Food { get; }

        void BuyFood();
    }
}
