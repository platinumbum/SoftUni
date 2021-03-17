using System;
using System.Collections.Generic;
using System.Text;

namespace P04BorderControl
{
    public interface IRobot : IIdentifiable
    {
        public string Model { get; }

        
    }
}
