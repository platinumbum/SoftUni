using System;
using System.Collections.Generic;
using System.Text;

namespace P05BirthdayCelebrations
{
    public class Pet : IPet
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public string Name { get; private set; }

        public string Birthday { get; private set; }
    }
}
