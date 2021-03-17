using System;
using System.Collections.Generic;
using System.Text;

namespace P05BirthdayCelebrations
{
    interface IRobot : IIdentifiable
    {
        public string Model { get; }
    }
}
