using System;
using System.Collections.Generic;
using System.Text;

namespace P05BirthdayCelebrations
{
    interface IPet : IBirthable
    {
        public string Name { get; }
    }
}
