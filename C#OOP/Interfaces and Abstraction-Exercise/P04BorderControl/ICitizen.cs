using System;
using System.Collections.Generic;
using System.Text;

namespace P04BorderControl
{
    public interface ICitizen : IIdentifiable
    {
        public string Name { get; }

        public int Age { get; }

        
    }
}
